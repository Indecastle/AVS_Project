using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Dynamic;

namespace AVS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Process[] processlist = Process.GetProcesses();

            //GetProcess(textBox1, 500);

            /*foreach (Process theprocess in processlist)
            {
                Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
            }*/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //GetProcess();
        }

        /*private async void MyRun()
        {
            while (true)
            {
                Task task1 = Task.Run(async () => GetProcess(textBox1, 500));
                Task task2 = Task.Run(async () => GetProcess(textBox2, 100));
                Task.WaitAll(task1, task2);
                await Task.Delay(700);
            }
        }*/

        private async void MyRun2()
        {
            var process = Process.GetCurrentProcess();

            // Preparing variable for application instance name
            var name = string.Empty;

            foreach (var instance in new PerformanceCounterCategory("Process").GetInstanceNames())
            {
                if (instance.StartsWith(process.ProcessName))
                {
                    using (var processId = new PerformanceCounter("Process", "ID Process", instance, true))
                    {
                        if (process.Id == (int)processId.RawValue)
                        {
                            name = instance;
                            break;
                        }
                    }
                }
            }

            var cpu = new PerformanceCounter("Process", "% Processor Time", name, true);
            var ram = new PerformanceCounter("Process", "Private Bytes", name, true);

            // Getting first initial values
            cpu.NextValue();
            ram.NextValue();



            Task task1 = Task.Run(async () =>
            {
                while (true) {
                    GetProcess(textBox1, cpu, ram);
                    await Task.Delay(700);
                }
                
            });

            Task task2 = Task.Run(async () =>
            {
                while (true)
                {
                    GetProcess(textBox2, cpu, ram);
                    await Task.Delay(200);
                }
            });
        }


        private void GetProcess(TextBox textBox, PerformanceCounter cpu, PerformanceCounter ram)
        {
            textBox.Text = textBox.Text + "\r\nEnd";

            dynamic result = new ExpandoObject();

            // If system has multiple cores, that should be taken into account
            result.CPU = Math.Round(cpu.NextValue() / Environment.ProcessorCount, 2);
            // Returns number of MB consumed by application
            result.RAM = Math.Round(ram.NextValue() / 1024, 2);

            textBox.Text = $"CPU: {result.CPU} ## {cpu.RawValue / Environment.ProcessorCount} \r\nRAM: {result.RAM} ## {ram.RawValue/1024}";
        }

        Bunifu.Framework.UI.Drag MoveForm { get; set; } = new Bunifu.Framework.UI.Drag();
        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm.Grab(this);
        }

        private void header_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm.Release();
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm.MoveObject();
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(sidemenu.Width >= 200)
            {
                pictureBox1.Location = new Point(8, 55);
                pictureBox1.Size = new Size(35, 36);
                sidemenu.Width = 50;
                label1.Visible = false;
            }
            else
            {
                pictureBox1.Location = new Point(50, 15);
                pictureBox1.Size = new Size(79, 65);
                sidemenu.Width = 200;
                label1.Visible = true;
            }
        }
    }
}
