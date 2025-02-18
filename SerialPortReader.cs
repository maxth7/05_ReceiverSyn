using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.Windows.Forms;

namespace _04_serialportnet
{
    internal class SerialPortReader
    {
        private readonly  SerialPort _serialPort;
        private readonly TextBox _outputTextBox;


        public SerialPortReader(TextBox outputTextBox, string PortName)
        {
           
            _outputTextBox = outputTextBox;
       
            _serialPort = new SerialPort(PortName)
            {
                BaudRate = 9600,
                Parity = Parity.None,
                StopBits = StopBits.One,
                DataBits = 8,
                Handshake = Handshake.None
            };

            _serialPort.DataReceived += SerialPort_DataReceived;

        }
   
        public void StartReading()
        {
            if (!_serialPort.IsOpen)
            {
                _serialPort.Open();
            }
        }

      
        public void StopReading()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }


        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
         
            string data = _serialPort.ReadExisting();

         
            _outputTextBox.Invoke((MethodInvoker)(() =>
            {
                _outputTextBox.AppendText(data + Environment.NewLine);
            }));

           
        }
    }
}
