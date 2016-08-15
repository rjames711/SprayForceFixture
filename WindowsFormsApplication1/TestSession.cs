using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TestSession
    {
        List<double> values;
        public string item;
        public string flowRate;
        public string measuredFlow;
        public string testSession;
        public string tester;
        double averageForce;
        double maxForce;
        double minForce;
        int dataPoints;

        public TestSession(List<double> values, string item, string flowRate, string measuredFlow, string testSession, string tester)
        {
            this.values = values;
            this.item = item;
            this.flowRate = flowRate;
            this.measuredFlow = measuredFlow;
            this.testSession = testSession;
            this.tester = tester;

            this.averageForce = values.Average();
            this.maxForce = values.Max();
            this.minForce = values.Min();
            this.dataPoints = values.Count;


        }

        public void writeTest()
        {

        }


    }
}
