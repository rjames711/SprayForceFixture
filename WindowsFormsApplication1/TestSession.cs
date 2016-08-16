using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
namespace WindowsFormsApplication1
{
    class TestSession
    {
        List<double> values;
        public string item;
        public string flowRate;
        public string measuredFlow;
        public string testNotes;
        public string tester;
        public string testName;
        double averageForce;
        double maxForce;
        double minForce;
        int dataPoints;
        string timeStamp;

        public TestSession(List<double> values,string testName, string item, string flowRate, string measuredFlow, string tester, string testNotes )
        {
            this.values = new List<double>(values);// need to clone list so it doesn't maintain object reference.
            this.item = item;
            this.flowRate = flowRate;
            this.measuredFlow = measuredFlow;
            this.testNotes = testNotes;
            this.tester = tester;
            this.testName = testName;
            this.averageForce = values.Average();
            this.maxForce = values.Max();
            this.minForce = values.Min();
            this.dataPoints = values.Count;
            DateTime time = DateTime.Now;
            timeStamp = time.ToString();


        }

        public void writeTest()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\rames\Documents\"+testName+".csv", true))
            {
                file.Write(testName+",");
                file.Write(item+",");
                file.Write(testNotes+",");
                file.Write(timeStamp);
                file.WriteLine();
                file.WriteLine("DataPoint,Values");
                int i = 0;
                foreach (double value in values)
                {
                    file.Write(++i +",");
                    file.WriteLine(value);
                }
                //for(int i =0; i<dataPoints;i++)
                //{
                //    file.Write((i+1) + ",");
                //    file.WriteLine(values[i]);
                //}
            }
        }


    }
}
