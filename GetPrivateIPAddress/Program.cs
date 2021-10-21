using System;
using System.Net;

namespace GetPrivateIPAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            string IPAddress = GetIPAddress();
            System.Console.WriteLine(IPAddress);
            Console.ReadLine();
        }
        public static string GetIPAddress()
        {
            string IPAddress = string.Empty;
            IPHostEntry Host = default(IPHostEntry);
            string Hostname = null;
            Hostname = System.Environment.MachineName;
            Host = Dns.GetHostEntry(Hostname);
            foreach (IPAddress IP in Host.AddressList)
            {
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPAddress = Convert.ToString(IP);
                }
            }
            return IPAddress;
        }
    }
}
