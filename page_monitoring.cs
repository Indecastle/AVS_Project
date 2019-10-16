using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Dynamic;

namespace AVS
{
    public partial class page_monitoring : UserControl
    {
        public page_monitoring()
        {
            InitializeComponent();
            MyRun2();
        }


        private async void MyRun2()
        {
            await Task.Run(AsyncCalc);
        }


        private async void AsyncCalc()
        {
            while (true) 
            {
                var processes = Process.GetProcesses();
                var rows = new DataGridViewRowCollection(GridView1);
                foreach (var process in processes)
                {
                    var cpu = new PerformanceCounter("Process", "% Processor Time", process.ProcessName, true);
                    var ram = new PerformanceCounter("Process", "Private Bytes", process.ProcessName, true);
                    cpu.NextValue();
                    ram.NextValue();

                    // If system has multiple cores, that should be taken into account
                    double result_cpu = Math.Round(cpu.NextValue() / Environment.ProcessorCount, 2);
                    // Returns number of MB consumed by application
                    double result_ram = Math.Round(ram.NextValue() / 1024, 2);

                    rows.Add_item(process.Id, process.ProcessName, result_cpu, result_ram);
                }
                GridView1.Rows.Clear();
                GridView1.Rows.Add(rows);
                await Task.Delay(1000);
            }
            
        }

        private void GetProcess(TextBox textBox, PerformanceCounter cpu, PerformanceCounter ram)
        {
            textBox.Text = textBox.Text + "\r\nEnd";

            dynamic result = new ExpandoObject();

            // If system has multiple cores, that should be taken into account
            result.CPU = Math.Round(cpu.NextValue() / Environment.ProcessorCount, 2);
            // Returns number of MB consumed by application
            result.RAM = Math.Round(ram.NextValue() / 1024, 2);

            textBox.Text = $"CPU: {result.CPU} ## {cpu.RawValue / Environment.ProcessorCount} \r\nRAM: {result.RAM} ## {ram.RawValue / 1024}";
        }
    }


    public static class Extend_DataGrid
    {
        public static void Add_item(this DataGridViewRowCollection rows, int id, string name, double cpi, double ram)
        {
            int n = rows.Add();
            rows[n].Cells[0].Value = id;
            rows[n].Cells[1].Value = name;
            rows[n].Cells[2].Value = cpi;
            rows[n].Cells[3].Value = $"{ram} kb";
        }
    }
}
