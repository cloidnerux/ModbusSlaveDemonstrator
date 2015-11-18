using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using log4net;
using System.Net;
using System.Net.Sockets;
using Modbus;
using Modbus.Data;
using Modbus.Device;

namespace ModbusSlaveDemostrator {
	public partial class MainForm : Form {

		/// <summary>
		/// List of registers
		/// </summary>
		private List<RegValue> regValues;

		/// <summary>
		/// The used tcp listener to listen to the modbus master
		/// </summary>
		private TcpListener tcpListener;
		/// <summary>
		/// Modbus handler class
		/// </summary>
		private ModbusTcpSlave slave;

		private IPAddress address;

		/// <summary>
		/// The file name for the init values
		/// </summary>
		private string InitValuesFileName = "InitValues";

		private static readonly ILog log = LogManager.GetLogger(typeof(MainForm));

		public MainForm() {
			InitializeComponent();
			regValues = new List<RegValue>();
			log4net.Config.BasicConfigurator.Configure();
			RegisterListView.SetObjects(regValues);
		}

		private void ClearButton_Click(object sender, EventArgs e) {
			regValues.Clear();
			RegisterListView.SetObjects(regValues);
		}

		private void AddButton_Click(object sender, EventArgs e) {
			if(regValues.Where(x => x.Register == RegisterBox.Value).Count() != 0)
			{
				MessageBox.Show("Register " + RegisterBox.Value.ToString() + " already exists!");
				log.Info("Register " + RegisterBox.Value.ToString() + " already exists!");
				return;
			}
			regValues.Add(new RegValue((int)RegisterBox.Value, 0, DescriptionTextBox.Text));
			DescriptionTextBox.Text = "";
			RegisterBox.Value++;
			RegisterListView.SetObjects(regValues);
		}

		private void DeleteButton_Click(object sender, EventArgs e) {
			var tmp = regValues.Where(x => x.Register == RegisterBox.Value);
			if(tmp.Count() == 0) {
				MessageBox.Show("Register " + RegisterBox.Value.ToString() + " does not exists!");
				log.Info("Register " + RegisterBox.Value.ToString() + " does not exists!");
				return;
			}
			regValues.Remove(tmp.ElementAt(0));
			RegisterListView.SetObjects(regValues);
		}

		/// <summary>
		/// Enable cell editing in the register list view
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RegisterListView_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e) {
			if(e.Cancel || e.Column != ValueColumn)
				return;
			try {
				RegValue reg = e.RowObject as RegValue;
				reg.Value = (int)e.NewValue;
				if(slave == null)
					return;
				if(slave.DataStore != null)
					slave.DataStore.HoldingRegisters[reg.Register] = (ushort)reg.Value;
				//master.WriteSingleRegister(Convert.ToUInt16(reg.Register), Convert.ToUInt16(reg.Value));
			}
			catch(Exception ex) {
				MessageBox.Show("Error on writing new value: " + ex.Message);
			}
		}


		private void MainForm_Load(object sender, EventArgs e) {
			if(File.Exists(InitValuesFileName)) {
				try {
					StartParameter s = DeSerializeObject(InitValuesFileName);
					regValues = s.RegValues;
					RegisterListView.SetObjects(regValues);		
					IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
					IPAddress[] addr = ipEntry.AddressList;
					IpAdressBox.Items.AddRange(addr);
					if(addr.Contains(s.ModbusIPAddress))
					{
						IpAdressBox.SelectedText = s.ModbusIPAddress.ToString();
						IpAdressBox.SelectedItem = s.ModbusIPAddress;
						address = s.ModbusIPAddress;
					}
					else
					{
						IpAdressBox.SelectedText = IpAdressBox.Items[0].ToString();
						IpAdressBox.BackColor = Color.Red;
						address = (IPAddress)IpAdressBox.Items[0];
						IpAdressBox.SelectedItem = address;
					}
					//initValues = true;
				}
				catch(Exception ex) {
					log.Error("Error reading start parameter", ex);
				}
			}
		}

