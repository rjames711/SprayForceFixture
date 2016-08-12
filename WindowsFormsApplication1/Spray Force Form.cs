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
        Form2 graph = new Form2();
        bool recording=false;
        string unit;
        bool startButton;
        back data;
        public double tare = 0;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        int precision = 1;
        back dataSource;
        int testInterval;
        int testNumber=0;

        public Form1()
        {
          
            InitializeComponent();
            this.availablePorts.Items.AddRange(getPorts());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            

            //while (recording)
            //{
            //    Console.WriteLine(e.Argument);
            //    Thread.Sleep(1000);
            //}
            //back threadArgument = e.Argument as back;

            dataSource = new back(e.Argument.ToString());

            dataSource.start();

            while (startButton)
            {

                double force = dataSource.getsmoothedForce();
                backgroundWorker1.ReportProgress(1, dataSource);
            }

     

            Console.WriteLine("exiting thread");

                 
        }

        void update(Object source, ElapsedEventArgs e)
        {
           
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
          //  Console.WriteLine("update");
          //  Console.WriteLine(e.UserState.ToString());
            data = (back)(e.UserState);
            //   string reading = Convert.ToString(Math.Round(data.getCurrentForce() - tare, precision)) +" "+ data.unit;
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
            testNumber++;
            recording = !recording;
            data.recording = recording;
            testInterval = int.Parse(timeInputControl.Text);
           
            listBox1.Items.Clear();
            data.forceValues.Clear();
            if (recording)
            {
                ForceGraph.Series.Add("Test " + testNumber.ToString());
                ForceGraph.Series[testNumber].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline; ;
            }
            //t.Interval = testInterval * 1000; // specify interval time as you want
            //t.Tick += new EventHandler(recordSwitch);
            //t.Start();

        }
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            startButton = !startButton;

            if (startButton)
            {
                
                //String port = textBox1.Text;                
                // backgroundWorker1.RunWorkerAsync(new back(port));
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
            }
            
        }
        private void TareButton_Click(object sender, EventArgs e)
        {
            tare = data.getCurrentForce();
        }

        void setForce(string newForce)
        {
            ForceReadingLabel.Text = newForce + " " + unit;
            if (recording)
                listBox1.Items.Add(newForce);
        }

        void updateTestResults()
        {
            //recording = !recording;
            //t.Stop();
            //t.Tick -= new EventHandler(recordSwitch);
            averageForceLabel.Text = formatForDisplay(data.forceValues.Average());
            MaxForceLabel.Text = formatForDisplay(data.forceValues.Max());
            MinForceLabel.Text = formatForDisplay(data.forceValues.Min());
            
        }

        void recordSwitch(object sender, EventArgs e)
        {
            recording = !recording;
            //t.Stop();
            //t.Tick -= new EventHandler(recordSwitch);
            averageForceLabel.Text = formatForDisplay(data.forceValues.Average());
            MaxForceLabel.Text = formatForDisplay(data.forceValues.Max());
            MinForceLabel.Text = formatForDisplay(data.forceValues.Min());
        }

        String formatForDisplay(double value)
        {
            //return Convert.ToString(Math.Round(value - tare, precision))+" "+data.unit;
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
         

        private void graphCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (graphCheckBox.Checked)
            {

                graph.Show();
                graph.Enabled = true;
                for (int i = -50; i < 100; i++)
                    graph.addPoint(i,i);

            }
            else
            {
                graph.Hide();
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void ForceGraph_Click(object sender, EventArgs e)
        {

        }

        private void ClearGraphButton_Click(object sender, EventArgs e)
        {

            while(ForceGraph.Series.Count>1)
            {
                ForceGraph.Series.RemoveAt(ForceGraph.Series.Count - 1);
            }
            testNumber = 0;

          //for(int i=testNumber;i<0;i--)
          //  {
          //      ForceGraph.Series.RemoveAt(i);
          //     // ForceGraph.Series.
          //  }

          //foreach(System.Windows.Forms.DataVisualization.Charting.Series aSeries in ForceGraph.Series)
          //  {
          //      if(aSeries.Name != "Test Runs")
          //      {

          //      }

          //  }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Update();
        }
        private void checkConnection()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }


}

