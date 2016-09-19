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
  //      Panel mainPanel = new Panel();
        List<TestSession> tests;

        public Form2(List<TestSession> tests)
        {
            InitializeComponent();
            this.tests = tests;
            populate3();

        }

        public Form2()
        {
            InitializeComponent();
            populate2();
            //populate();
        }

        public void populate3()
        {
            this.Controls.Add(mainPanel);
            //mainPanel.Dock = DockStyle.Fill;
            //mainPanel.AutoScroll = true;
            Label top = new Label();
            top.Text = "Test Sessions Ready For export";
            top.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            for (int i = 0; i < tests.Count; i++)
            {
                UserControl1 box2 = new UserControl1(tests[i].d);
                box2.Dock = DockStyle.Top;
                mainPanel.Controls.Add(box2);
                box2.setTitle(i + 1);


            }
            mainPanel.VerticalScroll.Value = 0;
            //this.Controls.Add(a.testDetailsLayoutBox);
            //  mainPanel.Controls[0].Controls[0].Controls[0].Focus();
            Console.WriteLine(mainPanel.AutoScrollPosition);
            //   mainPanel.AutoScrollPosition = new Point(2000, 2000);
            // mainPanel.AutoScrollOffset = new Point(0, 0);
            //  TableLayoutPanel topbox = box.Controls[0] as TableLayoutPanel;
            // top.Select();
            mainPanel.Controls.Add(top);
            top.Dock = DockStyle.Top;
            top.Select();

        }

        public void populate2()
        {
            this.Controls.Add(mainPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.AutoScroll = true;
            Label top = new Label();
            top.Text = "Test Sessions Ready For export";
            top.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            UserControl1 box = new UserControl1();
            box.Dock = DockStyle.Top;
            mainPanel.Controls.Add(box);


            for (int i = 0; i < 20; i++)
            {
                UserControl1 box2 = new UserControl1();
                box2.Dock = DockStyle.Top;
                mainPanel.Controls.Add(box2);
                box2.setTitle(i+1);
                
               
            }
            mainPanel.VerticalScroll.Value = 0;
            //this.Controls.Add(a.testDetailsLayoutBox);
            //  mainPanel.Controls[0].Controls[0].Controls[0].Focus();
            Console.WriteLine(mainPanel.AutoScrollPosition);
            //   mainPanel.AutoScrollPosition = new Point(2000, 2000);
            // mainPanel.AutoScrollOffset = new Point(0, 0);
            //  TableLayoutPanel topbox = box.Controls[0] as TableLayoutPanel;
            // top.Select();
            mainPanel.Controls.Add(top);
            top.Dock = DockStyle.Top;
            top.Select();

        }

        public void populate()
        {
            
            testSessionFormPart a = new testSessionFormPart();
            this.Controls.Add(mainPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.AutoScroll = true;
            Label top = new Label();
            top.Text = "Test Sessions Ready For export";
            top.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

            GroupBox box = new GroupBox();
            box.Dock = DockStyle.Top;
            mainPanel.Controls.Add(box);
            box.Controls.Add(a.testDetailsLayoutBox);
            for (int i = 0; i < 20; i++)
            {
                GroupBox box2 = new GroupBox();
                box2.Dock = DockStyle.Top;
                mainPanel.Controls.Add(box2);
                box2.Controls.Add(new testSessionFormPart().testDetailsLayoutBox);
                box2.Text = "Test Session " + (i + 1);
            }
            mainPanel.VerticalScroll.Value = 0;
            //this.Controls.Add(a.testDetailsLayoutBox);
            //  mainPanel.Controls[0].Controls[0].Controls[0].Focus();
            Console.WriteLine(mainPanel.AutoScrollPosition);
            //   mainPanel.AutoScrollPosition = new Point(2000, 2000);
            // mainPanel.AutoScrollOffset = new Point(0, 0);
            //  TableLayoutPanel topbox = box.Controls[0] as TableLayoutPanel;
            // top.Select();

            //commented because messing with iteration    
            //  mainPanel.Controls.Add(top);
            // top.Dock = DockStyle.Top;
            // top.Select();
            topLabel.Select();
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
            this.Close();
        }
    }
}
