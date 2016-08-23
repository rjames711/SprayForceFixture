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


///in back class the # of sub data points is hard coded at 1 getforce  every 5 milliseconds. 
///these are averaged for the data point that will be seen by user. So at 10 data.dps there will be 20
///sub datapoints. At 20 data.dps there will be 10 sub datapoints and so on. 

namespace WindowsFormsApplication1
{    
    /// <summary>
    /// Main Form, Class for project. Form1.cs includes mostlty methods for form event handling. Form1.Utilitly.cs contains all other 
    /// customs methods 
    /// </summary>
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
        string exportPath;
        List<TestSession> tests = new List<TestSession>();
        //  System.Windows.Forms.Timer refreshTimer; 

        public Form1()
        {
            InitializeComponent();
            this.availablePorts.Items.AddRange(getPorts());
            //creates a default location for spray force results 
            //if it doesn't  exist in user documents library.
            string defaultPath =
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString()
                + "\\Spray Force Data").FullName;
            exportLocationBox.Text = defaultPath;            
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            if (!hasConnection())
                return;
            timer1.Interval = Convert.ToInt32(1000 / data.dps);
            testInterval = int.Parse(timeInputControl.Text);
            if (testInterval > 10)
            {
                //if the test interval is larger than the graph size x axis is increased.
                ForceGraph.ChartAreas[0].AxisX.Maximum = testInterval;
            }
            if (recording)
            {
                resetTest();
                startTestButton.Text = "Start Test";
                timer1.Stop();                
            }
            else
            {
                DialogResult result= MessageBox.Show(
                   "Is Test information Correct?\r\nYes to continue.\r\nNo to stop and edit.", "Check Test Info", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
                startNewTest();
            }
            listBox1.Items.Clear();
            data.forceValues.Clear();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            startButton = !startButton;

            if (startButton)
            {
                Connect();
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
            ForceGraph.ChartAreas[0].AxisX.Maximum = 10;
            ForceGraph.ChartAreas[0].AxisY.Maximum = 10;
            ForceGraph.ChartAreas[0].AxisY.Minimum=0;
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
            string root = getExportDataLocation();
            Console.WriteLine(root);
            try
            {
                foreach (TestSession test in tests)
                {
                    
                    test.writeTest(root);
                    test.writeLongTest(root);
                }
                tests.Clear();
            }
            catch
            {
                MessageBox.Show("Data Export Unsuccessful. Is file open?");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            this.Invalidate();
            this.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (recording)
                updateGraph();
     //       Console.WriteLine(DateTime.Now.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog cf = new FolderBrowserDialog();
            cf.ShowDialog();
            exportLocationBox.Text = cf.SelectedPath;
        }
    }


}

