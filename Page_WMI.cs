using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using Bunifu.Framework.UI;

namespace AVS
{
    public partial class Page_WMI : UserControl
    {
        List<PerformanceCounter> pcores;
        PerformanceCounter totalCores;
        BunifuGauge[] gauges;
        private double[] cpuArray = new double[56];
        public Page_WMI()
        {
            InitializeComponent();
            pcores = GetPerformanceCounters();
            gauges = new BunifuGauge[] { bunifuGauge2, bunifuGauge3, bunifuGauge4, bunifuGauge5 };
            totalCores = GetPerformanceTotalCounter();
            StartFunc();
        }

        private void StartFunc()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                lbNameProc.Text = string.Format("{0}\r\n", queryObj["Name"]);
            }
            

        }






        public static List<PerformanceCounter> GetPerformanceCounters()
        {
            List<PerformanceCounter> performanceCounters = new List<PerformanceCounter>();
            int procCount = Environment.ProcessorCount > 4 ? 4 : Environment.ProcessorCount;
            for (int i = 0; i < procCount; i++)
            {
                PerformanceCounter pc = new PerformanceCounter("Processor", "% Processor Time", i.ToString());
                pc.NextValue();
                performanceCounters.Add(pc);
            }
            return performanceCounters;
        }

        public static PerformanceCounter GetPerformanceTotalCounter()
        {
            PerformanceCounter ptc = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ptc.NextValue();
            return ptc;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*ManagementObjectSearcher searcher11 =
                    new ManagementObjectSearcher("root\\CIMV2",
                        "SELECT * FROM Win32_VideoController");

            foreach (ManagementObject queryObj in searcher11.Get())
            {
                var ram = queryObj.Properties["AdapterRAM"].Value as UInt32?;

                textBox1.Text = "----------- Win32_VideoController instance ----------- \r\n" +
                                string.Format("AdapterRAM: {0} \r\n", ram / 1024 / 1024) +
                                string.Format("Caption: {0} \r\n", queryObj["Caption"]) +
                                string.Format("Description: {0} \r\n", queryObj["Description"]) +
                                string.Format("VideoProcessor: {0} \r\n", queryObj["VideoProcessor"]);
            }*/

            for (int i = 0; i < pcores.Count; i++)
            {
                float result_cpu = pcores[i].NextValue();
                gauges[i].Value = (int)result_cpu;
            }

            float cp = totalCores.NextValue();
            bunifuGauge1.Value = (int)cp;

            cpuArray[cpuArray.Length - 1] = Math.Round(cp, 0);
            Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);

            if (cpuChart.IsHandleCreated)
            {
                Invoke((MethodInvoker)UpdateCpuChard);
            }
        }

        private void UpdateCpuChard()
        {
            cpuChart.Series["Series1"].Points.Clear();

            for (int i = 0; i < cpuArray.Length - 1; i++)
            {
                cpuChart.Series["Series1"].Points.AddY(cpuArray[i]);
            }
        }


    }


}
