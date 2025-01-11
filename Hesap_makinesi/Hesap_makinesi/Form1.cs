using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_makinesi
{
    public partial class Hesap_Makinesi : Form
    {
        private char _islem;
        private bool _ekranTemizleme;
        private int _ilkSayi;
        public Hesap_Makinesi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
            {
                lblResult.Text = "";
                _ekranTemizleme = false;
            }
            if (lblResult.Text == "0")
            {
                lblResult.Text = "1";
            }
            else
            {
                lblResult.Text= lblResult.Text+ "1";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
            {
                lblResult.Text = "";
                _ekranTemizleme = false;
            }
            if (lblResult.Text=="0")
            {
                lblResult.Text = "2";
            }
            else
            {
                lblResult.Text = lblResult.Text + "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
            {
                lblResult.Text = "";
                _ekranTemizleme = false;
            }
            if (lblResult.Text == "0")
            {
                lblResult.Text = "3";
            }
            else
            {
                lblResult.Text = lblResult.Text + "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
            {
                lblResult.Text = "";
                _ekranTemizleme = false;
            }
            if (lblResult.Text == "0")
            {
                lblResult.Text = "4";
            }
            else
            {
                lblResult.Text = lblResult.Text + "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
            {
                lblResult.Text = "";
                _ekranTemizleme = false;
            }
            if (lblResult.Text == "0")
            {
                lblResult.Text = "5";
            }
            else
            {
                lblResult.Text = lblResult.Text + "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
            {
                lblResult.Text = "";
                _ekranTemizleme = false;
            }
            if (lblResult.Text == "0")
            {
                lblResult.Text = "6";
            }
            else
            {
                lblResult.Text = lblResult.Text + "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
            {
                lblResult.Text = "";
                _ekranTemizleme = false;
            }
            if (lblResult.Text == "0")
            {
                lblResult.Text = "7";
            }
            else
            {
                lblResult.Text = lblResult.Text + "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
            {
                lblResult.Text = "";
                _ekranTemizleme = false;
            }
            if (lblResult.Text == "0")
            {
                lblResult.Text = "8";
            }
            else
            {
                lblResult.Text = lblResult.Text + "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
            {
                lblResult.Text = "";
                _ekranTemizleme = false;
            }
            if (lblResult.Text == "0")
            {
                lblResult.Text = "9";
            }
            else
            {
                lblResult.Text = lblResult.Text + "9";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (_ekranTemizleme)
            {
                lblResult.Text = "";
                _ekranTemizleme = false;
            }
            if (lblResult.Text == "0")
            {
  
            }
            else
            {
                lblResult.Text = lblResult.Text + "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            _ilkSayi = 0;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizleme = true;
            _ilkSayi = int.Parse(lblResult.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizleme = true;
            _ilkSayi=int.Parse(lblResult.Text);
          
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizleme = true;
            _ilkSayi = int.Parse(lblResult.Text);
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizleme = true;
            _ilkSayi = int.Parse(lblResult.Text);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (_islem)
            {
                case '+' :
                    _ilkSayi += int.Parse(lblResult.Text);
                    lblResult.Text = _ilkSayi.ToString();
                    break;
                
                case '-':
                    _ilkSayi -= int.Parse(lblResult.Text);
                    lblResult.Text = _ilkSayi.ToString();
                    break;
                case '/':
                    try
                    {
                        _ilkSayi /= int.Parse(lblResult.Text);
                    }
                    catch (ArithmeticException ex) {
                        Console.WriteLine(ex.Message);
                    }
                    lblResult.Text = _ilkSayi.ToString();
                    break;
                case '*':
                    _ilkSayi *= int.Parse(lblResult.Text);
                    lblResult.Text = _ilkSayi.ToString();
                    break;

            }
        }

      
    }
}
