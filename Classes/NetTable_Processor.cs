using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TableComparator.Classes
{
    internal static class NetTable_Processor
    {
        private static void FillTable()
        {
            foreach ( var nic in NetworkInterface.GetAllNetworkInterfaces()
                .Where(nic => nic.OperationalStatus == OperationalStatus.Up
                && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback))
            {
                var ips = nic.GetIPProperties().UnicastAddresses
                    .Where(adr => adr.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    .Select(adr => adr.Address.ToString());
                Console.WriteLine($"{string.Join(", ", ips)} {nic.GetPhysicalAddress()} {nic.Name}");
            }
        }

    }
}
