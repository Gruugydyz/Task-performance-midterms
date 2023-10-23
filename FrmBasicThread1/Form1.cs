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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Thread ThreadA, ThreadB, ThreadC, ThreadD;
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart start1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart start2 = new ThreadStart(MyThreadClass.Thread2);    
            ThreadA = new Thread(start1);
            ThreadB = new Thread(start2);
            ThreadC = new Thread(start1);
            ThreadD = new Thread(start2);

            ThreadA.Name = "Thread A Process ";
            ThreadB.Name = "Thread B Process ";
            ThreadC.Name = "Thread C Process ";
            ThreadD.Name = "Thread D Process ";
            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;
            Console.WriteLine(label1.Text.ToString());

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();
            label1.Text = "-End of Thread-";
            Console.WriteLine(label1.Text.ToString());


        }
    }
}
