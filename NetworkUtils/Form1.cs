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
        private bool runningTraceroute = false;
        private bool performingNetworkTask = false;
        private bool pingQueryIsMulti = false;

        StressTest stressTest;
        MultiIPPingQuery multiIPPingQuery;
        PingQuery pingQuery;
        Traceroute traceroute;

        private System.Threading.Thread pingThread;
        private System.Threading.Thread stressTestThread;
        private System.Threading.Thread tracerouteThread;

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

        public void OnPingQueryStatusChanged(object source, ProgressEventArgs a)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    pingProgressBar.Value = (int)(((float)a.current / a.maximum) * 100);
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

        public void OnTracerouteFinished(object source, EventArgs a)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ToggleTracerouteButton));
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
                if (pingQuery != null)
                {
                    pingQuery.Stop();
                    pingQuery = null;
                    pingThread = null;
                }
                else
                {
                    multiIPPingQuery.Stop();
                    multiIPPingQuery = null;
                    multiIPPingQuery = null;
                }
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

        public void ToggleTracerouteButton()
        {
            runningTraceroute = !runningTraceroute;
            performingNetworkTask = runningTraceroute;
            if (runningTraceroute)
            {
                tracerouteButton.BackColor = Color.Red;
                tracerouteButton.Text = "Stop";
            }
            else
            {
                traceroute.Stop();
                traceroute = null;
                tracerouteThread = null;
                tracerouteButton.BackColor = Color.Green;
                tracerouteButton.Text = "Traceroute";
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

                if (ipRangeCheckbox.Checked)
                {
                    multiIPPingQuery = new
                        MultiIPPingQuery(IPAddressTextBox1.Text,
                        IPAddressTextBox2.Text, numTimes, ttl, timeOut, buffSize,
                        pingDelay, fragmentPing, this);

                    multiIPPingQuery.MultiIPPingQueryFinished += OnPingQueryFinished;
                    multiIPPingQuery.MultiIPPingQueryStatusChanged += OnPingQueryStatusChanged;

                    pingThread = new System.Threading.Thread(new
                        System.Threading.ThreadStart(
                            multiIPPingQuery.Start
                        ));
                    pingThread.Start();
                }
                else
                {
                    pingQuery = new
                        PingQuery(IPAddressTextBox1.Text,
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
                }
            }
            else
            {
                if (pingQuery != null)
                {
                    pingQuery.Stop();
                }
                else if (multiIPPingQuery != null)
                {
                    multiIPPingQuery.Stop();
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
                if (ipRangeCheckbox.Checked)
                {
                    MessageBox.Show("IP Range cannot be used for stress testing.", "IP Range not allowed");
                    return;
                }
                bool isUDP = udpRadioButton.Checked;
                int packetLimit = (int)packetLimitUpDown.Value;
                int port = (int)portNumberSelector.Value;
                string _IPAddress = IPAddressTextBox1.Text;

                // Not yet implemented:
                long packetDelay = 0;
                string packetContents = "desu~~"; // In honor of LOIC

                ToggleStressTestButton();

                stressTest = new StressTest
                    (isUDP, packetLimit, packetDelay,
                    packetContents, port, _IPAddress, this);


                // Delegate events for asynchronous control of Windows Forms
                stressTest.StressTestFinished += OnStressTestFinished;
                
                stressTestThread = new System.Threading.Thread(new
                    System.Threading.ThreadStart(
                        stressTest.Start
                    ));
                stressTestThread.Start();

            }
            else
            {
                if (stressTest != null)
                {
                    stressTest.Stop();
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tracerouteButton_Click(object sender, EventArgs e)
        {
            int ttl = (int)tracerouteTTLUpDown.Value;
            int timeout = (int)tracerouteTimeoutUpDown.Value;
            if (!runningTraceroute)
            {
                if (ipRangeCheckbox.Checked)
                {
                    MessageBox.Show("IP Range cannot be used for traceroute.", "IP Range not allowed");
                    return;
                }
                
                string _IPAddress = IPAddressTextBox1.Text;
                
                ToggleTracerouteButton();

                traceroute = new Traceroute(_IPAddress, ttl, timeout, this);


                // Delegate events for asynchronous control of Windows Forms
                traceroute.TracerouteFinished += OnTracerouteFinished;

                tracerouteThread = new System.Threading.Thread(new
                    System.Threading.ThreadStart(
                        traceroute.Start
                    ));
                tracerouteThread.Start();

            }
            else
            {
                if (traceroute != null)
                {
                    traceroute.Stop();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clearTextBoxButton_click(object sender, EventArgs e)
        {
            this.Invoke(new Action(clearTextBox));
        }

        private void clearTextBox()
        {
            outputTextBox.Text = string.Empty;
        }
    }
}
