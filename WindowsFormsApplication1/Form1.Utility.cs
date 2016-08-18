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
                    Console.WriteLine("resetting Test");
                    resetTest();
                    Console.WriteLine("resetting Test");
                }
            }
            Console.WriteLine("exiting thread");
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.data = e.UserState as back;
            updateUI();

            if(e.ProgressPercentage==2)
                startTestButton.Text = "Start Test";
        }
        void updateValues()
        {
            data.getsmoothedForce();
            force = data.getTaredForce();
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

        void updateUI()
        {
            ForceReadingLabel.Text = formatForDisplay(force);
            if (recording && count > 0 && count <= testInterval * data.dps)
            {
                listBox1.Items.Add(UI_Force);
                averageForceLabel.Text = averageForce;
                MaxForceLabel.Text = maxForce;
                MinForceLabel.Text = minForce;
                DataPointsLabel.Text = count.ToString();
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
            ForceGraph.Series[testNumber].Points.ResumeUpdates();

        }

        void resetTest()
        {
            tests.Add(new TestSession(data.forceValues, TestNameBox.Text, ItemBox.Text, data.unit, "", "", TestTypeBox.Text, TesterBox.Text, TestNotesBox.Text));
            recording = false;
            data.recording = false;
            graphPoint = 0;           
        }
    }
}
