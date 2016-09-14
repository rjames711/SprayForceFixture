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
        Panel mainPanel = new Panel();


        public Form2()
        {
            InitializeComponent();
            testSessionFormPart a = new testSessionFormPart();
            this.Controls.Add(mainPanel);
            mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Controls.Add(a.testDetailsLayoutBox);
            //this.Controls.Add(a.testDetailsLayoutBox);
        }

    }
}
