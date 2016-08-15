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
        double taredForce = 0;
        int delay = 600;  //delay for dumb for loop to fun and space out reading properly because all of microsoft solutions are terrible for millisecond level timing
        int dataSmoothing = 40; //number of datapoint to collect and average before reporting back force.
        //Hi I'm newly cleaned code!

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


            double sum = 0;
            for (int i = 0; i < dataSmoothing; i++)
            {
                sum += getForce();
            }
            double force = (sum / dataSmoothing) * 1;
            if (recording)
            {

                forceValues.Add(force);
            }
            currentForce = force;
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

        public double getForce()
        {
            string rawRead = "0";
            while (rawRead == "0")
                rawRead = getReading();

            string[] reading = rawRead.Split(' ');
            unit = reading[1];
            return double.Parse(reading[0]) * -1; //returns the double representation of the reading(inverting negative reading from gauge))
        }


        string getReading()
        {
            try
            {
                mySerialPort.Write("?");
                String reading = null;
                while (String.IsNullOrEmpty(reading)) //should update this to more conventional serial method validation
                {
                    reading = mySerialPort.ReadExisting();

                }
                dumbDelay(delay);
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

        public bool hasConnection()
        {
            return mySerialPort.IsOpen;
 
        }


    }
        
   }
