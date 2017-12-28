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

        NetworkUtilities.PingQuery pingQuery;
        private System.Threading.Thread pingThread;
        

        public void OnPingQueryFinished(object source, EventArgs a)
        {
            Console.WriteLine("THE OPQF HAS EXECUTED");
            if (InvokeRequired)
            {
                Invoke(new Action(TogglePingButton));
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
                pingQuery.Stop(); // Stop it, even if it stopped normally
                pingQuery = null;
                pingThread = null;
                pingButton.BackColor = Color.Green;
                pingButton.Text = "Ping";
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

                pingQuery.PingQueryFinished += OnPingQueryFinished;

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
                    Console.WriteLine(e.StackTrace); //
                }
                return;
            }
            outputTextBox.Text += value;
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
    }
}
