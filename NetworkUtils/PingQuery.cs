using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkUtils
{
    public class PingQuery
    {


        public delegate void PingQueryFinishedEventHandler(object source, EventArgs args);
        public delegate void PingQueryStatusChangedEventHandler(object source, ProgressEventArgs args);

        public event PingQueryFinishedEventHandler PingQueryFinished;
        public event PingQueryStatusChangedEventHandler PingQueryStatusChanged;

        bool running = false;
        int numTimes = 0;
        int ttl = 0;
        int timeOut = 0;
        int buffSize = 0;
        int pingDelay = 0;
        IPAddress ip = null;
        bool fragmentPing = false;
        mainForm formReference = null;

        public PingQuery(String _IPAddress, int numTimes,
            int ttl, int timeOut, int buffSize, int pingDelay,
            bool fragmentPing, mainForm formReference)
        {
            this.ip = NetworkUtilities.StringToIPAddress(_IPAddress);
            this.numTimes = numTimes;
            this.ttl = ttl;
            this.timeOut = timeOut;
            this.buffSize = buffSize;
            this.pingDelay = pingDelay;
            this.fragmentPing = fragmentPing;
            this.formReference = formReference;
        }

        private void Run()
        {
            int numTimesPerformed = 0;
            int numSuccess = 0;
            long totalTimeMS = 0;
            byte[] buffer = new byte[buffSize];
            for (int i = 0; i < numTimes; i++)
            {
                if (!running)
                {
                    break;
                }
                formReference.AppendTextBox("Pinging " + ip + "...\r\n");

                Ping ping = new Ping();

                PingOptions options = new PingOptions(ttl, fragmentPing);

                PingReply reply = ping.Send(ip, timeOut, buffer, options);

                if (reply.Status == IPStatus.Success)
                {
                    formReference.AppendTextBox(ip + " successfully pinged in " + reply.RoundtripTime + "ms.\r\n");
                    numSuccess++;
                    totalTimeMS += reply.RoundtripTime;
                }
                else if (reply.Status == IPStatus.TimeExceeded)
                {
                    formReference.AppendTextBox("Ping failed for host " + ip + " - TTL expired.\r\n");
                }
                else if (reply.Status == IPStatus.TimedOut)
                {
                    formReference.AppendTextBox("Ping timed out for host " + ip + " - timed out.\r\n");
                }
                else if (reply.Status == IPStatus.DestinationHostUnreachable)
                {
                    formReference.AppendTextBox("Ping timed out for host " + ip + " - destination host unreachable.\r\n");
                }
                else if (reply.Status == IPStatus.DestinationNetworkUnreachable)
                {
                    formReference.AppendTextBox("Ping timed out for host " + ip + " - destination network unreachable.\r\n");
                }
                else
                {
                    formReference.AppendTextBox("Faied to ping " + ip + "\r\n");
                }

                // Deal with delay
                if (pingDelay > 0)
                {
                    System.Threading.Thread.Sleep(pingDelay);
                }
                numTimesPerformed++;
                OnPingQueryStatusChanged((uint)numTimesPerformed, (uint)numTimes);
            }
            if (numSuccess > 0)
            {
                formReference.AppendTextBox("IP " + ip + " pinged successfully " + numSuccess + " out of " + numTimes + " times.\r\n");
                formReference.AppendTextBox("Total roundtrip time: " + totalTimeMS + "ms\tAverage roundtrip time: " + totalTimeMS / numTimesPerformed + "ms\r\n");
            }
            OnPingQueryFinished();
        }


        public void Start()
        {
            if (ip == null)
            {
                MessageBox.Show("The IP Address you have entered is invalid! Please enter a valid IP Address and try again.",
                "Bad IP Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnPingQueryFinished();
                return;
            }
            else
            {
                running = true;
                Run();
            }
        }

        public void Stop()
        {
            running = false;
        }

        // The callback to let the Windows Form know that
        // the ping query is finished
        public void OnPingQueryFinished()
        {
            PingQueryFinished(this, EventArgs.Empty);
        }

        public void OnPingQueryStatusChanged(uint curr, uint max)
        {
            PingQueryStatusChanged(this, new ProgressEventArgs(curr, max));
        }

        public void PingTargetIP(String _IPAddress, int numTimes, int ttl,
        int timeOut, int buffSize, int pingDelay, bool fragmentPing,
        TextBox output)
        {
            int numTimesPerformed = 0;
            int numSuccess = 0;
            long totalTimeMS = 0;
            IPAddress ip = NetworkUtilities.StringToIPAddress(_IPAddress);
            if (ip != null)
            {
                byte[] buffer = new byte[buffSize];
                for (int i = 0; i < numTimes; i++)
                {
                    output.AppendText("Pinging " + ip + "...\r\n");

                    Ping ping = new Ping();

                    PingOptions options = new PingOptions(ttl, fragmentPing);

                    PingReply reply = ping.Send(ip, timeOut, buffer, options);

                    if (reply.Status == IPStatus.Success)
                    {
                        output.AppendText(ip + " successfully pinged in " + reply.RoundtripTime + "ms.\r\n");
                        numSuccess++;
                        totalTimeMS += reply.RoundtripTime;
                    }
                    else if (reply.Status == IPStatus.TimeExceeded)
                    {
                        output.AppendText("Ping failed for host " + ip + " - TTL expired.\r\n");
                    }
                    else if (reply.Status == IPStatus.TimedOut)
                    {
                        output.AppendText("Ping timed out for host " + ip + " - timed out.\r\n");
                    }
                    else if (reply.Status == IPStatus.DestinationHostUnreachable)
                    {
                        output.AppendText("Ping timed out for host " + ip + " - destination host unreachable.\r\n");
                    }
                    else if (reply.Status == IPStatus.DestinationNetworkUnreachable)
                    {
                        output.AppendText("Ping timed out for host " + ip + " - destination network unreachable.\r\n");
                    }
                    else
                    {
                        output.AppendText("Faied to ping " + ip + "\r\n");
                    }

                    // Deal with delay
                    if (pingDelay > 0)
                    {
                        System.Threading.Thread.Sleep(pingDelay);
                    }
                }
            }
            else
            {
                MessageBox.Show("The IP Address you have entered is invalid! Please enter a valid IP Address and try again.",
                    "Bad IP Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnPingQueryFinished();
                return;
            }
            if (numSuccess > 0)
            {
                output.AppendText("IP " + ip + " pinged successfully " + numSuccess + " out of " + numTimesPerformed + " times.\r\n");
                output.AppendText("Total roundtrip time: " + totalTimeMS + "ms\tAverage roundtrip time: " + totalTimeMS / numTimesPerformed + "ms\r\n");
            }

            OnPingQueryFinished();
        }

    }
}