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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDrop.Text))
            {
                if (comboBox1.Items.Contains(txtDrop.Text))
                {
                    MessageBox.Show("Bu değer zaten var");
                }
                else
                {
                    comboBox1.Items.Add(txtDrop.Text);
                    txtDrop.Text = "";
                    comboBox1.DroppedDown = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
            comboBox1.MaxDropDownItems = 1;

            StreamReader streamReader = new StreamReader(@"C:\Users\omerg\OneDrive\Masaüstü\pilots.txt");
            string line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
            streamReader.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                lblDrop.Text = comboBox1.SelectedItem.ToString();
                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = comboBox1.Items.IndexOf(txtDrop.Text);
            if (index == -1)
            {
                MessageBox.Show("Değer bulunmadı");
            }
            else
            {
                comboBox1.Items.RemoveAt(index);
            }
             
        
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            }
            else
            {
                comboBox1.SelectedIndex--;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= comboBox1.Items.Count - 1)
            {
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex++;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("index: "+comboBox1.SelectedIndex+"\ndeğer: "+comboBox1.Text);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox2.Text)) {

                if (listBox1.Items.Contains(comboBox2.SelectedItem))
                {
                    MessageBox.Show("zaten bir hesabın var mı ");
                }
                else
                {
                    listBox1.Items.Add(comboBox2.SelectedItem);
                }
            
            }
        }
    }
}
