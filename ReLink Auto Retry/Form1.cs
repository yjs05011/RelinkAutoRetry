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
            Run();
        }

        private void Run()
        {
            while(isRun)
            {             
                Console.WriteLine(isRun);
                Thread.Sleep(500);
            }
        }

        private void Stop(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                Console.WriteLine("isRun");
                isRun = false;
            }
        }
    }
}
