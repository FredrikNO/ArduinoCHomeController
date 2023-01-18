using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoCHomeController
{
    internal interface ICommunication
    {
        void WriteToArduino(string message);
    }
}
