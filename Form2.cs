using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using ArpLookup;


namespace TableComparator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BFillTable_Click(object sender, EventArgs e)
        {

        }










        //public class NextHopMacAddress
        //{
        //    public static PhysicalAddress GetNextHopMacAddress(IPAddress destinationIpAddress)
        //    {
        //        // Get the local machine's ARP table
        //        var arpTable = new ArpTable();

        //        // Find the MAC address associated with the destination IP address
        //        var nextHopMacAddress = arpTable.GetMacAddress(destinationIpAddress);

        //        return nextHopMacAddress;
        //    }
        //}

        //public class ArpTable
        //{
        //    public PhysicalAddress GetMacAddress(IPAddress ipAddress)
        //    {
        //        // Query the ARP table for the MAC address associated with the IP address
        //        var arpTableEntry = GetArpTableEntry(ipAddress);

        //        // Return the MAC address if found, otherwise return null
        //        return arpTableEntry?.PhysicalAddress;
        //    }

        //    private static ArpTableEntry GetArpTableEntry(IPAddress ipAddress)
        //    {
        //        // Query the ARP table for the entry associated with the IP address
        //        var arpTable = new NetworkInterface().GetAllArpEntries();

        //        // Find the entry with the matching IP address
        //        var arpTableEntry = arpTable.FirstOrDefault(entry => entry.IpAddress.Equals(ipAddress));

        //        return arpTableEntry;
        //    }
        //}


    }
}
