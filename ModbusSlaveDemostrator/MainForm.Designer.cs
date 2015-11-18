namespace ModbusSlaveDemostrator {
	partial class MainForm {
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent() {
			this.StartButton = new System.Windows.Forms.Button();
			this.LockButton = new System.Windows.Forms.Button();
			this.AddButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.RegisterListView = new BrightIdeasSoftware.ObjectListView();
			this.RegisterColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.ValueColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.RegDescriptionColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.RegisterBox = new System.Windows.Forms.NumericUpDown();
			this.DescriptionTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.UnitIdBox = new System.Windows.Forms.NumericUpDown();
			this.PortBox = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.IpAdressBox = new System.Windows.Forms.ComboBox();
			this.RefreshButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.RegisterListView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RegisterBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UnitIdBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PortBox)).BeginInit();
			this.SuspendLayout();
			// 
			// StartButton
			// 
			this.StartButton.Location = new System.Drawing.Point(15, 61);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(75, 23);
			this.StartButton.TabIndex = 0;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// LockButton
			// 
			this.LockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LockButton.Location = new System.Drawing.Point(15, 357);
			this.LockButton.Name = "LockButton";
			this.LockButton.Size = new System.Drawing.Size(75, 23);
			this.LockButton.TabIndex = 1;
			this.LockButton.Text = "Lock";
			this.LockButton.UseVisualStyleBackColor = true;
			this.LockButton.Click += new System.EventHandler(this.LockButton_Click);
			// 
			// AddButton
			// 
			this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddButton.Location = new System.Drawing.Point(173, 301);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 3;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 307);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Register";
			// 
			// DeleteButton
			// 
			this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DeleteButton.Location = new System.Drawing.Point(254, 301);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteButton.TabIndex = 6;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(251, 61);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(75, 23);
			this.ClearButton.TabIndex = 7;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// RegisterListView
			// 
			this.RegisterListView.AllColumns.Add(this.RegisterColumn);
			this.RegisterListView.AllColumns.Add(this.ValueColumn);
			this.RegisterListView.AllColumns.Add(this.RegDescriptionColumn);
			this.RegisterListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RegisterListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
			this.RegisterListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RegisterColumn,
            this.ValueColumn,
            this.RegDescriptionColumn});
			this.RegisterListView.GridLines = true;
			this.RegisterListView.Location = new System.Drawing.Point(15, 97);
			this.RegisterListView.Name = "RegisterListView";
			this.RegisterListView.ShowGroups = false;
			this.RegisterListView.Size = new System.Drawing.Size(405, 201);
			this.RegisterListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.RegisterListView.TabIndex = 24;
			this.RegisterListView.UseCompatibleStateImageBehavior = false;
			this.RegisterListView.View = System.Windows.Forms.View.Details;
			this.RegisterListView.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.RegisterListView_CellEditFinishing);
			// 
			// RegisterColumn
			// 
			this.RegisterColumn.AspectName = "Register";
			this.RegisterColumn.CellPadding = null;
			this.RegisterColumn.Text = "Reg";
			this.RegisterColumn.Width = 72;
			// 
			// ValueColumn
			// 
			this.ValueColumn.AspectName = "Value";
			this.ValueColumn.CellPadding = null;
			this.ValueColumn.Text = "Value";
			this.ValueColumn.Width = 80;
			// 
			// RegDescriptionColumn
			// 
			this.RegDescriptionColumn.AspectName = "Description";
			this.RegDescriptionColumn.CellPadding = null;
			this.RegDescriptionColumn.Text = "Description";
			this.RegDescriptionColumn.Width = 212;
			// 
			// RegisterBox
			// 
			this.RegisterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RegisterBox.Location = new System.Drawing.Point(67, 304);
			this.RegisterBox.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
			this.RegisterBox.Name = "RegisterBox";
			this.RegisterBox.Size = new System.Drawing.Size(100, 20);
			this.RegisterBox.TabIndex = 25;
			this.RegisterBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// DescriptionTextBox
			// 
			this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.DescriptionTextBox.Location = new System.Drawing.Point(67, 331);
			this.DescriptionTextBox.Name = "DescriptionTextBox";
			this.DescriptionTextBox.Size = new System.Drawing.Size(259, 20);
			this.DescriptionTextBox.TabIndex = 27;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 334);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 28;
			this.label2.Text = "Desc:";
			// 
			// UnitIdBox
			// 
			this.UnitIdBox.Location = new System.Drawing.Point(53, 7);
			this.UnitIdBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.UnitIdBox.Name = "UnitIdBox";
			this.UnitIdBox.Size = new System.Drawing.Size(120, 20);
			this.UnitIdBox.TabIndex = 29;
			this.UnitIdBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// PortBox
			// 
			this.PortBox.Location = new System.Drawing.Point(53, 32);
			this.PortBox.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
			this.PortBox.Name = "PortBox";
			this.PortBox.Size = new System.Drawing.Size(120, 20);
			this.PortBox.TabIndex = 30;
			this.PortBox.Value = new decimal(new int[] {
            502,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 31;
			this.label3.Text = "Unit Id";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 32;
			this.label4.Text = "Port";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(180, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 13);
			this.label5.TabIndex = 33;
			this.label5.Text = "IP to Listen on";
			// 
			// IpAdressBox
			// 
			this.IpAdressBox.FormattingEnabled = true;
			this.IpAdressBox.Location = new System.Drawing.Point(261, 7);
			this.IpAdressBox.Name = "IpAdressBox";
			this.IpAdressBox.Size = new System.Drawing.Size(121, 21);
			this.IpAdressBox.TabIndex = 34;
			// 
			// RefreshButton
			// 
			this.RefreshButton.Location = new System.Drawing.Point(261, 29);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new System.Drawing.Size(121, 23);
			this.RefreshButton.TabIndex = 35;
			this.RefreshButton.Text = "Refresh";
			this.RefreshButton.UseVisualStyleBackColor = true;
			this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 406);
			this.Controls.Add(this.RefreshButton);
			this.Controls.Add(this.IpAdressBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.PortBox);
			this.Controls.Add(this.UnitIdBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DescriptionTextBox);
			this.Controls.Add(this.RegisterBox);
			this.Controls.Add(this.RegisterListView);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.LockButton);
			this.Controls.Add(this.StartButton);
			this.MinimumSize = new System.Drawing.Size(454, 444);
			this.Name = "MainForm";
			this.Text = "Modbus Slave Demonstrator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.RegisterListView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RegisterBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UnitIdBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PortBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.Button LockButton;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button ClearButton;
		private BrightIdeasSoftware.ObjectListView RegisterListView;
		private BrightIdeasSoftware.OLVColumn RegisterColumn;
		private BrightIdeasSoftware.OLVColumn ValueColumn;
		private BrightIdeasSoftware.OLVColumn RegDescriptionColumn;
		private System.Windows.Forms.NumericUpDown RegisterBox;
		private System.Windows.Forms.TextBox DescriptionTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown UnitIdBox;
		private System.Windows.Forms.NumericUpDown PortBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox IpAdressBox;
		private System.Windows.Forms.Button RefreshButton;
	}
}

