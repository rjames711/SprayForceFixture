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
    

    public partial class Form1 : Form
    {
        
        bool recording=false;
        bool startButton;
        back data;
        public double tare = 0;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        int precision = 1;
        back dataSource; //should remove, redundant. only used in dowork then pass by ref to data
        int testInterval;
        int testNumber=0;

        public Form1()
        {
          
            InitializeComponent();
            this.availablePorts.Items.AddRange(getPorts());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            dataSource = new back(e.Argument.ToString());
            
            while (startButton)
            {
                double force = dataSource.getsmoothedForce();
                backgroundWorker1.ReportProgress(1, dataSource);
            }
            Console.WriteLine("exiting thread");                 
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            data = (back)(e.UserState);
            double force = data.getCurrentForce();
            ForceReadingLabel.Text = formatForDisplay(force);
            int count = data.forceValues.Count();


            if (recording && count>0 && count<=testInterval*20 )
            {
                listBox1.Items.Add(formatForDisplay(data.forceValues.Last<double>()));
                DataPointsLabel.Text = count.ToString();
                double graphPoint = count / 20.0;
                ForceGraph.Series[testNumber].Points.AddXY(graphPoint, force-tare);
                updateTestResults();
            }
            else
            {
                recording = false;
            }
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            if (!hasConnection())
                return;
           
            recording = !recording;
            data.recording = recording;
            testInterval = int.Parse(timeInputControl.Text);
           
            listBox1.Items.Clear();
            data.forceValues.Clear();
            if (recording)
            {
                testNumber++;
                ForceGraph.Series.Add("Test " + testNumber.ToString());
                ForceGraph.Series[testNumber].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }

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
                dataSource = null;
            }
            
        }
        private void TareButton_Click(object sender, EventArgs e)
        {
            if(hasConnection())
                tare = data.getCurrentForce();
        }

        void setForce(string newForce)
        {
            ForceReadingLabel.Text = newForce + " " + data.unit;
            if (recording)
                listBox1.Items.Add(newForce);
        }

        void updateTestResults()
        {
            averageForceLabel.Text = formatForDisplay(data.forceValues.Average());
            MaxForceLabel.Text = formatForDisplay(data.forceValues.Max());
            MinForceLabel.Text = formatForDisplay(data.forceValues.Min());
            
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
            return (Math.Round(value - tare, precision)).ToString("N1")+" "+data.unit;
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

            while(ForceGraph.Series.Count>1)
            {
                ForceGraph.Series.RemoveAt(ForceGraph.Series.Count - 1);
            }
            testNumber = 0;

        }

        private bool hasConnection()
        {
            if(data == null||!data.hasConnection())
            {
                MessageBox.Show("Not Connected to Serial Port","No Connection");
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }


}

