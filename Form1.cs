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

namespace CPU_Monitor
{
    public partial class Form1 : Form
    {

        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfMemCounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter perfSystemCounter = new PerformanceCounter("System", "System Up Time");

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = "CPU:" + "                           " + (int)perfCPUCounter.NextValue() + " " + "%";
            label2.Text = "Available Memory:" + "    " + (int)perfMemCounter.NextValue() + " " + "MB";
            label3.Text = "System Up Time:" + "      " + (int)perfSystemCounter.NextValue() / 60 / 60 + " " + "Hours";
        }
    }
}
