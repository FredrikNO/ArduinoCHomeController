using System.IO.Ports;

namespace ArduinoCHomeController
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Button button1 = new Button(new Communication(), "Port3");
            Button button2 = new Button(new Communication(), "Port4");
            Button button3 = new Button(new Communication(), "Port5");
            Communication.StartCommunicationWithArduino();
            string command = string.Empty;
            do
            {
                
                Console.WriteLine(@"To control the light write (1,2,3) and ""on"" or ""Off"". To close the program press enter.");
                command = Console.ReadLine().ToUpper();
                if (command[0] == '1')
                {
                    button1.ControllLight(command.Substring(1, command.Length-1));
                }
                else if (command[0] == '2')
                {
                    button2.ControllLight(command.Substring(1, command.Length - 1));
                }
                else if (command[0] == '3')
                {
                    button3.ControllLight(command.Substring(1, command.Length - 1));
                }

            } while (!String.IsNullOrEmpty(command));
            Communication.StopCommunicationWithArduino();   
        }
    }
}