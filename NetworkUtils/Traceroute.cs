using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkUtils
{
    public class Traceroute
    {
        public delegate void TracerouteFinishedEventHandler(object source, EventArgs args);

        public event TracerouteFinishedEventHandler TracerouteFinished;

        bool running = false;
        int ttl = 0;
        int timeout = 0;
        IPAddress ip = null;
        mainForm formReference = null;

        public Traceroute(String _IPAddress, int ttl, int timeout,
            mainForm formReference)
        {
            this.ip = NetworkUtilities.StringToIPAddress(_IPAddress);
            this.ttl = ttl;
            this.timeout = timeout;
            this.formReference = formReference;
        }

        // I had some help with this method
        // I will always give credit where credit is due.
        // https://www.fluxbytes.com/csharp/tracert-implementation-in-c/ 
        // helped me out a bunch
        private void Run()
        {
            if (ttl < 1)
            {
                MessageBox.Show("Your TTL must be greater than or equal to 1.", "Invalid TTL");
                OnTracerouteFinished();
                return;
            }
            if (timeout < 1)
            {
                MessageBox.Show("Your timeout must be greater than or equal to 1.", "Invalid timeout");
                OnTracerouteFinished();
                return;
            }
            Ping ping = new Ping();
            PingOptions pingOptions = new PingOptions(1, true);
            PingReply pingReply;
            Stopwatch pingReplyStopwatch = new Stopwatch();

            do
            {
                pingReplyStopwatch.Start(); // Start stopwatch
                pingReply = ping.Send(ip, timeout, new byte[] { 0 }, pingOptions);
                pingReplyStopwatch.Stop();

                string hostname = string.Empty;
                if (pingReply.Address != null)
                {
                    try
                    {
                        hostname = Dns.GetHostEntry(pingReply.Address).HostName;
                    }
                    catch (SocketException)
                    {
                        // Do something with this exception
                    }
                }

                formReference.AppendTextBox(
                    pingOptions.Ttl + "\t" +
                    pingReply.Status + "\t" +
                    pingReplyStopwatch.ElapsedMilliseconds + "ms\t" +
                    hostname + "\n"
                    );

                pingOptions.Ttl++;
                pingReplyStopwatch.Reset();
            } while (pingOptions.Ttl <= ttl && pingReply.Status != IPStatus.Success && running);

            OnTracerouteFinished();
        }


        public void Start()
        {
            if (ip == null)
            {
                MessageBox.Show("The IP Address you have entered is invalid! Please enter a valid IP Address and try again.",
                "Bad IP Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnTracerouteFinished();
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
        public void OnTracerouteFinished()
        {
            TracerouteFinished(this, EventArgs.Empty);
        }
    }
}
