using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkUtils
{
    public class StressTest
    {
        public delegate void StressTestFinishedEventHandler(object source, EventArgs args);

        public event StressTestFinishedEventHandler StressTestFinished;

        private bool running = false;
        private bool isUDP = false; // True = UDP, False = TCP
        private int packetLimit = 0;
        private long packetDelay = 0; // Delay in MS
        private string packetContents = "";
        private int port = 0;
        private int iterator = 0;
        private mainForm formReference;
        IPAddress ip = null;

        public StressTest(bool isUDP, int packetLimit, long packetDelay,
            string packetContents, int port, String _IPAddress, mainForm formReference)
        {
            this.isUDP = isUDP;
            this.packetLimit = packetLimit;
            this.packetDelay = packetDelay;
            this.packetContents = packetContents;
            this.port = port;
            this.formReference = formReference;
            ip = NetworkUtilities.StringToIPAddress(_IPAddress);

            // Packet limit <= 0 will result in an infinite loop
            if (packetLimit > 0)
            {
                iterator = 1;
            }
            else
            {
                this.packetLimit = 1;
            }
        }

        public void Run()
        {
            // Use correct protocol type
            ProtocolType protocolType = ProtocolType.Tcp;
            if (isUDP) protocolType = ProtocolType.Udp;

            IPEndPoint ipep = new IPEndPoint(ip, port);
            Socket sock = null;
            try
            {
                if (isUDP)
                    sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
                        protocolType);
                else
                {
                    sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                        protocolType);
                    sock.Connect(ip, port);
                }
            }
            catch (System.Exception e)
            {
                formReference.AppendTextBox(e.StackTrace);
                OnStressTestFinished();
                return;
            }
            byte[] buffer = Encoding.ASCII.GetBytes(packetContents.ToCharArray());
            for (int i = 0; i < packetLimit; i += iterator)
            {
                if (!running)
                {
                    break;
                }
                // Fire-and-forget :)
                sendPacket(ipep, buffer, sock);
            }
            OnStressTestFinished();
        }

        public void Start()
        {
            if (ip == null)
            {
                MessageBox.Show("The IP Address you have entered is invalid! Please enter a valid IP Address and try again.",
                "Bad IP Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnStressTestFinished();
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

        public void sendPacket(IPEndPoint ipep, byte[] buffer, Socket sock)
        {
            try
            {
                sock.SendTo(buffer, ipep);
            }
            catch (SocketException e)
            {
                formReference.AppendTextBox(e.StackTrace);
            }
        }

        private void OnStressTestFinished()
        {
            StressTestFinished(this, EventArgs.Empty);
        }

    }
}