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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                DialogResult result2 =MessageBox.Show("Değiştirmek istediğinize emin misiniz?","Önemli",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (result2 == DialogResult.OK)
                {
                    btnFont.Font = fontDialog.Font;
                    btnColor.Font = fontDialog.Font;
                }
               
            }
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            dateTimePicker.Visible = true;
            btnSave.Visible = true;
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            if (date.Year < 2023)
            {
                MessageBox.Show("siktir git");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TabPage tabpage = new TabPage();
            tabpage.Text = "deneme";
            Label label = new Label();
            DialogResult result = fontDialog.ShowDialog();
            if (result == DialogResult.OK) {
                label.Text = "Köse";
                label.Font = fontDialog.Font;
            }

            tabpage.Controls.Add(label);
            tabControl.TabPages.Add(tabpage);
            tabControl.SelectedIndex = 2;
        
        }


    }
}
