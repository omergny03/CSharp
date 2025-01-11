using MindFusion.Charting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporcuOtomasyonu
{
    public partial class FormDetail : Form
    {
        public User user;
        private DatabaseManagement database;
        public FormDetail()
        {
            InitializeComponent();

        }

        private void FormDetail_Load(object sender, EventArgs e)
        {

            lblLoginPageName.Text = "HOŞGELDİNİZ " + user.name.ToString() + " " + user.surname.ToString();
            lblLoginPageUsername.Text = "USERNAME: " + user.username.ToString();
            lblLoginPageEmail.Text = "EMAİL: " + user.email.ToString();
            lblKcalValue.Text = "";
            database = new DatabaseManagement("sporcu3.db");

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            /* foreach(var control in Controls)
             {
                 if(control is TextBox txt )
                 {

                     if (string.IsNullOrWhiteSpace(txt.Text))
                     {
                         MessageBox.Show("boş");
                         return;

                     }

                 }
             }*/

            if (string.IsNullOrEmpty(txtKarbonhidrat.Text) || string.IsNullOrEmpty(txtProtein.Text) || string.IsNullOrEmpty(txtYag.Text))
            {
                MessageBox.Show("Boş");
                return;
            }
            double kCal = 0;
            kCal += 4 * (int.Parse(txtKarbonhidrat.Text));
            kCal += 4 * (int.Parse(txtProtein.Text));
            kCal += 9 * (int.Parse(txtYag.Text));

            lblKcalValue.Text = kCal.ToString();
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKarbonhidrat.Text) || string.IsNullOrEmpty(txtProtein.Text) || string.IsNullOrEmpty(txtYag.Text))
            {
                MessageBox.Show("Boş veri ekleyemezsin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

             await database.createTableAsync(user.username);
             database.addDataToTable(user.username, txtKarbonhidrat.Text, txtProtein.Text, txtYag.Text, lblKcalValue.Text);

            txtKarbonhidrat.Text = "";
            txtProtein.Text = "";
            txtYag.Text = "";
            lblKcalValue.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (groupBoxEat.Visible == false)
            {
                groupBoxEat.Visible = true;
                btnEkle.Text = "Kapat";
            }
            else
            {
                groupBoxEat.Visible = false;
                btnEkle.Text = "Öğün Ekle";
            }
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            if (listView1.Visible == false)
            {
                listView1.Visible = true;
                btnListe.Text = "Kapat";
                database.getEatsData(user.username, listView1);
            }
            else
            {
                listView1.Visible = false;
                btnListe.Text = "Listele";
            }

        }
       
       
        public void addChart (string table_name, BarChart barChart){
            database.getChartdata(table_name, barChart);
        }
        private void btnChart_Click(object sender, EventArgs e)
        {
            FormChart frmChart = new FormChart();
            frmChart.user = user;
            frmChart.EventAddChart += addChart;
            frmChart.ShowDialog();
        }
          
    }
}
