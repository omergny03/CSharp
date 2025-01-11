using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_5
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

        private void btnDeneme_Click(object sender, EventArgs e)
        {
            /*
            MessageBox.Show("Ömer Faruk Güney", "AD SOYAD",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {

            }
            else if (DialogResult == DialogResult.No) {
         
            }
            else
            {

            }
           */

            if (txtInput.Text == "")
            {
                MessageBox.Show("Boş bırakamazsınız", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show(txtInput.Text);
            }

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
          DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK) {
             BackColor=colorDialog.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog.ShowDialog();
            if (result == DialogResult.OK) {
                btnFont.Font = fontDialog.Font;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthdate = dateTimePicker1.Value;
            if (birthdate.Year < 1900)
            {
                MessageBox.Show("Yıl değeri 1900'den küçük olamaz", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (DialogResult==DialogResult.OK)
                {
                    dateTimePicker1.Value = new DateTime(1900, 1, 1);
                }
            } 
            else {
                txtInput.Text = birthdate.ToString();
            }
        }
    }
}
