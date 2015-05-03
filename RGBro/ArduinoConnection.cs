using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLED
{
    class ArduinoConnection
    {
        private SerialPort arduinoPort = null;

        //Potentially hangs
        public bool Connect()
        {
            //use connection from last time
            if (RGBro.Properties.Settings.Default.port != null && RGBro.Properties.Settings.Default.port != "")
            {
                arduinoPort = new SerialPort(RGBro.Properties.Settings.Default.port, 9600);
                return true;
            }
            //make one attempt at getting the port
            if (arduinoPort == null)
            {
                ArduinoControllerMain arduinoControllerMain = new ArduinoControllerMain();
                arduinoPort = arduinoControllerMain.SetComPort();
                if (arduinoPort == null)
                {
                    return false;
                }
            }
            return true;
        }

        public String PortName
        {
            get
            {
                return arduinoPort.PortName;
            }
            
        }

        public void resetConnection()
        {
            arduinoPort = null;
        }

        private enum CommunicationType
        {
            SendCommand = 16
        }
        private enum CommandType
        {
            SetLed = 126,
            SetCrossfade = 125
        }
        public void sendSingleColor(int r, int g, int b)
        {
            if (Connect() == false)
            {
                return;
            }
            byte[] bytesToSend = new byte[5] 
            { 
                Convert.ToByte(CommunicationType.SendCommand),
                Convert.ToByte(CommandType.SetLed),
                Convert.ToByte(r),
                Convert.ToByte(g),
                Convert.ToByte(b)
            };

            try
            {
                arduinoPort.Open();
                arduinoPort.Write(bytesToSend, 0, 5);
                arduinoPort.Close();
            }
            catch (Exception ex)
            {
                arduinoPort.Close();
            }

        }

        public void sendMultipleColors(List<ColorListItem> colors, int delay)
        {
            if (Connect() == false)
            {
                return;
            }
            byte[] bytesToSend = new byte[5 + colors.Count*3];

                bytesToSend[0] = Convert.ToByte(CommunicationType.SendCommand);
                bytesToSend[1] = Convert.ToByte(CommandType.SetCrossfade);
                bytesToSend[2] = Convert.ToByte(colors.Count);
                bytesToSend[3] = Convert.ToByte(delay); //allows one decimal of precision i.e 0.7 -> 7
                bytesToSend[4] = Convert.ToByte(0);
                int j = 0;
            for(int i = 5; i < colors.Count*3 + 5; i+=3){
                bytesToSend[i] = Convert.ToByte(colors[j].ItemColor.R);
                bytesToSend[i + 1] = Convert.ToByte(colors[j].ItemColor.G);
                bytesToSend[i + 2] = Convert.ToByte(colors[j].ItemColor.B);
                j++;
            }

            try
            {
                arduinoPort.Open();
                arduinoPort.Write(bytesToSend, 0, 5 + colors.Count*3);
                arduinoPort.Close();
            }
            catch (Exception ex)
            {
                arduinoPort.Close();
            }

        }
    }
}
