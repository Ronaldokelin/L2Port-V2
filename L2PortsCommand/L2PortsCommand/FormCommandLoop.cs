using System;
using System.Threading;
using System.Windows.Forms;

namespace L2PortsCommand
{
    public partial class FormCommandLoop : Form
    {
        SerialCommands serialCmd;
        public FormCommandLoop(SerialCommands serialCommands)
        {
            InitializeComponent();
            serialCmd = serialCommands;
        }

        private void btnStartLoop_Click(object sender, EventArgs e)
        {
            this.Refresh();
            int timeOpen = int.Parse(textBoxOpenTime.Text);
            int timeClose = int.Parse(textBoxCloseTime.Text);
            int loopValor = int.Parse(textBoxLoopValor.Text);
            int cont = 0;

            progressBarOpen.Maximum = timeOpen * 1000;
            progressBarClose.Maximum = timeClose * 1000;

            while (cont < loopValor)
            {
                // send command to close the door
                try
                {
                    string response = null;
                    var stopwatch = new System.Diagnostics.Stopwatch();                   
                    serialCmd.sendSerialComandAndRead("TWOOFF", "L2AR");
                    stopwatch.Restart();
                    do
                    {
                        response = CheckDrawerStatus();
                        int elapsedTime = (int)stopwatch.ElapsedMilliseconds;
                        progressBarClose.Value = Math.Min(elapsedTime, progressBarClose.Maximum);

                    } while (!response.Contains("CLOSE") && stopwatch.ElapsedMilliseconds < progressBarClose.Maximum);
                    stopwatch.Stop();

                    labelCloseTime.Text = $"{(progressBarClose.Value / 1000.0):F2} s";

                }
                catch (Exception) { }

                Thread.Sleep(1000);
                // send commando to open door                
                try
                {
                    string response = null;
                    var stopwatch = new System.Diagnostics.Stopwatch();                    
                    serialCmd.sendSerialComandAndRead("TWOON", "L2AR");
                    stopwatch.Restart();
                    do
                    {
                        response = CheckDrawerStatus();
                        int elapsedTime = (int)stopwatch.ElapsedMilliseconds;
                        progressBarOpen.Value = Math.Min(elapsedTime, progressBarOpen.Maximum);

                    } while (!response.Contains("OPEN") && stopwatch.ElapsedMilliseconds < progressBarOpen.Maximum);
                    stopwatch.Stop();

                    labelOpenTime.Text = $"{(progressBarOpen.Value / 1000.0):F2} s";

                }
                catch (Exception) { }
                Thread.Sleep(1000);
                cont++;
            }
        }

        public string CheckDrawerStatus()
        {
            string PortResponse = null;
            try
            {
                int nCommandMaxRetries = 1;
                int nLoop = 0;
                do
                {
                    serialCmd.ClearReceiveBuffer();
                    PortResponse = serialCmd.sendSerialComandAndRead("STATUS", "L2AR");
                }
                while (++nLoop < nCommandMaxRetries);
            }

            catch (TimeoutException)
            {
                MessageBox.Show("Time error. ");
            }

            catch (Exception ex)
            {
                MessageBox.Show("New error: " + ex.Message);
            }

            return PortResponse;
        }
    }
}
