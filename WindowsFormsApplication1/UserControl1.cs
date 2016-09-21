using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UserControl1 : UserControl
    {

        public TestData d=new TestData();

        public UserControl1(TestData d)
        {
            InitializeComponent();
            this.d = d;
            setUserInput();
        }

        public UserControl1()
        {
            InitializeComponent();
            d = new TestData();         
        }

        /// <summary>
        ///Retrieves user editable information in the form control and 
        ///updates the associated data objects
        /// </summary>
        public void getUserInput()
        {
            d.TestName = testNameComboBox.Text;
            d.Item = ItemBox.Text;
            d.MeasuredFlow = MeasureFlowBox.Text;
            d.MeasuredPressure = MeasuredPressureBox.Text;
            d.Temperature = temperatureBox.Text;
            d.Tester = TesterBox.Text;
            d.TestNotes = TestNotesBox.Text;
            d.Export=ExportRadioButton.Checked;
            d.Delete = deleteRadioButton.Checked;
        }

        /// <summary>
        /// Sets the text information in the form control based on the info in the 
        /// enclosed data object
        /// </summary>
        public void setUserInput()
        {
            testNameComboBox.Text = d.TestName;
            ItemBox.Text = d.Item;
            MeasureFlowBox.Text = d.MeasuredFlow;
            MeasuredPressureBox.Text = d.MeasuredPressure;
            temperatureBox.Text = d.Temperature;
            TesterBox.Text = d.Tester;
            TestNotesBox.Text = d.TestNotes;
            MaxForceLabel.Text = formatForDisplay(d.MaxForce);
            MinForceLabel.Text = formatForDisplay(d.MinForce);
            averageForceLabel.Text = formatForDisplay(d.AverageForce);
            DataPointsLabel.Text = d.DataPoints.ToString();

        }

        public void setTitle(int testNumber)
        {
            groupBox1.Text += ": Test" + testNumber;
            groupBox2.Text += ": Test" + testNumber;
        }

        String formatForDisplay(double value)
        {
            return (Math.Round(value, 2)).ToString("N1") + " " + d.Units;
        }
    }


}
