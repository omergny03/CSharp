using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_5_TabControlUygulaması
{
    public partial class Form1 : Form
    {   
        ArrayList list = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           if(txtLoginName.Text!="" && txtLoginPassword.Text!="")  //passwordChar özelliği * yaptı.
            {
                bool userFound = false;
                int i = 2;
                foreach (Person item in list)
                {
                  if(item.Kullanici_Name==txtLoginName.Text && item.Password == txtLoginPassword.Text)
                    {
                        TabPage tabpage = new TabPage();
                        tabpage.Text = item.Kullanici_Name;

                        Label label = new Label();
                        label.Text= item.ToString();
                        label.Width = 350;

                        tabpage.Controls.Add(label);
                        tabControl.TabPages.Add(tabpage);
                        tabControl.SelectedIndex = i;
                        i++;
                        
                        userFound = true;  
                        break;
                    }
                     
                }

                if (!userFound)
                {
                    MessageBox.Show("Kullanıcı bulunamadı");
                    txtLoginName.Text = "";
                    txtLoginPassword.Text = "";
                }


            }
            else
            {
                DialogResult result =MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (result == DialogResult.OK) {
                    txtLoginName.Text = "";
                    txtLoginPassword.Text = "";
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(txtSignUpName.Text!=""&& txtSignUpPassword.Text!=""&& txtSignUpEmail.Text != "")
            {
                Person temp = new Person(txtSignUpName.Text, txtSignUpEmail.Text, txtSignUpPassword.Text);
                list.Add(temp);
                DialogResult result = MessageBox.Show("Başarıyla eklendi", "Succesfull",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    txtSignUpName.Text = "";
                    txtSignUpPassword.Text = "";
                    txtSignUpEmail.Text = "";
                    Console.WriteLine(temp.ToString());
                }
                
            }
            else
            {
                DialogResult result = MessageBox.Show("Değerleri boş bırakamazsın", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK) {
                    txtSignUpName.Text = "";
                    txtSignUpPassword.Text = "";
                    txtSignUpEmail.Text = "";
                    
                }
            }
        }
    }
}
