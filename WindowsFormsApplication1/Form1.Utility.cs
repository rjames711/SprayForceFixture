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
    partial class Form1
    {
        /// <summary>
        /// Main Background thread used to pull data and perform any calculations needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            back datas = new back(e.Argument.ToString());
            backgroundWorker1.ReportProgress(1, datas);
            while (startButton)
            {
                updateValues();
                backgroundWorker1.ReportProgress(1, data);

                if (recording && count == testInterval * data.dps)
                {
                   backgroundWorker1.ReportProgress(2, data);
//                    Console.WriteLine("resetting Test");
//                    resetTest();
//                    Console.WriteLine("resetting Test");
//                    backgroundWorker1.ReportProgress(2, data);
                }
            }
            Console.WriteLine("exiting thread");
        }

        /// <summary>
        /// Recieves updates from background thread and updates UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.data = e.UserState as back;
            updateUI();

            if (e.ProgressPercentage == 2)
                resetTest();
        }
        /// <summary>
        /// Prepares values needed to update the UI. Should be performed in backround thread. 
        /// </summary>
        void updateValues()
        {
            data.getDataPoint();
            force = data.calibratedForce;
            count = data.forceValues.Count();
            UI_Force = formatForDisplay(force);
            graphPoint = (count / data.dps) - (1 / data.dps);  // subtraction here eliminates annoying offset at beginning of graph
            if (recording && count > 0 && count <= testInterval * data.dps)
            {
                averageForce = formatForDisplay(data.forceValues.Average());
                maxForce = formatForDisplay(data.forceValues.Max());
                minForce = formatForDisplay(data.forceValues.Min());
                force = data.forceValues.Last<double>();                
                UI_Force = formatForDisplay(force);
            }
        }
        /// <summary>
        /// Updates the UI with values provided by the updateValues method. Needs to be performed 
        /// by main UI thread.
        /// </summary>
        void updateUI()
        {
            ForceReadingLabel.Text = formatForDisplay(force);
            if (recording && count > 0 && count <= testInterval * data.dps)
            {
                d.listBox1.Items.Add(UI_Force);
                d.averageForceLabel.Text = averageForce;
                d.MaxForceLabel.Text = maxForce;
                d.MinForceLabel.Text = minForce;
                d.DataPointsLabel.Text = count.ToString();
            }

            else
            {
                timer1.Stop();
                if (startTestButton.Text == "Stop Test")
                    startTestButton.Text = "Start Test";
            }
          }
        ///because of annoying UI hangups caused by updating graph
        ///this logic was moved to its own function and only called by a 
        ///windows form timer. Otherwise after a 1000 datapoints or so the
        ///UI becomes unresponsive.
        void updateGraph()
        {
            ForceGraph.Series[testNumber].Points.AddXY(graphPoint, force);
            if (force > ForceGraph.ChartAreas[0].AxisY.Maximum)
                ForceGraph.ChartAreas[0].AxisY.Maximum = Math.Round(force) + 1;
            if (force < ForceGraph.ChartAreas[0].AxisY.Minimum)
                ForceGraph.ChartAreas[0].AxisY.Minimum = Math.Round(force) - 1;
            if (graphPoint >= ForceGraph.ChartAreas[0].AxisX.Maximum)
                ForceGraph.ChartAreas[0].AxisX.Maximum = graphPoint + 10;
            ForceGraph.Series[testNumber].Points.ResumeUpdates();

        }

        /// <summary>
        /// Stops recording of a test and enters a new testsession entry with the results.
        /// Should occur from test time ending or user pressing stop button.
        /// </summary>
        void resetTest()
        {
            //tests.Add(new TestSession(new TestData(data.forceValues, d.testNameComboBox.Text, d.ItemBox.Text, data.unit, "",
            //d.MeasureFlowBox.Text, d.MeasuredPressureBox.Text, d.TesterBox.Text, d.TestNotesBox.Text)));
            this.d.getUserInput();
            tests.Add(new TestSession(new TestData(d.d,data.forceValues))); //I know, confusing and lazy will change later.
            recording = false;
            data.recording = false;
            graphPoint = 0;           
        }
        /// <summary>
        /// Connects to selected serial port and begins background thread 
        /// collecting data from selected port.
        /// </summary>
        void Connect()
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
        /// <summary>
        /// Begins new test session.
        /// </summary>
        void startNewTest()
        {
            //  ForceGraph.Series[testNumber].Points.ToList().ForEach(i => Console.WriteLine(i.ToString())); 
            testNumber++;
            ForceGraph.Series.Add("Test " + testNumber.ToString());
            ForceGraph.Series[testNumber].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            recording = true;
            data.recording = true;
            startTestButton.Text = "Stop Test";
            timer1.Start();
            // recording means test was stopped early. Adds test to results.
            //tests.Add(new TestSession(data.forceValues, TestNameBox.Text, ItemBox.Text, data.unit, "", "", TestTypeBox.Text, TesterBox.Text, TestNotesBox.Text));
        }
        string getExportDataLocation()
        {
            return exportLocationBox.Text.ToString();
        }
    }
}
