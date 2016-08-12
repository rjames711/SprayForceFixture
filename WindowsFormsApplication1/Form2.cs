using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void graph()
        {
            for (int i = -50; i < 100; i++)
            {

                addPoint(i, Math.Pow(i, 3));
            

            }
        }
  public  void addPoint(double x, double y)
        {
            series1.Points.AddXY(x,Math.Pow(y,3));
            Thread.Sleep(30);
        }
    }
    }

