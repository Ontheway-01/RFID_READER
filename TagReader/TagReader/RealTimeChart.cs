using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TagReader.RFIDReader;

namespace TagReader
{
    public partial class FormTagReader : Form
    {
        private static bool _isConnected2Reader;
        private static bool _isStartButtonClicked;
        public static bool IsStopButtonClicked;
        private static bool _isClearButtonClicked;

        private static bool _showQuickAccessToolStrip = true;

        public FormTagReader()
        {
            InitializeComponent();
            ReaderWrapper.MainForm = this;

            ReaderWrapper.Initialize_Configuration();

            toolStripButton_Save.Enabled = false;
            toolStripButton_Connect.Enabled = true;
            toolStripButton_Start.Enabled = false;
            toolStripButton_Stop.Enabled = false;
            toolStripButton_Clear.Enabled = false;
            toolStripButton_Refresh.Enabled = false;

            ToolStripMenuItem_Save.Enabled = false;
            ToolStripMenuItem_Connect.Enabled = true;
            ToolStripMenuItem_Start.Enabled = false;
            ToolStripMenuItem_Stop.Enabled = false;

        }

        #region Update Component
        private ulong _startTime;
        private DateTime _startTimeDateTime;
        private int ConvertTime(ulong time)
        {
            var ts = time - _startTime;
            return (int)(ts / 1000000);
        }


        private static Dictionary<TagInfos.Key, int> _map = new Dictionary<TagInfos.Key, int>();
        public void UpdateChart(ref TagStatus tagStatus)
        {
            var epc = tagStatus.Epc;
            var antenna = tagStatus.Antenna;
            var channel = tagStatus.ChannelIndex;
            var key = new TagInfos.Key(epc, antenna, channel);
            var time = tagStatus.TimeStamp;

            if (!_map.ContainsKey(key))
            {
                _isClearButtonClicked = false;
                if (_startTime == 0)
                {
                    _startTime = time;
                    var dt = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                    _startTimeDateTime = dt.AddSeconds(Convert.ToDouble(_startTime / 1000000)).ToLocalTime();
                }

                var s = new Series
                {
                    ChartType = SeriesChartType.FastLine,
                    Name = epc + "_" + antenna
                };
                chart_RSSI.Series.Add(s);

                var s1 = new Series
                {
                    ChartType = SeriesChartType.FastLine,
                    Name = epc + "_" + antenna
                };
                chart_phase.Series.Add(s1);


                _map.Add(key, _map.Count); // save index
            }
            var seriesId = _map[key];

            chart_RSSI.Series[seriesId].Points.AddXY(ConvertTime(time), tagStatus.Rssi);
            chart_RSSI.Series[seriesId].LegendText = epc.Substring(epc.Length - 4, 4) + "_" + antenna;

            chart_phase.Series[seriesId].Points.AddXY(ConvertTime(time), tagStatus.PhaseRadian);
            chart_phase.Series[seriesId].LegendText = epc.Substring(epc.Length - 4, 4) + "_" + antenna;

            /*
            if (SettingsWindow.IsTimerModeActied)
            {
                int t = ConvertTime(time);
                Invoke(new Action(() =>
                {
                    UpdateStatusBar_ProgressBar(ref t);
                }));

                if (t >= ReaderWrapper.ReaderParameters.Duration)
                {
                    StopReceive();

                    if (SettingsWindow.IsAutoSaveChecked)
                    {
                        var fpath = @"C:\Users\Marin\Desktop\";
                        if (!Directory.Exists(fpath))
                            Directory.CreateDirectory(fpath);

                        var dt = DateTime.Now;
                        var strCurrentTime = dt.ToString("yyyyMMdd_HHmmss");
                        var fname = strCurrentTime + ".csv";
                        var csvWriter = new CsvStreamWriter(fpath + fname);
                        ReaderWrapper.SaveData(csvWriter);
                    }
                }
            }*/
        }

        #endregion

        #region Button Clicked Event

        private void button_Connect_Click(object sender, EventArgs e)
        {
            var ipAddress = toolStripTextBox_Address.Text;
            var txPower = Convert.ToDouble(toolStripTextBox_Power.Text);
            var frequency = toolStripComboBox_Frequency.SelectedItem.ToString();

            if (ipAddress == string.Empty)
            {
                MessageBox.Show("IP Address Cannot be Empty");
            }
            if (txPower < 10 || txPower > 32.5)
            {
                MessageBox.Show("Invalid Power!");
            }

            ReaderWrapper.ReaderParameters.Ip = ipAddress;
            ReaderWrapper.ReaderParameters.TransmitPower = txPower;
            ReaderWrapper.ReaderParameters.ChannelIndex =
                Convert.ToUInt16((Convert.ToDouble(frequency) - 920.625) / 0.25);

            _isConnected2Reader = ReaderWrapper.ConnectToReader();

            //MessageBox.Show(_isConnected2Reader ? "Successfully Connected!" : "Connect Failed!");

            if (_isConnected2Reader)
            {

                toolStripButton_Connect.Enabled = false;
                ToolStripMenuItem_Connect.Enabled = false;

                toolStripButton_Start.Enabled = true;
                ToolStripMenuItem_Start.Enabled = true;
            }
        }

        private void StartReceive()
        {
            ReaderWrapper.Start();

            _startTime = 0;
            _isStartButtonClicked = true;
            IsStopButtonClicked = false;

            toolStripButton_Start.Enabled = false;
            ToolStripMenuItem_Start.Enabled = false;

            toolStripButton_Stop.Enabled = true;
            ToolStripMenuItem_Stop.Enabled = true;

            //toolStripButton_Clear.Enabled = true;

        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (_isConnected2Reader)
            {
                StartReceive();

            }
        }

        private void StopReceive()
        {
            IsStopButtonClicked = true;
            _isClearButtonClicked = false;

            ReaderWrapper.Stop();

            chart_RSSI.EndInit();
            chart_phase.EndInit();

            toolStripButton_Stop.Enabled = false;
            ToolStripMenuItem_Stop.Enabled = false;

            // 
            //toolStripButton_Start.Enabled = true;
            //ToolStripMenuItem_Start.Enabled = true;

            toolStripButton_Save.Enabled = true;
            ToolStripMenuItem_Save.Enabled = true;

            toolStripButton_Clear.Enabled = true;
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            if (_isConnected2Reader && _isStartButtonClicked)
            {
                StopReceive();
            }
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "csv file|*.csv",
                FilterIndex = 1,
                RestoreDirectory = true,
                DefaultExt = ".csv"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var fpath = sfd.FileName;
                CsvStreamWriter csvWriter = new CsvStreamWriter(fpath);
                ReaderWrapper.SaveData(csvWriter);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            if (IsStopButtonClicked)
            {
                // clean up the Reader
                chart_RSSI.Dispose();
                chart_phase.Dispose();

                _isClearButtonClicked = true;
            }
        }

        #endregion

    }
}