		/// <summary>
		/// Serialise the current config into a file to be used for the next start
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
			try {
				if(slave != null)
					slave.Dispose();
				if(tcpListener != null)
					tcpListener.Stop();
				StartParameter s = new StartParameter(regValues, (byte)UnitIdBox.Value, (int)PortBox.Value, address);
				if(!File.Exists(InitValuesFileName)) {
					File.Create(InitValuesFileName);
				}
				SerializeObject(InitValuesFileName, s);
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message);
				log.Error("Error writing start parameters", ex);
			}
		}

		public void SerializeObject(string filename, StartParameter objectToSerialize) {
			using(Stream stream = File.Open(filename, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite)) {
				BinaryFormatter bFormatter = new BinaryFormatter();
				bFormatter.Serialize(stream, objectToSerialize);
				stream.Close();
			}
		}

		public StartParameter DeSerializeObject(string filename) {
			StartParameter objectToSerialize;
			Stream stream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			BinaryFormatter bFormatter = new BinaryFormatter();
			objectToSerialize = (StartParameter)bFormatter.Deserialize(stream);
			stream.Close();
			stream.Dispose();
			return objectToSerialize;
		}

		private void StartButton_Click(object sender, EventArgs e) {
			if(StartButton.Text == "Start")
			{
				try{
					IpAdressBox.BackColor = UnitIdBox.BackColor;
					address = (IPAddress)IpAdressBox.SelectedItem;
					log.Info("IP Adress to bound to: " + address.ToString());
					tcpListener = new TcpListener(address, (int)PortBox.Value);
					tcpListener.Start();
					slave = ModbusTcpSlave.CreateTcp((byte)UnitIdBox.Value, tcpListener);
					slave.DataStore = Modbus.Data.DataStoreFactory.CreateDefaultDataStore();
					slave.DataStore.DataStoreWrittenTo += DataStore_DataStoreWrittenTo;
					slave.Listen();
					foreach(RegValue r in regValues)
						slave.DataStore.HoldingRegisters[r.Register] = (ushort)r.Value;
					StartButton.Text = "Stop";
				}
				catch(Exception ex)
				{
					log.Error("Error listening to modbus", ex);
					MessageBox.Show("Error starting Modbus!");
				}
			}
			else
			{
				slave.Dispose();
				tcpListener.Stop();
				StartButton.Text = "Start";
			}
		}

		void DataStore_DataStoreWrittenTo(object sender, DataStoreEventArgs e) {
			switch (e.ModbusDataType)
			{
				case ModbusDataType.HoldingRegister:
					for (int i = 0; i < e.Data.B.Count; i++)
					{
						//Set AO
						//e.Data.B[i] already write to
						var tmp = regValues.Where(x => x.Register == e.StartAddress + i + 1);
						tmp.ElementAt(0).Value = slave.DataStore.HoldingRegisters[e.StartAddress + i + 1];
						//e.StartAddress starts from 0
						//You can set AO value to hardware here
					}
					break;
				case ModbusDataType.Coil:
					break;
			}
		}

		private void LockButton_Click(object sender, EventArgs e) {
			if(LockButton.Text == "Lock")
			{
				slave.DoStupidStuff = true;
				LockButton.Text = "Unlock";
			}
			else
			{
				slave.DoStupidStuff = false;
				LockButton.Text = "Lock";
			}
		}

		private void RefreshButton_Click(object sender, EventArgs e) {
			IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
			IPAddress[] addr = ipEntry.AddressList;
			var tmp = IpAdressBox.SelectedText;
			var tmp2 = IpAdressBox.SelectedItem;
			IpAdressBox.Items.Clear();
			IpAdressBox.Items.AddRange(addr);
			if(addr.Contains(tmp2)) {
				IpAdressBox.SelectedText = tmp;
				IpAdressBox.SelectedItem = tmp2;
				address = (IPAddress)tmp2;
			}
			else
			{
				IpAdressBox.SelectedText = IpAdressBox.Items[0].ToString();
				IpAdressBox.BackColor = Color.Red;
				address = (IPAddress)IpAdressBox.Items[0];
				IpAdressBox.SelectedItem = address;
			}
		}

	}
}
