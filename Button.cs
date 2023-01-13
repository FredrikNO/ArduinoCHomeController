using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCHomeController
{
    internal class Button : Communication
    {
        public void ControllLight(string command)
        {
            if(command is "ON" or "OFF") WriteToArduino(command);
            else if (String.IsNullOrWhiteSpace(command))
            {
                WriteToArduino("OFF");
                Console.WriteLine("Closing application");
            }
            else Console.WriteLine($"You typed {command} this is not an option");
        }
    }
}
