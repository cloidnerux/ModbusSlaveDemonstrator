using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace ModbusSlaveDemostrator
{

    [Serializable()]
    public class StartParameter
    {
        public IPAddress ModbusIPAddress
        {
            get;
            set;
        }

        public int Port
        {
            get;
            set;
        }

        public List<RegValue> RegValues
        {
            get;
            set;
        }

				public byte UnitID
				{
					get;
					set;
				}


        public StartParameter()
        {
           ModbusIPAddress = new IPAddress(0);
           Port = 502;
					 UnitID = 1;
           
					 // CoilStates = new List<CoilState>();
            RegValues = new List<RegValue>();
        }

			/*	public StartParameter(IPAddress address, int port)
					: base() {
					ModbusIPAddress = address;
					Port = port;
				}*/

        /*public StartParameter(IPAddress address, int port, List<CoilState> coilStates, List<RegValue> regValues)
        {
            ModbusIPAddress = address;
            Port = port;
            RegValues = regValues;
            CoilStates = coilStates;
        }*/

				public StartParameter(List<RegValue> regValues, byte UnitId, int port, IPAddress address) {
					RegValues = regValues;
					UnitID = UnitId;
					Port = port;
					ModbusIPAddress = address;
				}

    }
}
