using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ReLink_Auto_Retry
{

    public partial class Form1 : Form
    {
        private bool isRun = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void StartBtn_Click(object sender, EventArgs e)
        {
            isRun = true;
            Program.CheckKey = false;

            Console.WriteLine(Program.filePath);

            Run();
        }

        private async void Run()
        {
            var task = Task.Run(() =>
            {
                while (isRun)
                {
                    if (Program.CheckKey)
                    {
                        isRun = false;
                    }
                    SendKeys.SendWait("a");
                    Console.WriteLine("working");
                    Thread.Sleep(500);
                    
                }
                
            });
        }

    }
}
