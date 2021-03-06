﻿using System;

using System.Threading;

using System.IO.Ports;

using System.IO;


public class ArduinoControllerMain
{

    SerialPort currentPort;
    bool portFound;
    public SerialPort SetComPort()
    {
        try
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                currentPort = new SerialPort(port, 9600);
                if (DetectArduino())
                {
                    RGBro.Properties.Settings.Default.port = port;
                    RGBro.Properties.Settings.Default.Save();
                    portFound = true;
                    break;
                }
                else
                {
                    portFound = false;

                }
                currentPort.Close();
            }

        }
        catch (Exception e)
        {
            Console.Out.Write(e);
        }
        if (!portFound)
        {
            currentPort = null;
        }
        return currentPort;
    }
    private bool DetectArduino()
    {
        try
        {
            //The below setting are for the Hello handshake
            byte[] buffer = new byte[5];
            buffer[0] = Convert.ToByte(16);
            buffer[1] = Convert.ToByte(128);
            buffer[2] = Convert.ToByte(0);
            buffer[3] = Convert.ToByte(0);
            buffer[4] = Convert.ToByte(4);
            int intReturnASCII = 0;
            char charReturnValue = (Char)intReturnASCII;
            currentPort.Open();
            currentPort.Write(buffer, 0, 5);
            Thread.Sleep(1000);
            int count = currentPort.BytesToRead;
            string returnMessage = "";
            while (count > 0)
            {
                intReturnASCII = currentPort.ReadByte();
                returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                count--;
            }
            currentPort.Close();
            if (returnMessage.Contains("Z"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception e)
        {
            return false;
        }
    }
}