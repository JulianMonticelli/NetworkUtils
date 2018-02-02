using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkUtils
{
    public class MultiIPPingQuery
    {
        public delegate void MultiIPPingQueryFinishedEventHandler(object source, EventArgs args);
        public delegate void MultiIPPingQueryStatusChangedEventHandler(object source, ProgressEventArgs args);

        public event MultiIPPingQueryFinishedEventHandler MultiIPPingQueryFinished;
        public event MultiIPPingQueryStatusChangedEventHandler MultiIPPingQueryStatusChanged;

        bool _running = false;

        int _numTimes = 0;
        int _ttl = 0;
        int _timeOut = 0;
        int _buffSize = 0;
        int _pingDelay = 0;

        bool _fragmentPing = false;

        IPAddress _ip1 = null;
        IPAddress _ip2 = null;

        uint _startIP = 0;
        uint _endIP = 0;


        mainForm _formReference = null;

        public MultiIPPingQuery(String _IPAddress1, String _IPAddress2,
            int numTimes, int ttl, int timeOut, int buffSize, int pingDelay,
            bool fragmentPing, mainForm formReference)
        {
            this._ip1 = NetworkUtilities.StringToIPAddress(_IPAddress1);
            this._ip2 = NetworkUtilities.StringToIPAddress(_IPAddress2);
            this._numTimes = numTimes;
            this._ttl = ttl;
            this._timeOut = timeOut;
            this._buffSize = buffSize;
            this._pingDelay = pingDelay;
            this._fragmentPing = fragmentPing;
            this._formReference = formReference;
        }

        private void Run()
        {
            uint currentIP = _startIP;
            while (currentIP <= _endIP)
            {
                if (!_running)
                {
                    break;
                }
                IPAddress ip = NetworkUtilities.UintToIPAddress(currentIP);
                PingQuery pq = new PingQuery(ip.ToString(), _numTimes, _ttl, _timeOut,
                    _buffSize, _pingDelay, _fragmentPing, _formReference);

                pq.PingQueryFinished += OnPQFinished;
                pq.PingQueryStatusChanged += OnPQStatusChanged;

                pq.Start();

                OnMultiIPPingQueryStatusChanged(currentIP - _startIP, _endIP - _startIP);

                currentIP++;
            }
            OnMultiIPPingQueryFinished();
        }


        public void Start()
        {
            if (_ip1 == null || _ip2 == null)
            {
                MessageBox.Show("The IP Address you have entered is invalid! Please enter a valid IP Address and try again.",
                "Bad IP Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OnMultiIPPingQueryFinished();
                return;
            }
            else
            {
                _running = true;
                _startIP = Math.Min(NetworkUtilities.IPAddressToUint(_ip1),
                    NetworkUtilities.IPAddressToUint(_ip2));
                _endIP = Math.Max(NetworkUtilities.IPAddressToUint(_ip1),
                    NetworkUtilities.IPAddressToUint(_ip2));
                Run();
            }
        }

        public void Stop()
        {
            _running = false;
        }

        // The callback to let the Windows Form know that
        // the ping query is finished
        public void OnMultiIPPingQueryFinished()
        {
            MultiIPPingQueryFinished(this, EventArgs.Empty);
        }

        public void OnMultiIPPingQueryStatusChanged(uint curr, uint max)
        {
            MultiIPPingQueryStatusChanged(this, new ProgressEventArgs(curr, max));
        }

        public void OnPQFinished(object source, EventArgs ea)
        {
            // Ignore this delegate
        }

        public void OnPQStatusChanged(object source, ProgressEventArgs pea)
        {
            // Ignore this delegate
        }

    }
}
