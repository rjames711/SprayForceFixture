using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Modal Form which displays all the tests sessions stored in memory (passed into constructor) and allows
    /// for editing of test info, deletion, export etc.
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// determines whether to execute export operation (for whole form)  
        /// </summary>
        public bool exportData { get; set; } = false;
       
        /// <summary>
        /// List of test sessions stored in memory passed in to the form constructor
        /// </summary>                        
        List<TestSession> tests;

        /// <summary>
        /// Constructor creates form based on the list of tests passed in as parameter.
        /// </summary>
        /// <param name="tests"></param>
        public Form2(List<TestSession> tests)
        {
            InitializeComponent();
            this.tests = tests;
            populate();
        }
        /// <summary>
        /// Adds all the test sessions stored in memory to the form 
        /// (as usercontrols)
        /// </summary>
        public void populate()
        {
            for (int i = 0; i < tests.Count; i++)
            {
                UserControl1 box2 = new UserControl1(tests[i].d);
                box2.Dock = DockStyle.Top;
                mainPanel.Controls.Add(box2);
                box2.setTitle(i + 1);
            }
            mainPanel.VerticalScroll.Value = 0;
            Console.WriteLine(mainPanel.AutoScrollPosition);
            topLabel.Select(); // Bring auto scroll back up to top.
        }
        /// <summary>
        /// Iterates over the test session user controls in form to update 
        /// all the user data to the dataobject shared with the tests in memory.
        /// Then iterates over list of tests and updates the test info based on the data object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishExportButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mainPanel.Controls.Count; i++)
            {
                if (mainPanel.Controls[i] is UserControl1)
                {
                    UserControl1 input = mainPanel.Controls[i] as UserControl1;
                    input.getUserInput();
                }
            }
            foreach (TestSession test in tests)
                test.copyData();

            exportData = true;
            this.Close();
        }

        /// <summary>
        ///Cancels the export operation and closes the form to go back to the main form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelExportButton_Click(object sender, EventArgs e)
        {
            exportData = false;
            this.Close();
        }
    }
}
