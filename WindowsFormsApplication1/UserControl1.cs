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
        public string testName { get; set; }
        public string item { get; set; }
        public string flow { get; set; }
        public string pressure { get; set; }
        public string temperature { get; set; }
        public string tester { get; set; }
        public string testNotes { get; set; }


        public UserControl1()
        {
            InitializeComponent();
            getValues();
        }
        public void setTitle(int testNumber)
        {
            groupBox1.Text += ": Test"+testNumber;
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
                    alist.Add(input.Text);
                    //Console.Write(input.Text);
            }
            return alist;
    }

        public void getUserInput()
        {
         testName=testNameComboBox.Text;
         item=ItemBox.Text;
         flow=MeasureFlowBox.Text;
         pressure=MeasuredPressureBox.Text;
         temperature=temperatureBox.Text;
         tester=TesterBox.Text;
         testNotes=TestNotesBox.Text;
    }

    }


}
