using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCHomeController
{
    internal class TestClass : ICommunication
    {
        private static SerialPort? SerialPort;
        public TestClass(SerialPort serialPort)
        {
            SerialPort = serialPort;
        }

        public static void StartCommunicationWithArduino()
        {
            SerialPort.Open();
        }
        public static void StopCommunicationWithArduino()
        {
            SerialPort.Close();
        }

        public void WriteToArduino(string message) //Burde endres. Skal endres når det byttes til interface.
        {
            SerialPort.Write(message);
        }
    }
}
