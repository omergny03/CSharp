using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           if((!string.IsNullOrEmpty(txtName.Text)) && (!string.IsNullOrEmpty(txtEmail.Text)))
            {
                string info = txtName.Text+" , "+ txtEmail.Text;
                listBox1.Items.Add(info);
                txtName.Text ="";
                txtEmail.Text = "";
            }
            else
            {
                MessageBox.Show("değer giriniz");
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\omerg\OneDrive\Masaüstü\pilots.txt");
            foreach (string line in listBox1.Items)
            {
                streamWriter.WriteLine(line);  
            }
            streamWriter.Close();
            listBox1.Items.Clear();
        }
        
        private void boxes(object sender, EventArgs e)
        {
            if(sender is CheckBox box && box.Checked)
            {
                listBox1.Items.Add(box.Text);
            }
            if (sender is CheckBox box1 && (!box1.Checked))
            {
                listBox1.Items.Remove(box1.Text);
            }
        }

        private void groupRadioButtons(object sender,EventArgs e)
        { 

            if(sender is RadioButton radioButton && radioButton.Checked)
            {
                Console.WriteLine(radioButton.Text);
            }
        }

  
    }
}
