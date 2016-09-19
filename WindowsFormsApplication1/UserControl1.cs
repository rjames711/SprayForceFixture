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

        public TestData d;

        public UserControl1(TestData d)
        {
            InitializeComponent();
            this.d = d;
            setUserInput();
        }

        public UserControl1()
        {
            InitializeComponent();
            getValues();
        }
        public void setTitle(int testNumber)
        {
            groupBox1.Text += ": Test" + testNumber;
            groupBox2.Text += ": Test" + testNumber;
        }

        /// <summary>
        /// Gets user input by iterating over table controls,
        /// and adding control text to list if its a textbox or
        /// a combobox
        /// </summary>
        /// <returns>A list of strings with inputted values </returns>
        public List<string> getValues()
        {
            List<string> alist = new List<string>();
            foreach (Control input in tableLayoutPanel1.Controls)
            {
                if (input is TextBox || input is ComboBox)
                    alist.Add(String.Copy((input.Text)));
                //Console.Write(input.Text);
            }
            return alist;
        }

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

        String formatForDisplay(double value)
        {
            return (Math.Round(value, 2)).ToString("N1") + " " + d.Units;
        }
    }


}
