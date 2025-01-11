using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_5_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            /*
          if (int.Parse(lblTamer.Text) == 10)
          {
              timer1.Stop();
              MessageBox.Show("Timer durdu");
          }
          else
          {
              int temp = int.Parse(lblTamer.Text);
              temp++;
              lblTamer.Text = temp.ToString();
          }
            */

           

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer3.Start();
            btnCatch.Visible = true;
            btnStart.Visible = false;
            count = 0;
        }

        bool büyüme = true;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ClientSize.Width > 1000)
            {
                büyüme=false;
            }
            else if (ClientSize.Width < 600)
            {
                büyüme = true;
            }

            if (büyüme)
            {
                ClientSize = new Size(ClientSize.Width+20, ClientSize.Height+20);
            }
            else
            {
                ClientSize = new Size(ClientSize.Width - 20, ClientSize.Height - 20);
            }
        }
        int max = 5;
        int count = 0;
        Random rnd1 = new Random();

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (count < max)
            {
                btnCatch.Location = new Point(rnd1.Next(0, ClientSize.Width), rnd1.Next(0, ClientSize.Height));
                count++;
            }
            else
            {
                timer3.Stop();
                MessageBox.Show("Yakalayamadın siktir git");
                btnCatch.Visible = false;
                btnStart.Visible = true;
            }
        }

        private void btcCatch_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            MessageBox.Show(count + " saniyede yakaladınız");
            btnCatch.Visible=false;
            btnStart.Visible=true;
            
        }
    }
    }

  

