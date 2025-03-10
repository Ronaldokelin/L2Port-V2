using L2PortsCommand;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2ARAutomationSerialPort
{
    public partial class FormSerialPortAutomation : Form
    {
        // Singleton instance of FormSerialPortAutomation
        private static FormSerialPortAutomation INSTANCE = null;
        SerialCommands serialCmd;       
        PowerSupply powerSupply;

        public FormSerialPortAutomation()
        {
            InitializeComponent();
            INSTANCE = this;          
            instanceClasses();
            disableTexBox();
        }

        // Method to get the singleton instance of FormSerialPortAutomation
        public static FormSerialPortAutomation getInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new FormSerialPortAutomation();

            return INSTANCE;
        }

        // Initialize the SerialCommands and PowerSupply classes
        private void instanceClasses()
        {
            serialCmd = new SerialCommands();
            powerSupply = new PowerSupply();
            serialCmd.SearchPortsExisting();
        }

        // Event handler for the Search button click event
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.SearchPortsExisting();
            }
            catch
            {
                MessageBox.Show("Error to search the COM port");
            }
        }

        // Event handler for the Reconnect button click event
        private void btnReconnect_Click(object sender, EventArgs e)
        {
            serialCmd.CloseSerialPort();
            serialCmd.ReconnectSerialPort();
        }

        // Event handler for the send commands button click event
        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead(textBoxSend.Text, "button");
                textBoxSend.Text = ">";
            }
            catch
            {
                MessageBox.Show("Error to send the written command!");
            }
        }

        // Event handler for Clear the textBoxResult on button click event
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }

        // tabPageL2AR
        // Event handler for the L2AR buttons click event
        // Action commands
        private void buttonOpenDrawer_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("TWOON", "L2AR");
                buttonOpenDrawer.BackColor = Color.Green;
                buttonCloseDrawer.BackColor = Color.Red;

            }
            catch
            {
                MessageBox.Show("Error to send TWOON command!");
            }
        }
        private void buttonCloseDrawer_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("TWOOFF", "L2AR");
                buttonCloseDrawer.BackColor = Color.Green;
                buttonOpenDrawer.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send TWOOFF command!");
            }
        }
        private void LckOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("OPEN", "L2AR");
                LckOpen.BackColor = Color.Green;
                LckClose.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send OPEN command!");
            }
        }
        private void LckClose_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("CLOSE", "L2AR");
                LckClose.BackColor = Color.Green;
                LckOpen.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send CLOSE command!");
            }
        }
        private void buttonUpClip_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("SIXON", "L2AR");
                buttonUpClip.BackColor = Color.Green;
                buttonDownClip.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send SIXON command!");
            }
        }
        private void buttonDownClip_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("SIXOFF", "L2AR");
                buttonDownClip.BackColor = Color.Green;
                buttonUpClip.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to sende SIXOFF command!");
            }
        }
        private void buttonUSBIn_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("FOURON", "L2AR");
                buttonUSBIn.BackColor = Color.Green;
                buttonUSBOut.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send FOURON command!");
            }
        }
        private void buttonUSBOut_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("FOUROFF", "L2AR");
                buttonUSBOut.BackColor = Color.Green;
                buttonUSBIn.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send FOUROFF command!");
            }
        }
        private void buttonP3In_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("FIVEON", "L2AR");
                buttonP3In.BackColor = Color.Green;
                buttonP3Out.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send FIVEOFF command!");
            }
        }
        private void buttonP3Out_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("FIVEOFF", "L2AR");
                buttonP3Out.BackColor = Color.Green;
                buttonP3In.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send FIVEOFF command!");
            }
        }

        private void btnMicBlockOn_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("H12ON", "L2AR");
                btnMicBlockOn.BackColor = Color.Green;
                btnMicBlockOff.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send Audio command!");
            }
        }

        private void btnMicBlockOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("H12OFF", "L2AR");
                btnMicBlockOff.BackColor = Color.Green;
                btnMicBlockOn.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send Audio command!");
            }

        }
        private void btnSenEnd_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("KEY", "L2AR");
            }
            catch
            {
                MessageBox.Show("Erro to send SendEnd command!");
            }
        }

        // Configuration commands
        private void buttonAudio_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("Audio", "L2AR");
                buttonAudio.BackColor = Color.Green;
                buttonRadio.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send Audio command!");
            }
        }

        private void buttonRadio_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("Radio", "L2AR");
                buttonRadio.BackColor = Color.Green;
                buttonAudio.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send Radio command!");
            }
        }
        private void buttonHeadSetOn_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("ONAUD", "L2AR");
                buttonHeadSetOn.BackColor = Color.Green;
                buttonHeadSetOff.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send ONAUD command!");
            }
        }
        private void buttonHeadSetOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("OFFAUD", "L2AR");
                buttonHeadSetOff.BackColor = Color.Green;
                buttonHeadSetOn.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send OFFAUD command!");
            }
        }
        private void btnUSBOn_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("0", "L2AR");
                btnUSBOn.BackColor = Color.Green;
                btnUSBOff.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send USBON command!");
            }
        }
        private void btnUSBOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("1", "L2AR");
                btnUSBOff.BackColor = Color.Green;
                btnUSBOn.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send USBOFF command");
            }
        }
        private void btnDoorConfig_Click(object sender, EventArgs e)
        {
            FormCommandLoop formCommandLoop = new FormCommandLoop(serialCmd);
            formCommandLoop.Show();
        }

        // Accessory Power Supply
        // Event handler for the PowerSupply buttons click event
        private void btnPowerSupply_Click(object sender, EventArgs e)
        {
            try
            {
                powerSupply.PowerSupplyCommands();
            }
            catch
            {
                MessageBox.Show("Error to set PowerSupply!");
            }
        }

        // tabPageDepth
        // Event handler for the DEPTH buttons click event
        private void buttonOrigin_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("move000", "DEPTH");
            }
            catch
            {
                MessageBox.Show("Error to send move000 command");
            }
        }
        private void buttonDistance25_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("move250", "DEPTH");
            }
            catch
            {
                MessageBox.Show("Error to send move250 command!");
            }
        }
        private void buttonDistance30_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("move300", "DEPTH");
            }
            catch
            {
                MessageBox.Show("Error to send move300 command!");
            }
        }
        private void buttonStatus_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("status", "DEPTH");
            }
            catch
            {
                MessageBox.Show("Error to send status command!");
            }
        }
        private void buttonUP_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("H1UP", "DEPTH");
            }
            catch
            {
                MessageBox.Show("Error to send H1UP command!");
            }
        }
        private void buttonDown_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("H1DOWN", "DEPTH");
            }
            catch
            {
                MessageBox.Show("Error to send H1DOWN command!");
            }
        }

        // tabPageL2Vision
        // Event handler for the L2VISION buttons click event
        private void btnGetLigthVendor_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("get_LightSource_Vendor", "L2VISION");
            }
            catch
            {
                MessageBox.Show("Error to send get_LightSource_Vendor command!");
            }
        }
        private void btnGetLightModel_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("get_LightSource_Model", "L2VISION");
            }
            catch
            {
                MessageBox.Show("Error to send get_LightSource_Model command!");
            }
        }
        private void btnGetLightSourceSerialNum_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("get_LightSource_SerialNum", "L2VISION");
            }
            catch
            {
                MessageBox.Show("Error to send get_LightSource_SerialNum command!");
            }
        }
        private void btnGetLightSource01_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("get_LightSource_01", "L2VISION");
            }
            catch
            {
                MessageBox.Show("Error to send get_LightSource_01 command!");
            }
        }
        private void btnGetLightSourceFreq01_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("get_LightSource_FREQ_01", "L2VISION");
            }
            catch
            {
                MessageBox.Show("Error to send get_LightSource_FREQ_01 command!");
            }
        }
        private void btnStartLightSourceFreq01_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("Start_LightSource_FREQ_01", "L2VISION");
            }
            catch
            {
                MessageBox.Show("Error to Send Start_LightSource_FREQ_01 Command!");
            }
        }
        private void btnStopLightSource01_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("Stop_LightSource_FREQ_01", "L2VISION");
            }
            catch
            {
                MessageBox.Show("Errror to send Stop_LightSource_FREQ_01 command!");
            }
        }

        // tabPageSqt
        // Event handler for the SQT buttons click event
        private async void buttonMoveUp_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("OUT1_ON", "SQT");
                buttonMoveUp.BackColor = Color.Green;
                buttonMoveDown.BackColor = Color.Red;
                progressBarNear.Value = 0;
                progressBarFar.Value = 0;

                string response = null;
                var stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Restart();
                do
                {
                    await Task.Delay(100);
                    textBoxResult.Text = "";
                    response = serialCmd.sendSerialComandAndRead("IN2", "SQT");
                    int elapsedTime = (int)stopwatch.ElapsedMilliseconds;
                    progressBarFar.Value = Math.Min(elapsedTime, progressBarFar.Maximum);

                } while (!response.Contains("IN2:0") && progressBarFar.Value < 3401);
                stopwatch.Stop();

                labelTFarValor.Text = $"{progressBarFar.Value} ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar o comando OUT1_ON: {ex.Message}");
            }
        }
        private async void buttonMoveDown_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("OUT1_OFF", "SQT");
                buttonMoveDown.BackColor = Color.Green;
                buttonMoveUp.BackColor = Color.Red;
                progressBarNear.Value = 0;
                progressBarFar.Value = 0;

                string response = null;
                var stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Restart();
                do
                {
                    await Task.Delay(100);
                    textBoxResult.Text = "";
                    response = serialCmd.sendSerialComandAndRead("IN1", "SQT");
                    int elapsedTime = (int)stopwatch.ElapsedMilliseconds;
                    progressBarNear.Value = Math.Min(elapsedTime, progressBarNear.Maximum);

                } while (!response.Contains("IN1:0") && progressBarNear.Value < 3401);
                stopwatch.Stop();

                labelTNearValor.Text = $"{progressBarNear.Value} ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar o comando OUT1_OFF: {ex.Message}");
            }
        }
        private void buttonLockDr_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("OUT2_ON", "SQT");
                buttonLockDr.BackColor = Color.Green;
                buttonUnlockDr.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send OUT2_ON command!");
            }
        }
        private void buttonUnlockDr_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("OUT2_OFF", "SQT");
                buttonUnlockDr.BackColor = Color.Green;
                buttonLockDr.BackColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Error to send OUT2_ON command!");
            }
        }
        private void buttonDrStatus_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult.Text = "";
                serialCmd.sendSerialComandAndRead("IN3", "SQT");
            }
            catch
            {
                MessageBox.Show("Error to send H1STATUS command!");
            }
        }

        // tabPageRGB
        // Event handler for the RGB buttons click event
        private void buttonLightOn_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("SETI:0E", "RGB");
            }
            catch
            {
                MessageBox.Show("Error to send SETI:0E command!");
            }
        }
        private void buttonLightOff_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("SETI:00", "RGB");
            }
            catch
            {
                MessageBox.Show("Error to send SETI:00 command!");
            }
        }
        private void ButtonFetl_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("FETL", "RGB");
            }
            catch
            {
                MessageBox.Show("Error to send FETL command!");
            }
        }
        private void btnSendLightSource_Click(object sender, EventArgs e)
        {
            if (textBoxBrightnessSet.TextLength == 4 && textBoxColorSet.TextLength == 4 || textBoxFrequency.TextLength == 3)
            {

                if (comboBoxSetLightSource.Text == "Set_LightSource_01_")
                {
                    serialCmd.sendSerialComandAndRead(comboBoxSetLightSource.Text + textBoxBrightnessSet.Text + "_" + textBoxColorSet.Text, "button");
                    textBoxBrightnessSet.Text = "";
                    textBoxColorSet.Text = "";
                }
                else
                {
                    serialCmd.sendSerialComandAndRead(comboBoxSetLightSource.Text + textBoxFrequency.Text, "button");
                    textBoxFrequency.Text = "";
                }
            }
            else
                MessageBox.Show("Invalid character Lenght!");
        }
        private void comboBoxSetLightSource_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxSetLightSource.Text == "Set_LightSource_FREQ_01_")
            {
                textBoxBrightnessSet.Enabled = false;
                textBoxColorSet.Enabled = false;
            }
            else
            {
                textBoxBrightnessSet.Enabled = true;
                textBoxColorSet.Enabled = true;
            }
            if (comboBoxSetLightSource.Text == "Set_LightSource_01_")
            {
                textBoxFrequency.Enabled = false;
            }
            else
                textBoxFrequency.Enabled = true;

        }
        private void disableTexBox()
        {
            textBoxBrightnessSet.Enabled = false;
            textBoxColorSet.Enabled = false;
            textBoxFrequency.Enabled = false;
        }

        // tabPageFod
        // // Event handler for the FOD buttons click event
        private void btnMoveHome_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("1000400000", "FOD");
            }
            catch
            {
                MessageBox.Show("Error to send 1000400000 command!");
            }

        }
        private void btnCheckInitial_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("4000000000", "FOD");
            }
            catch
            {
                MessageBox.Show("Error to send 4000000000 command!");
            }
        }
        private void btnMoveChart_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("1000117100", "FOD");
            }
            catch
            {
                MessageBox.Show("Error to send 1000117100 command!");
            }
        }
        private void btnChartDown_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("1100000000", "FOD");
            }
            catch
            {
                MessageBox.Show("Error to send 1100000000 command!");
            }
        }
        private void btnChartUp_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("1200000000", "FOD");
            }
            catch
            {
                MessageBox.Show("Error to send 1200000000 command!");
            }
        }
        private void btnMoveDark_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("1000220900", "FOD");
            }
            catch
            {
                MessageBox.Show("Error to send 1000220900 command!");
            }
        }
        private void btnDarkDown_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("1010000000", "FOD");
            }
            catch
            {
                MessageBox.Show("Error to send 1010000000 command!");
            }
        }
        private void btnDarkUp_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("1020000000", "FOD");
            }
            catch
            {
                MessageBox.Show("Error to send 1020000000 command!");
            }
        }
        private void btnMoveFlesh_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("1000324900", "FOD");
            }
            catch
            {
                MessageBox.Show("Error to send 1000324900 command!");
            }
        }
        private void btnFleshDown_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("1001000000", "FOD");
            }
            catch
            {
                MessageBox.Show("Error to send 1001000000 command!");
            }
        }
        private void btnFleshUp_Click(object sender, EventArgs e)
        {
            try
            {
                serialCmd.sendSerialComandAndRead("1002000000", "FOD");
            }
            catch
            {
                MessageBox.Show("Error to send 1002000000 command!");
            }
        }        
    }
}