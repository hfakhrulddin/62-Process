using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
                p.Kill();



            Process.Start("cmd.exe");//system 32 folder programs.//1
            MessageBox.Show(Process.GetCurrentProcess().ProcessName);//2
            OpenFileDialog ofd = new OpenFileDialog();//3
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Process.Start(ofd.FileName);


            }
            Process.GetCurrentProcess().Kill();
        }
    }
}
