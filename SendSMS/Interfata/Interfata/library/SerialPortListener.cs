using System.IO.Ports;
using System.Threading;

namespace Interfata.library
{
    public class SerialPortListener
    {
        private readonly int _baudRate = 9600;
        private readonly string _portName = "COM3";

        public void Send(string command)
        {   
            //connection to the serial port by passing name and baud
            using (var serialPort = new SerialPort(_portName, _baudRate))
            {  
                //open connection to the serial port
                serialPort.Open();
                //comand is parameter to function that is called from home controller
                serialPort.Write(command);
                 Thread.Sleep(5000);
                  
            }
        }
    }
}
