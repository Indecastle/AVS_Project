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

namespace AVS
{
    public partial class Ram : UserControl
    {
        private PerformanceCounter ramCounter;
        public double ramSizeTotal, ramSizeUsed, ramSizeFree;
        private double[] ramArray = new double[56];

        public Ram()
        {
            InitializeComponent();
            StartFunc();
        }

        private void StartFunc()
        {
            ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);
            ramCounter.NextValue();

            ramSizeTotal = getRAMsize();
            ramChart.ChartAreas[0].AxisY.Maximum = ramSizeTotal;
            ramChart.ChartAreas[0].AxisY.Minimum = 0;
            label6.Text = String.Format("Total : {0}", ramSizeTotal);

            ManagementObjectSearcher searcher12 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject queryObj in searcher12.Get())
            {
                var MemoryName = queryObj.Properties["Manufacturer"].Value as string;
                var MemorySpeed = queryObj.Properties["Speed"].Value as UInt32?;

                //label2.Text = String.Format("Memory: {0}", MemoryName.Replace(" ", ""));
                label2.Text = String.Format("Memory: {0}", "Kingston");
                label3.Text = String.Format("frequency : {0}", MemorySpeed);
            }
        }

        private double getRAMsize()
        {
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject item in moc)
            {
                return Math.Round(Convert.ToDouble(item.Properties["TotalPhysicalMemory"].Value) / 1048576, 0);
            }

            return 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ramSizeFree = ramCounter.NextValue();
            ramSizeUsed = ramSizeTotal - ramSizeFree;
            label4.Text = String.Format("Used : {0}", ramSizeUsed);
            label5.Text = String.Format("Free : {0}", ramSizeFree);
            bunifuCircleProgressbar1.Value = (int)((ramSizeUsed / ramSizeTotal)*100);

            ramArray[ramArray.Length - 1] = ramSizeUsed;
            Array.Copy(ramArray, 1, ramArray, 0, ramArray.Length - 1);

            if (ramChart.IsHandleCreated)
            {
                Invoke((MethodInvoker)UpdateCpuChard);
            }
        }

        private void UpdateCpuChard()
        {
            ramChart.Series["Series1"].Points.Clear();

            for (int i = 0; i < ramArray.Length - 1; i++)
            {
                ramChart.Series["Series1"].Points.AddY(ramArray[i]);
            }
        }
    }
}
