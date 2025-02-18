using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace _04_serialportnet
{
    public partial class FormReceiver : Form
    {
        private readonly Timer blinkTimer; 
        private readonly Color originalCircleColor; 
        private readonly Color originalInnerCircleColor; 

        private  SerialPortReader _serialPortReader;

        public FormReceiver()
        {
            InitializeComponent();

            TextBoxReceiver.Text = "";
            textBoxMessages.Text = "";
            //1)
            customCheckBox21CD.Checked = true;
            customCheckBox21CD.CircleColor = Color.Green; 
            customCheckBox21CD.InnerCircleColor = Color.Green;
            //2)
            customCheckBox21RI.Checked = true;
            customCheckBox21RI.CircleColor = Color.Green;
            customCheckBox21RI.InnerCircleColor = Color.Green;
            //3)
            customCheckBox21DSR.Checked = true;
            customCheckBox21DSR.CircleColor = Color.Green; 
            customCheckBox21DSR.InnerCircleColor = Color.Green;
            //4)
            customCheckBox21CTS.Checked = true;
            customCheckBox21CTS.CircleColor = Color.Green;
            customCheckBox21CTS.InnerCircleColor = Color.Green;

            customCheckBox21TX.Checked = true;
            customCheckBox21TX.CircleColor = Color.Black; 
            customCheckBox21TX.InnerCircleColor = Color.Black; 

            checkBox2DTR.Enabled = true;
            checkBox2RTS.Enabled = true;

            originalCircleColor = customCheckBox21TX.CircleColor; 
            originalInnerCircleColor = customCheckBox21TX.InnerCircleColor;

            blinkTimer = new Timer();
            blinkTimer.Interval = 500; 
            blinkTimer.Tick += BlinkTimer_Tick; 

        }
        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            customCheckBox21TX.CircleColor = customCheckBox21TX.CircleColor == originalCircleColor
                ? Color.Green
                : originalCircleColor;

            customCheckBox21TX.InnerCircleColor = customCheckBox21TX.InnerCircleColor == originalInnerCircleColor
                ? Color.Green
                : originalInnerCircleColor;
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close the app?",
                                          "Confirmation",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
               e.Cancel = true;
            }
        }
       
      private void ButtonOpenClick(object sender, EventArgs e)
        {
            string PortNameReceivingPort = comboBoxNameReceiverPort.Text;
            try
            {
               if (buttonOpen.Text == "Open")
                {

                    textBoxMessages.AppendText("The port has been opened: "
                                            + PortNameReceivingPort
                                            + "."
                                            + Environment.NewLine);
       
                    _serialPortReader = new SerialPortReader(TextBoxReceiver,
                                                           PortNameReceivingPort);

                    _serialPortReader.StartReading();

                    if (!blinkTimer.Enabled)
                    {
                        blinkTimer.Start();
                    }
                    buttonOpen.Text = "Close";
                }
                else 
                {
                    if (blinkTimer.Enabled)
                    {
                        blinkTimer.Stop();
                        customCheckBox21TX.CircleColor = Color.Black;
                        customCheckBox21TX.InnerCircleColor = Color.Black;
                    }
                    _serialPortReader.StopReading();
   
                    textBoxMessages.AppendText("The port "
                                            + PortNameReceivingPort
                                            + " was closed."
                                            + Environment.NewLine);

                    buttonOpen.Text = "Open";
                    TextBoxReceiver.Text = "";


                }
            }
            catch (UnauthorizedAccessException ex)
            {
                textBoxMessages.ForeColor = Color.Red;
                textBoxMessages.AppendText("Port access error:"
                    + PortNameReceivingPort + "."
                    + Environment.NewLine
                    + "The port, "
                    + PortNameReceivingPort
                    + "  may be closed or occupied by another program."
                    + Environment.NewLine
                    + ex.Message
                     + Environment.NewLine);
   
                if (blinkTimer.Enabled)
                {
                    blinkTimer.Stop();
                    customCheckBox21TX.CircleColor = Color.Black;
                    customCheckBox21TX.InnerCircleColor = Color.Black;
                }
                _serialPortReader.StopReading();
   
                textBoxMessages.AppendText("The port "
                                        + PortNameReceivingPort
                                        + " was closed."
                                         + Environment.NewLine);

                buttonOpen.Text = "Open";
            }
            catch (IOException ex)
            {
  
                textBoxMessages.ForeColor = Color.Red;
  
                textBoxMessages.AppendText("Input/output error." +
                                          " Check the connection of the port "
                                          + PortNameReceivingPort
                                          + "."
                                          + ex.Message
                                          + Environment.NewLine);
  
                if (blinkTimer.Enabled)
                {
                    blinkTimer.Stop();
                    customCheckBox21TX.CircleColor = Color.Black;
                    customCheckBox21TX.InnerCircleColor = Color.Black;
                }
                _serialPortReader.StopReading();
  
                textBoxMessages.AppendText("The port "
                                        + PortNameReceivingPort
                                        + "  was closed."
                                         + Environment.NewLine);

                buttonOpen.Text = "Open";
            }
            catch (Exception ex)
            {
                textBoxMessages.ForeColor = Color.Red;
                textBoxMessages.AppendText("Error "
                                            + PortNameReceivingPort
                                            + ":"
                                            + ex.Message
                                            + Environment.NewLine);
  
                if (blinkTimer.Enabled)
                {
                    blinkTimer.Stop();
                    customCheckBox21TX.CircleColor = Color.Black;
                    customCheckBox21TX.InnerCircleColor = Color.Black;
                }
                _serialPortReader.StopReading();
  
                textBoxMessages.AppendText("The port "
                                        + PortNameReceivingPort
                                        + " was closed."
                                         + Environment.NewLine);
                  
                buttonOpen.Text = "Open";
            }
         }

        private void FormReceiver_Load(object sender, EventArgs e)
        {

        }
    }
}
