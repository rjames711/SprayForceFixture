using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApplication1
{
    // need to make a switch function to toggle recording and button text whether stopped manually or from time out.
    ///in back class the # of sub data points is hard coded at 1 getforce  every 5 milliseconds. 
    ///these are averaged for the data point that will be seen by user. So at 10 data.dps there will be 20
    ///sub datapoints. At 20 data.dps there will be 10 sub datapoints and so on. 
    public partial class Form1 : Form
    {
        //  double force;
        bool recording = false;
        bool startButton;
        back data;
        double force;
        string UI_Force;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        int precision = 1;
        int testInterval;
        int testNumber;
        int count;
        double graphPoint;
        string averageForce;
        string minForce;
        string maxForce;
        List<TestSession> tests = new List<TestSession>();
        Thread updateChartThread;

        public Form1()
        {

            InitializeComponent();
            this.availablePorts.Items.AddRange(getPorts());
            updateChartThread = new Thread(updateChart);
//           averageForce = averageForceLabel.Text;
//            minForce = MinForceLabel.Text;
//            maxForce = MaxForceLabel.Text;            
        }
    void updateChart()
        {

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

           back datas = new back(e.Argument.ToString());
           backgroundWorker1.ReportProgress(1, datas);
            while (startButton)
            {     
                updateValues();
                
                backgroundWorker1.ReportProgress(1, data);
            }
            Console.WriteLine("exiting thread");
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.data = e.UserState as back;
            updateUI();

            if (recording && count == testInterval * data.dps)
            {
                resetTest();
            }

        }
        void updateValues()
        {
            data.getsmoothedForce();
            force = data.getTaredForce();
            count = data.forceValues.Count();
            UI_Force = formatForDisplay(force);
            if (recording && count > 0 && count <= testInterval * data.dps)
            {
                averageForce = formatForDisplay(data.forceValues.Average());
                maxForce = formatForDisplay(data.forceValues.Max());
                minForce = formatForDisplay(data.forceValues.Min());
                force = data.forceValues.Last<double>();
                graphPoint = (count / data.dps) - (1 / data.dps);  // subtraction here eliminates annoying offset at beginning of graph
                UI_Force = formatForDisplay(force);

              
            }
        }

        void updateUI()
        {
            //None of the following fix unresponsive window issue
            //  this.Invalidate();
            //  this.Refresh();
            //Application.DoEvents();
            ForceReadingLabel.Text = formatForDisplay(force);
            if (recording && count > 0 && count <= testInterval * data.dps)
            {
                listBox1.Items.Add(UI_Force);
                averageForceLabel.Text = averageForce;
                MaxForceLabel.Text = maxForce;
                MinForceLabel.Text = minForce;
                DataPointsLabel.Text = count.ToString();
                ForceGraph.Series[testNumber].Points.SuspendUpdates();
                if (count ==100)
                    ForceGraph.Series[testNumber].Points.ResumeUpdates();
                ForceGraph.Series[testNumber].Points.AddXY(graphPoint, force);
                if (force > ForceGraph.ChartAreas[0].AxisY.Maximum)
                    ForceGraph.ChartAreas[0].AxisY.Maximum = Math.Round(force) + 1;
                if (force < ForceGraph.ChartAreas[0].AxisY.Minimum)
                    ForceGraph.ChartAreas[0].AxisY.Minimum = Math.Round(force) - 1;
                ForceGraph.Series[testNumber].Points.ResumeUpdates();
              
        
                //ForceGraph.Series[testNumber].Points.DataBindXY(data.forceValues);
            }
        }

        void resetTest()
        {
            tests.Add(new TestSession(data.forceValues, TestNameBox.Text, ItemBox.Text, data.unit, "", "", TestTypeBox.Text, TesterBox.Text, TestNotesBox.Text));
            recording = false;
            data.recording = false;
            startTestButton.Text = "Start Test";
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            if (!hasConnection())
                return;

            recording = !recording;
            data.recording = recording;
            testInterval = int.Parse(timeInputControl.Text);
            if (testInterval > 10)
            {
                //if the test interval is larger than the graph size x axis is increased.
                ForceGraph.ChartAreas[0].AxisX.Maximum = testInterval;
            }
            if (recording)
            {
                startTestButton.Text = "Stop Test";
                testNumber++;
                ForceGraph.Series.Add("Test " + testNumber.ToString());
                ForceGraph.Series[testNumber].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }

            else
            {
                startTestButton.Text = "Start Test";
                //not recording means test was stopped early. Adds test to results.
                tests.Add(new TestSession(data.forceValues, TestNameBox.Text, ItemBox.Text, data.unit, "", "", TestTypeBox.Text, TesterBox.Text, TestNotesBox.Text));
            }
            listBox1.Items.Clear();
            data.forceValues.Clear();


        }
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            startButton = !startButton;

            if (startButton)
            {

                try
                {
                    string port = availablePorts.SelectedItem.ToString();
                    backgroundWorker1.RunWorkerAsync(port);
                    ConnectButton.Text = "Disconnect";
                }
                catch
                {
                    MessageBox.Show("Please select a Port", "Connection Error");
                    startButton = !startButton;
                }

            }
            else
            {
                ConnectButton.Text = "Connect";
                data = null;                
            }

        }
        private void TareButton_Click(object sender, EventArgs e)
        {
            if (hasConnection())
                data.tare = data.getCurrentForce();
        }


        void recordSwitch(object sender, EventArgs e)
        {
            recording = !recording;
            averageForceLabel.Text = formatForDisplay(data.forceValues.Average());
            MaxForceLabel.Text = formatForDisplay(data.forceValues.Max());
            MinForceLabel.Text = formatForDisplay(data.forceValues.Min());
        }

        String formatForDisplay(double value)
        {
            return (Math.Round(value, precision)).ToString("N1") + " " + data.unit;
        }

        public string[] getPorts()
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            return ports;

        }

        private void ClearGraphButton_Click(object sender, EventArgs e)
        {

            while (ForceGraph.Series.Count > 1)
            {
                ForceGraph.Series.RemoveAt(ForceGraph.Series.Count - 1);
            }
            testNumber = 0;
        }

        private bool hasConnection()
        {
            if (data == null || !data.hasConnection())
            {
                MessageBox.Show("Not Connected to Serial Port", "No Connection");
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void UpdateDataBase()
        {
            Database1DataSet db = new Database1DataSet();
            DataTable db1 = db.SprayForce;

            db1.Columns.Add("name", typeof(string));
            db1.Columns.Add("address", typeof(string));
            db1.AcceptChanges();

        }

        private void exportData_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TestSession test in tests)
                    test.writeTest();
                tests.Clear();
            }
            catch
            {
                MessageBox.Show("Data Export Unsuccessful. Is file open?");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Refresh();
        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            averageForceLabel.Text = "franks";
        }
    }


}

