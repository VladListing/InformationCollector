using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Management;


namespace SizeOfTheDisks
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();


            //DriveInfo[] allDrives = DriveInfo.GetDrives();


            //foreach (DriveInfo d in allDrives)
            //{
            //    textBox1.Text += d.Name.ToString() + Environment.NewLine;

            //    textBox1.Text += "  Drive type: " + d.DriveType.ToString() + Environment.NewLine;

            //    if (d.IsReady == true)
            //    {
            //        textBox1.Text += "  Volume label: " + d.VolumeLabel.ToString() + Environment.NewLine;

            //        textBox1.Text += "  File system: " + d.DriveFormat.ToString() + Environment.NewLine;

            //        textBox1.Text += "  Available space to current user: " + (d.AvailableFreeSpace / 1048576.0).ToString() + Environment.NewLine;

            //        textBox1.Text += "  Total available space:  " + (d.TotalFreeSpace / 1048576.0).ToString() + Environment.NewLine;

            //        textBox1.Text += "  Total size of drive:  " + (d.TotalSize / 1048576.0).ToString() + Environment.NewLine;

            //    }

            //    textBox1.Text += Environment.NewLine;
            //}


            ManagementScope scope = new ManagementScope("\\\\192.168.1.14\\root\\cimv2");
            //scope.Connect();
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            SelectQuery query1 = new SelectQuery("Select * from Win32_LogicalDisk");
            SelectQuery query2 = new SelectQuery("Select FreeSpace from Win32_LogicalDisk WHERE Name='C:'");

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            ManagementObjectCollection queryCollection = searcher.Get();

            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher(scope, query1);
            ManagementObjectCollection queryCollection1 = searcher1.Get();

            foreach (ManagementObject m in queryCollection)
            {
                // Display the remote computer information  
                //Console.WriteLine("Computer Name : {0}", m["csname"]);
                textBox1.Text += "  Computer Name :  " + (m["csname"].ToString()) + Environment.NewLine;

                //Console.WriteLine("Windows Directory : {0}", m["WindowsDirectory"]);
                textBox1.Text += "  Windows Directory :  " + (m["WindowsDirectory"].ToString()) + Environment.NewLine;
                //Console.WriteLine("Operating System: {0}", m["Caption"]);
                //Console.WriteLine("Version: {0}", m["Version"]);
                //Console.WriteLine("Manufacturer : {0}", m["Manufacturer"]);
                //Console.WriteLine();
            }

            textBox1.Text += Environment.NewLine;

            foreach (ManagementObject mo in queryCollection1)
            {
                // Display Logical Disks information 
                //Console.WriteLine();

                //Console.WriteLine("              Disk Name : {0}", mo["Name"]);
                textBox1.Text += "  Disk Name :  " + (mo["Name"].ToString()) + Environment.NewLine;


                //Console.WriteLine("              Disk Size : {0}", mo["Size"]);
                //textBox1.Text += "  Disk Size  :  " + (mo["Size"].ToString()) + Environment.NewLine;



                //Console.WriteLine("              FreeSpace : {0}", mo["FreeSpace"]);
                //textBox1.Text += "  FreeSpace :  " + (mo["FreeSpace"].ToString()) + Environment.NewLine;

                //Console.WriteLine("          Disk DeviceID : {0}", mo["DeviceID"]);
                textBox1.Text += "  Disk Name :  " + (mo["DeviceID"].ToString()) + Environment.NewLine;

                //Console.WriteLine("        Disk VolumeName : {0}", mo["VolumeName"]);
                //textBox1.Text += "  Disk VolumeName  :  " + (mo["VolumeName"].ToString()) + Environment.NewLine;

                //Console.WriteLine("        Disk SystemName : {0}", mo["SystemName"]);
                textBox1.Text += "  Disk Name :  " + (mo["SystemName"].ToString()) + Environment.NewLine;



                //Console.WriteLine("Disk VolumeSerialNumber : {0}", mo["VolumeSerialNumber"]);
                //textBox1.Text += "  Disk Name :  " + (mo["VolumeSerialNumber"].ToString()) + Environment.NewLine;

            }




        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        //public Info()
        //{
        //    InitializeComponent();


           // public static void GetCompParametersAndDiskspaceThroughWMI() 
           // {
           // ManagementScope scope = new ManagementScope("\\\\192.168.1.14\\root\\cimv2");
           // scope.Connect();
           // ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
           // SelectQuery query1 = new SelectQuery("Select * from Win32_LogicalDisk");
           // SelectQuery query2 = new SelectQuery("Select FreeSpace from Win32_LogicalDisk WHERE Name='C:'");

           // ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
           // ManagementObjectCollection queryCollection = searcher.Get();

           // ManagementObjectSearcher searcher1 = new ManagementObjectSearcher(scope, query1);
           // ManagementObjectCollection queryCollection1 = searcher1.Get();

           // foreach (ManagementObject m in queryCollection)
           // {
           //     // Display the remote computer information  
           //     //Console.WriteLine("Computer Name : {0}", m["csname"]);
           //     textBox1.Text += "  Computer Name :  " + (m["csname"].ToString()) + Environment.NewLine;

           //     //Console.WriteLine("Windows Directory : {0}", m["WindowsDirectory"]);
           //     //Console.WriteLine("Operating System: {0}", m["Caption"]);
           //     //Console.WriteLine("Version: {0}", m["Version"]);
           //     //Console.WriteLine("Manufacturer : {0}", m["Manufacturer"]);
           //     //Console.WriteLine();
           // }

           // foreach (ManagementObject mo in queryCollection1)
           // {
           //     // Display Logical Disks information 
           //     Console.WriteLine();
           //     Console.WriteLine("              Disk Name : {0}", mo["Name"]);
           //     Console.WriteLine("              Disk Size : {0}", mo["Size"]);
           //     Console.WriteLine("              FreeSpace : {0}", mo["FreeSpace"]);
           //     Console.WriteLine("          Disk DeviceID : {0}", mo["DeviceID"]);
           //     Console.WriteLine("        Disk VolumeName : {0}", mo["VolumeName"]);
           //     Console.WriteLine("        Disk SystemName : {0}", mo["SystemName"]);
           //     Console.WriteLine("Disk VolumeSerialNumber : {0}", mo["VolumeSerialNumber"]);
           // }
           //}

           

    }
}
