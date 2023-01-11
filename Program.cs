namespace ArduinoCHomeController
{
    internal class Program
    {
        static Communication communicate = new Communication(9600,"COM3");
        static void Main(string[] args)
        {
            communicate.StartCommunicationWithArduino();
            string command = string.Empty;
            do
            {
                Console.WriteLine(@"To controll the light write ""on"" or ""Off"". To close the program press enter.");
                command=Console.ReadLine();
                if (command.ToUpper() == "ON") communicate.ControllLight(true);
                else if (command.ToUpper() == "OFF") communicate.ControllLight(false);

            } while (!String.IsNullOrEmpty(command));
            communicate.StopCommunicationWithArduino();
        }
    }
}