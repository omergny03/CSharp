using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporcuOtomasyonu
{
    public partial class Form1 : Form
    {
        private DatabaseManagement database;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             database = new DatabaseManagement("sporcu3.db");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        { 
            if(string.IsNullOrEmpty(txtRegisterUsername.Text) || string.IsNullOrEmpty(txtRegisterEmail.Text) || string.IsNullOrEmpty(txtRegisterPassword.Text) || string.IsNullOrEmpty(txtRegisterName.Text) || string.IsNullOrEmpty(txtRegisterSurname.Text))
            {
                MessageBox.Show("hepsini giriniz");
                return;
            }
          
            database.addUserToDatabase(txtRegisterUsername.Text, txtRegisterEmail.Text, txtRegisterPassword.Text,txtRegisterName.Text,txtRegisterSurname.Text);
            txtRegisterUsername.Text = "";
            txtRegisterEmail.Text = "";
            txtRegisterPassword.Text = "";
            txtRegisterName.Text = "";
            txtRegisterSurname.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoginUsername.Text) || string.IsNullOrEmpty(txtLoginPassword.Text))
            {
                return;
            }
            database.login(txtLoginUsername.Text, txtLoginPassword.Text);
            txtLoginUsername.Text = "";
            txtLoginPassword.Text = "";
        }

    
   
    }
}
