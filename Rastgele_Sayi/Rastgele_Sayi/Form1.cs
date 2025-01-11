using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rastgele_Sayi
{
    public partial class Form1 : Form
    {

        private int _randomSayi;
        private int _tahmin;
        private int _count=5;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTahmin.Text != "")
            {
                _tahmin=int.Parse(txtTahmin.Text);
                Console.WriteLine(_tahmin);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTahmin.Text = "";
            Random rnd = new Random();
            _randomSayi = rnd.Next(0,101);
            Console.WriteLine(_randomSayi);
          
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            if (_count > 0)
            {   
                _count--;
                if (_tahmin == _randomSayi)
                {
                    MessageBox.Show("Cevabınız Doğru");
                }
                else if (_tahmin > _randomSayi)
                {
                    Console.WriteLine("daha düşük bir sayı giriniz");
                    lblKalanHak.Text = "Kalan hak " + _count;
                    if(_count == 0)
                    {
                        MessageBox.Show("Doğru cevabı bulamadınız");
                    }
                }
                else
                {
                    Console.WriteLine("daha yüksek bir sayı giriniz");
                    lblKalanHak.Text = "Kalan hak " + _count;
                    if (_count == 0)
                    {
                        MessageBox.Show("Doğru cevabı bulamadınız");
                    }
                }
            }
        
        }
    }
}
