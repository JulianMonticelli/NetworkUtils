using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkUtils
{
    public partial class mainForm : Form
    {

        private bool runningPing = false;
        private bool runningStressTest = false;
        private bool performingNetworkTask = false;

        NetworkUtilities.StressTest stressTest;
        NetworkUtilities.PingQuery pingQuery;

        private System.Threading.Thread pingThread;
        private System.Threading.Thread stressTestThread;

        public void OnPingQueryFinished(object source, EventArgs a)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(TogglePingButton));
                Invoke(new Action(() =>
                {
                    if (pingProgressBar.Value < 100)
                    {
                        pingProgressBar.Value = 0;
                    }
                }
                ));
            }
        }

        public void OnPingQueryStatusChanged(object source, NetworkUtilities.ProgressEventArgs a)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pingProgressBar.Value = (int)(((float)a.current / a.maximum) * 100);
                    pingProgressBar.Maximum = a.maximum;
                }
                ));
            }
        }

        public void OnStressTestFinished(object source, EventArgs a)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ToggleStressTestButton));
            }
        }


        public void TogglePingButton()
        {
            runningPing = !runningPing;
            performingNetworkTask = runningPing;
            if (runningPing)
            {
                pingButton.BackColor = Color.Red;
                pingButton.Text = "Stop Ping";
            }
            else
            {
                pingQuery.Stop();
                pingQuery = null;
                pingThread = null;
                pingButton.BackColor = Color.Green;
                pingButton.Text = "Ping";
            }
        }


        public void ToggleStressTestButton()
        {
            runningStressTest = !runningStressTest;
            performingNetworkTask = runningStressTest;
            if (runningStressTest)
            {
                stressTestButton.BackColor = Color.Red;
                stressTestButton.Text = "Stop";
            }
            else
            {
                stressTest.Stop(); 
                stressTest = null;
                stressTestThread = null;
                stressTestButton.BackColor = Color.Green;
                stressTestButton.Text = "Fire";
            }
        }

        public mainForm()
        {
            InitializeComponent();
        }



        private void pingButton_Click(object sender, EventArgs e)
        {
            if (!runningPing)
            {
                int numTimes = (int)numTimesPingInput.Value;
                int ttl = (int)ttlPingInput.Value;
                int timeOut = (int)timeOutPingInput.Value;
                int buffSize = (int)bufferSizePingInput.Value;
                int pingDelay = (int)pingDelayPingInput.Value;
                bool fragmentPing = fragmentPingInput.Checked;


                TogglePingButton();

                pingQuery = new
                    NetworkUtilities.PingQuery(IPAddressTextBox1.Text,
                    numTimes, ttl, timeOut, buffSize, pingDelay,
                    fragmentPing, this);

                // Delegate events for asynchronous control of Windows Forms
                // and update of ping status
                pingQuery.PingQueryFinished += OnPingQueryFinished;
                pingQuery.PingQueryStatusChanged += OnPingQueryStatusChanged;

                pingThread = new System.Threading.Thread(new
                    System.Threading.ThreadStart(
                        pingQuery.Start
                    ));
                pingThread.Start();

                Console.WriteLine("Started ping thread");

            }
            else
            {
                if (pingQuery != null)
                {
                    pingQuery.Stop();
                }
            }

        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {

                try
                {
                    this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                }
                catch (Exception e)
                {
                    Console.WriteLine("EXCEPTION CAUGHT");
                    Console.WriteLine(e.GetType());
                    Console.WriteLine(e.StackTrace);
                }
                return;
            }
            outputTextBox.AppendText(value);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tcpUdpGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void stressTestButtonClick(object sender, EventArgs e)
        {
            if (!runningStressTest)
            {
                bool isUDP = udpRadioButton.Checked;
                int packetLimit = (int)packetLimitUpDown.Value;
                int port = (int)portNumberSelector.Value;
                string _IPAddress = IPAddressTextBox1.Text;

                // Not yet implemented:
                long packetDelay = 0;
                string packetContents = "desu~~"; // In honor of LOIC

                ToggleStressTestButton();

                stressTest = new NetworkUtilities.StressTest
                    (isUDP, packetLimit, packetDelay,
                    packetContents, port, _IPAddress, this);


                // Delegate events for asynchronous control of Windows Forms
                stressTest.StressTestFinished += OnStressTestFinished;
                
                stressTestThread = new System.Threading.Thread(new
                    System.Threading.ThreadStart(
                        stressTest.Start
                    ));
                stressTestThread.Start();

                Console.WriteLine("Started stress test thread");

            }
            else
            {
                if (stressTest != null)
                {
                    stressTest.Stop();
                }
            }
        }
    }
}
