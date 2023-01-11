using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCHomeController
{
    internal class Button : Communication
    {
        public Button(int baudRate, string portName)
        {
            SerialPort.BaudRate = 9600;
            SerialPort.PortName = "COM3";
        }
    }
}
