using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
namespace WindowsFormsApplication1
{
    class back
    {
        SerialPort mySerialPort;
        public string unit;
        bool startButton = true;
        public bool recording = false;
        double currentForce;
        public List<double> forceValues = new List<double>();
       
        public double tare = 0;
        string comPort;
        double taredForce=0;
        int delay = 600;  //delay for dumb for loop to fun and space out reading properly because all of microsoft solution are terrible for millisecond level delays
        int count = 0;
        int dataSmoothing=20;
        double forceSum=0;
        System.Timers.Timer dataRatetimer= new System.Timers.Timer(2); //new timing mechanism

        bool timerStop = true;

        public void unPause(Object source, ElapsedEventArgs e)
        {
           // Console.WriteLine();
            timerStop = false;
        }

        public void start()
        {
            dataRatetimer.Elapsed += unPause;
            dataRatetimer.Enabled=true;
        }
        public double getCurrentForce()
        {
            return currentForce;
        }
        public double getTaredForce()
        {
            return taredForce;
        }

        public void setStart(bool s)
        {
            this.startButton = s;
        }

        public back()
        {

        }
        public back(string comPort)
        {
            Console.WriteLine(comPort);
            this.comPort = comPort;
            connectPort(comPort);
            
        }

  
      public double getsmoothedForce()
        {

            // double force = smoothedForce(dataSmoothing);
            double sum = 0;
            for (int i = 0; i < dataSmoothing; i++)
            {
                sum += getForce();
            }
            double force = (sum / dataSmoothing) * 1;
            //force = Math.Round(force, 2);

            if (recording)
                {

                    forceValues.Add(force);
                }
         //       Console.WriteLine(force);
            currentForce = force;
           // taredForce = force - tare;
            return force;
               
            
        }



        void connectPort(string port)
        {
            Console.WriteLine("Connecting to device");
            mySerialPort = new SerialPort(port, 9600);
            try
            {
                Console.WriteLine(mySerialPort.IsOpen);
                mySerialPort.Open();
                mySerialPort.DiscardInBuffer();
                mySerialPort.DiscardOutBuffer();
                mySerialPort.DiscardNull = true;
                Console.WriteLine(mySerialPort.IsOpen);
         



            }
            catch
            {
                Console.WriteLine("error opening serial port.");

            }

        }


        double smoothedForce(int smooth)
        {
            double sum = 0;
            for (int i = 0; i < smooth; i++)
            {
                sum += getForce();
            }
            return (sum / smooth)*1;
        }

         public double getForce()
        {
            string rawRead = "0";
            while(rawRead=="0")
                rawRead = getReading();

            string[] reading = rawRead.Split(' ');
            unit = reading[1];           
            return double.Parse(reading[0])*-1; //returns the double representation of the reading(inverting negative and subtracting any tare)
        }


        string getReading()
        {
            
            if (timerStop)
                return "0";
//            else
//                timerStop = true;

            try
            {
                mySerialPort.Write("?");
            //    Console.WriteLine("sent");
                //Thread.Sleep(delay);
                String reading = null;
                while (String.IsNullOrEmpty(reading))
                {
                    reading = mySerialPort.ReadExisting();
                                  
                }
                dumbDelay(delay);
                //Console.WriteLine(String.IsNullOrEmpty(reading));
                //Thread.Sleep(1);
                return reading;
            }
            catch
            {
                Console.WriteLine("error");
                return "error";
            }
            
        }
        double getForceAverage()
        {
            double sum = 0;
            foreach (double force in forceValues)
            {
                sum += force;
            }
            return sum;
        }

    public void dumbDelay(int delay)
        {
            delay *= 1000;
            for (; delay > 0; delay--) ;
        }

        private void button1_Click(int timeInterval)
        {


        }
    }
}
