using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
namespace WindowsFormsApplication1
{
  partial  class back
    {
       
        SerialPort mySerialPort;
        public string unit;
        bool startButton = true;
        public bool recording = false;        
        string comPort;      
        double dataTiming = 5; //milliseconds between datasamplings
        Stopwatch timer = new Stopwatch();      
        public List<double> readings = new List<double>();
        public List<double> currentReadings = new List<double>();



        public void setStart(bool s)
        {
            this.startButton = s;
        }

 
        public back(string comPort)
        {
            Console.WriteLine(comPort);
            this.comPort = comPort;
            connectPort(comPort);
            dataSmoothing = 1000 / (dps * dataTiming);
            tare = Properties.Settings.Default.tare;
            calibrationFactor = Properties.Settings.Default.calibrationFactor;

        }

        /// <summary>
        /// Makes timed calls to getForce() (# depends on dps and timing) averages the result. 
        /// The averaged result returned is what the front end sees as a datapoint.
        /// </summary>
        /// <returns>The average force for the given number of force samples. .</returns>



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
               // dumbDelay(delay);
                return reading;
            }
            catch
            {
                Console.WriteLine("error");
                return "error";
            }

        }

        public bool hasConnection()
        {
            return mySerialPort.IsOpen;
        }

    }
        
   }
