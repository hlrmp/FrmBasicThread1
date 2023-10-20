using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicThread1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RUN_Click(object sender, EventArgs e)
        {
            Console.WriteLine("- Before Starting Thread -");

            ThreadStart delthread = new ThreadStart(MyThreadClass.Thread1);

            Thread ThreadA = new Thread(delthread);
            ThreadA.Name = "Thread A process = ";


            Thread ThreadB = new Thread(delthread);
            ThreadB.Name = "Thread A process = ";


            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();



            Console.WriteLine("- End of Thread -");

            label1.Text = " - End of Thread - ";
        }
    }
}
