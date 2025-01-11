using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       
        private void sizeMode(object sender, EventArgs e)
        {
            if(sender is RadioButton radioButton && radioButton.Checked && radioButton.Parent is GroupBox gb)
            {
                if (gb.Name == "groupBox1")
                {
                    if (radioButton.Name== "radioBtnNormal")
                    {
                        pictureBox1.SizeMode=PictureBoxSizeMode.Normal;
                    
                    }else if (radioButton.Name == "radioBtnAutoSize")
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    }
                    else if (radioButton.Name == "radioBtnStretchImage")
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else if (radioButton.Name == "radioBtnZoom")
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
