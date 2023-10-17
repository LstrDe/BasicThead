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

namespace BscThead
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

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");
            ThreadStart thread = new ThreadStart(MyThreadClass.Thread1);
            Thread ThreadA = new Thread(thread);
            Thread ThreadB = new Thread(thread);
            ThreadA.Start();
            ThreadA.Name = "Thread A Process ";
            ThreadB.Start();
            ThreadB.Name = "Thread B Process ";
            ThreadA.Join();
            ThreadB.Join();
            Console.WriteLine(" -End of Thread-");
            label1.Text = " -End of Thread-";
        }
    }
}
