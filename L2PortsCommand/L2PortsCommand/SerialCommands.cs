using L2ARAutomationSerialPort;
using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace L2PortsCommand
{
    public class SerialCommands
    {
        private SerialPort serialPort;
        private object COMPortLock = new object();
        FormSerialPortAutomation frmApp = FormSerialPortAutomation.getInstance();

        //list existing ports and return them in the Ports combobox
        public void SearchPortsExisting()
        {
            if (frmApp == null) return;

            try
            {
                string[] ports = SerialPort.GetPortNames();
                frmApp.comboBoxPorts.Items.Clear();

                foreach (string port in ports)
                {
                    frmApp.comboBoxPorts.Items.Add(port);
                }

                if (frmApp.comboBoxPorts.Items.Count > 0)
                {
                    frmApp.comboBoxPorts.SelectedIndex = 0;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error reading ports: " + ex.Message);
            }
        }

        public string sendSerialComandAndRead(string serialCmd, string stationType)
        {
            if (frmApp == null) return string.Empty;

            char[] CR = { '\r' };
            string response = string.Empty;
            frmApp.textBoxResult.Text += ">\r" + Environment.NewLine;

            try
            {
                CloseSerialPort();
                ReconnectSerialPort();

                using (serialPort)
                {
                    WriteLine(string.Format("{0}\r", serialCmd));
                    //serialPort.WriteLine(string.Format("{0}\r\n", serialCmd));

                    //using only to L2ar
                    if (stationType == "L2AR")
                    {                        
                        response = ReadLine(500);
                        //response = serialPort.ReadExisting();
                        frmApp.textBoxResult.Text += "Response:" + response;
                    }
                    else
                    {
                        response = ReadLine();
                        frmApp.textBoxResult.Text += "Response:" + response;
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error sending command: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format error: " + ex.Message);
            }
            return response;
        }

        public void ReconnectSerialPort()
        {
            if (frmApp == null) return;

            try
            {
                serialPort = new SerialPort(frmApp.comboBoxPorts.Text);
                serialPort.BaudRate = int.Parse(frmApp.comboBoxBoundRate.Text);
                serialPort.DataBits = int.Parse(frmApp.comboBoxDataBits.Text);
                serialPort.DtrEnable = false;
                serialPort.RtsEnable = false;
                serialPort.ReadTimeout = 10000;
                serialPort.WriteTimeout = 10000;
                serialPort.Parity = Parity.None;

                if (frmApp.comboBoxStopBits.Text == "One")
                    serialPort.StopBits = StopBits.One;

                if (frmApp.comboBoxStopBits.Text == "Two")
                    serialPort.StopBits = StopBits.Two;

                if (frmApp.comboBoxPorts.Text != "COM0")
                    serialPort.Open();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error connecting: " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format error: " + ex.Message);
            }
        }

        public void CloseSerialPort()
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();
                serialPort.Close();
            }
        }

        public void WriteLine(string Data)
        {
            try
            {
                lock (COMPortLock)
                {
                    serialPort.WriteLine(Data);
                }
            }

            catch (TimeoutException ex)
            {
                MessageBox.Show("Time error: " + ex.Message);
            }
        }

        private string ReadLine()
        {
            char[] CR = { '\r' };
            string PortResponse = null;
            try
            {
                lock (COMPortLock)
                {
                    PortResponse = serialPort.ReadLine().TrimEnd(CR);
                }
            }

            catch (TimeoutException) { }

            return PortResponse;
        }

        public string ReadLine(int Timeout)
        {
            string PortResponse = null;
            int existingTimeout = 0;

            lock (COMPortLock)
            {
                existingTimeout = serialPort.ReadTimeout;
                serialPort.ReadTimeout = Timeout;
                PortResponse = ReadLine();
                serialPort.ReadTimeout = existingTimeout;
            }
            return PortResponse;
        }

        public void ClearReceiveBuffer()
        {
            try
            {
                serialPort.DiscardInBuffer();              
            }
            catch (Exception)  { }
        }
    }
}