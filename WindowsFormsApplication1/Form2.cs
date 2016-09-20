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
    public partial class Form2 : Form
    {
        public  bool exportData { get; set; } = false;         
        List<TestSession> tests;

        public Form2(List<TestSession> tests)
        {
            InitializeComponent();
            this.tests = tests;
            populate();
        }

        public Form2()
        {
            InitializeComponent();
        }

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

        private void FinishExportButton_Click(object sender, EventArgs e)
        {
            for(int i =0;i<mainPanel.Controls.Count;i++)
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

        private void CancelExportButton_Click(object sender, EventArgs e)
        {
            exportData = false;
            this.Close();
        }
    }
}
