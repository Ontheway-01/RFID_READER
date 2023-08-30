namespace TagReader
{
    partial class FormTagReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTagReader));
            this.chart_RSSI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_phase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Connect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Clear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_Address = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox_Address = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel_Power = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox_Power = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel_Frequency = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox_Frequency = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Stop = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart_RSSI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_phase)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_RSSI
            // 
            this.chart_RSSI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_RSSI.BackColor = System.Drawing.Color.Transparent;
            this.chart_RSSI.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.AxisY.Maximum = -20D;
            chartArea1.AxisY.Minimum = -70D;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_RSSI.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chart_RSSI.Legends.Add(legend1);
            this.chart_RSSI.Location = new System.Drawing.Point(32, 75);
            this.chart_RSSI.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chart_RSSI.Name = "chart_RSSI";
            this.chart_RSSI.Size = new System.Drawing.Size(708, 531);
            this.chart_RSSI.TabIndex = 13;
            this.chart_RSSI.Text = "chart_RSSI";
            title1.Name = "Title_Rssi";
            title1.Text = "RSSI";
            this.chart_RSSI.Titles.Add(title1);
            // 
            // chart_phase
            // 
            this.chart_phase.BackColor = System.Drawing.Color.Transparent;
            this.chart_phase.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.MajorGrid.LineWidth = 0;
            chartArea2.AxisY.Maximum = 6.3D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart_phase.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend2";
            this.chart_phase.Legends.Add(legend2);
            this.chart_phase.Location = new System.Drawing.Point(764, 94);
            this.chart_phase.Name = "chart_phase";
            this.chart_phase.Size = new System.Drawing.Size(749, 530);
            this.chart_phase.TabIndex = 13;
            this.chart_phase.Text = "chart_phase";
            title2.Name = "Title_Phase";
            title2.Text = "Phase";
            this.chart_phase.Titles.Add(title2);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Save,
            this.toolStripButton_Connect,
            this.toolStripButton_Start,
            this.toolStripButton_Stop,
            this.toolStripButton_Clear,
            this.toolStripButton_Refresh,
            this.toolStripLabel_Address,
            this.toolStripTextBox_Address,
            this.toolStripLabel_Power,
            this.toolStripTextBox_Power,
            this.toolStripLabel_Frequency,
            this.toolStripComboBox_Frequency});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1576, 38);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Save.Image")));
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(78, 29);
            this.toolStripButton_Save.Tag = "";
            this.toolStripButton_Save.Text = "Save";
            // 
            // toolStripButton_Connect
            // 
            this.toolStripButton_Connect.Image = global::TagReader.Properties.Resources.ic_link;
            this.toolStripButton_Connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Connect.Name = "toolStripButton_Connect";
            this.toolStripButton_Connect.Size = new System.Drawing.Size(107, 29);
            this.toolStripButton_Connect.Text = "Connect";
            this.toolStripButton_Connect.Click += new System.EventHandler(this.button_Connect_Click);

            // 
            // toolStripButton_Start
            // 
            this.toolStripButton_Start.Image = global::TagReader.Properties.Resources.play;
            this.toolStripButton_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Start.Name = "toolStripButton_Start";
            this.toolStripButton_Start.Size = new System.Drawing.Size(77, 29);
            this.toolStripButton_Start.Text = "Start";
            this.toolStripButton_Start.Click += new System.EventHandler(this.button_Start_Click);

            // 
            // toolStripButton_Stop
            // 
            this.toolStripButton_Stop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Stop.Image")));
            this.toolStripButton_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Stop.Name = "toolStripButton_Stop";
            this.toolStripButton_Stop.Size = new System.Drawing.Size(78, 29);
            this.toolStripButton_Stop.Text = "Stop";
            this.toolStripButton_Stop.Click += new System.EventHandler(this.button_Stop_Click);

            // 
            // toolStripButton_Clear
            // 
            this.toolStripButton_Clear.Image = global::TagReader.Properties.Resources.delete;
            this.toolStripButton_Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Clear.Name = "toolStripButton_Clear";
            this.toolStripButton_Clear.Size = new System.Drawing.Size(80, 29);
            this.toolStripButton_Clear.Text = "Clear";
            // 
            // toolStripButton_Refresh
            // 
            this.toolStripButton_Refresh.Image = global::TagReader.Properties.Resources.refresh;
            this.toolStripButton_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Refresh.Name = "toolStripButton_Refresh";
            this.toolStripButton_Refresh.Size = new System.Drawing.Size(101, 29);
            this.toolStripButton_Refresh.Text = "Refresh";

            // 
            // toolStripLabel_Address
            // 
            this.toolStripLabel_Address.Name = "toolStripLabel_Address";
            this.toolStripLabel_Address.Size = new System.Drawing.Size(82, 29);
            this.toolStripLabel_Address.Text = "Address:";
            // 
            // toolStripTextBox_Address
            // 
            this.toolStripTextBox_Address.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.toolStripTextBox_Address.Name = "toolStripTextBox_Address";
            this.toolStripTextBox_Address.Size = new System.Drawing.Size(197, 34);
            this.toolStripTextBox_Address.Text = "192.168.1.222";
            // 
            // toolStripLabel_Power
            // 
            this.toolStripLabel_Power.Name = "toolStripLabel_Power";
            this.toolStripLabel_Power.Size = new System.Drawing.Size(66, 29);
            this.toolStripLabel_Power.Text = "Power:";
            // 
            // toolStripTextBox_Power
            // 
            this.toolStripTextBox_Power.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.toolStripTextBox_Power.Name = "toolStripTextBox_Power";
            this.toolStripTextBox_Power.Size = new System.Drawing.Size(81, 34);
            this.toolStripTextBox_Power.Text = "32.5";
            // 
            // toolStripLabel_Frequency
            // 
            this.toolStripLabel_Frequency.Name = "toolStripLabel_Frequency";
            this.toolStripLabel_Frequency.Size = new System.Drawing.Size(100, 29);
            this.toolStripLabel_Frequency.Text = "Frequency:";
            // 
            // toolStripComboBox_Frequency
            // 
            this.toolStripComboBox_Frequency.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.toolStripComboBox_Frequency.Items.AddRange(new object[] {
            "920.625",
            "920.875",
            "921.125",
            "921.375",
            "921.625",
            "921.875",
            "922.125",
            "922.375",
            "922.625",
            "922.875",
            "923.125",
            "923.375",
            "923.625",
            "923.875",
            "924.125",
            "924.375"});
            this.toolStripComboBox_Frequency.Name = "toolStripComboBox_Frequency";
            this.toolStripComboBox_Frequency.Size = new System.Drawing.Size(80, 34);
            this.toolStripComboBox_Frequency.Text = "924.375";
            // 
            // ToolStripMenuItem_Save
            // 
            this.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save";
            this.ToolStripMenuItem_Save.Size = new System.Drawing.Size(32, 19);
            this.ToolStripMenuItem_Save.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // ToolStripMenuItem_Connect
            // 
            this.ToolStripMenuItem_Connect.Name = "ToolStripMenuItem_Connect";
            this.ToolStripMenuItem_Connect.Size = new System.Drawing.Size(32, 19);
            // 
            // ToolStripMenuItem_Start
            // 
            this.ToolStripMenuItem_Start.Name = "ToolStripMenuItem_Start";
            this.ToolStripMenuItem_Start.Size = new System.Drawing.Size(32, 19);
            // 
            // ToolStripMenuItem_Stop
            // 
            this.ToolStripMenuItem_Stop.Name = "ToolStripMenuItem_Stop";
            this.ToolStripMenuItem_Stop.Size = new System.Drawing.Size(32, 19);

            // 
            // FormTagReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 772);
            this.Controls.Add(this.chart_phase);
            this.Controls.Add(this.chart_RSSI);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTagReader";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_RSSI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_phase)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_RSSI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_phase;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Connect;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Start;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Stop;

        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
        private System.Windows.Forms.ToolStripButton toolStripButton_Connect;
        private System.Windows.Forms.ToolStripButton toolStripButton_Start;
        private System.Windows.Forms.ToolStripButton toolStripButton_Stop;
        private System.Windows.Forms.ToolStripButton toolStripButton_Clear;
        private System.Windows.Forms.ToolStripButton toolStripButton_Refresh;

        private System.Windows.Forms.ToolStripLabel toolStripLabel_Address;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Power;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Frequency;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Address;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_Power;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_Frequency;
    }
}