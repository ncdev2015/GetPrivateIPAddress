using System;
using System.Net;

namespace GetPrivateIPAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetIPAddress());
        }
        public static string GetIPAddress()
        {
            string IPAddress = "";
            IPAddress[] IPAdresses = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (var IP in IPAdresses)
            {
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPAddress = IP.ToString();
                }
            }

            return IPAddress;
        }
    }
}
