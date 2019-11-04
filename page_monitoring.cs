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
            MyGridView1.Columns[0].ValueType = typeof(int);
            MyGridView1.Columns[2].ValueType = typeof(double);
            MyGridView1.Columns[3].ValueType = typeof(long);
            MyRun2();
        }

        private void MyRun2()
        {
            //AsyncCalc();
        }

        private Task<DataGridViewRow[]> AsyncCalc2()
        {
            return Task.Run(async () =>
            {
                var processes = Process.GetProcesses();
                int count = processes.Length < 50 ? processes.Length : 50;
                PerformanceCounter[] countersCpu = new PerformanceCounter[count];
                PerformanceCounter[] countersRam = new PerformanceCounter[count];
                DataGridViewRow[] listrows = new DataGridViewRow[count];

                for (int i = 0; i < count; i++)
                {
                    countersCpu[i] = new PerformanceCounter("Process", "% Processor Time", processes[i].ProcessName, true);
                    countersRam[i] = new PerformanceCounter("Process", "Private Bytes", processes[i].ProcessName, true);
                }
                for (int i = 0; i < count; i++)
                {
                    countersCpu[i].NextValue();
                    countersRam[i].NextValue();
                }
                await Task.Delay(1000);
                for (int i = 0; i < count; i++)
                {
                    // If system has multiple cores, that should be taken into account
                    double result_cpu = Math.Round(countersCpu[i].NextValue() / Environment.ProcessorCount, 2);
                    // Returns number of MB consumed by application
                    double result_ram = Math.Round(countersRam[i].NextValue() / 1024, 2);

                    listrows[i] = MyGridView1.Get_Row(processes[i].Id, processes[i].ProcessName, result_cpu, result_ram);
                }
                return listrows;
            });

        }

        private void page_monitoring_SizeChanged(object sender, EventArgs e)
        {
            MyGridView1.Height = Height - MyGridView1.Location.Y - 1;
            MyGridView1.Width = Width - MyGridView1.Location.X - 1;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            DataGridViewRow[] listrows = await AsyncCalc2();

            MyGridView1.Rows.Clear();
            MyGridView1.Rows.AddRange(listrows);
            MyGridView1.Sort(MyGridView1.Columns[2], ListSortDirection.Descending);
        }
    }


    public static class Extend_DataGrid
    {
        public static void Add_Item(this DataGridViewRowCollection rows, int id, string name, double cpi, double ram)
        {
            int n = rows.Add();
            rows[n].Cells[0].Value = id;
            rows[n].Cells[1].Value = name;
            rows[n].Cells[2].Value = cpi;
            rows[n].Cells[3].Value = ram;
        }

        public static DataGridViewRow Get_Row(this DataGridView table, int id, string name, double cpi, double ram)
        {
            var row = new DataGridViewRow();
            row.CreateCells(table, id, name, cpi, ram);
            return row;
        }
    }
}
