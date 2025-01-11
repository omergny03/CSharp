using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week5_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            lblTime.Text= count.ToString();
            progressBar1.Maximum = 60;
            progressBar1.Step = 6;
        }

        int count = 10;
        Random rnd = new Random();  
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count != 0)
            {
                btnCatch.Location = new Point(rnd.Next(0,ClientSize.Width),rnd.Next(0,ClientSize.Height));

            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Başaramadın");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            count--;
            lblTime.Text = count.ToString();
        }

        private void btnCatch_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            MessageBox.Show("TEbrikler");
           
        }
    }
}
