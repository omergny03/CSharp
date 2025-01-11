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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void radioChange(object sender,EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                lblResult.Text=radio.Text;
            }
        }

        private void btnShowIcon_Click(object sender, EventArgs e)
        {

            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(4000, "Error", "Hata mesajı",ToolTipIcon.Warning);
        }
    }
}
