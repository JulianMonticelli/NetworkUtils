using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkUtils
{
    public class NetworkUtilities
    {
        public static IPAddress StringToIPAddress(String _IPAddress)
        {
            IPAddress ip = null;
            try
            {
                ip = IPAddress.Parse(_IPAddress);
            }
            catch
            {
                // No need to do anything here.
                // We're returning null if there's a problem.
            }
            return ip;
        }

        public static uint IPAddressToUint(IPAddress ip)
        {
            uint uIP = 0;

            byte[] bytes = ip.GetAddressBytes();

            for (int i = 0; i < 4; i++)
            {
                uIP += ((uint)bytes[i]) << (3-i) * 8;
            }

            return uIP;
        }

        public static IPAddress UintToIPAddress(uint ip)
        {
            byte[] bytes = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                byte b = (byte)((ip >> ((3-i) * 8)) & 0xFF);
                bytes[i] = b;
            }

            IPAddress ipAddr = new IPAddress(bytes);

            return ipAddr;
        }
    }
}
