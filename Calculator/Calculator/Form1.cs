using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlenecekmi;
        private int _ilkSayi;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            RakamEkle("1");
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            RakamEkle("2");
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            RakamEkle("3");
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            RakamEkle("4");
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            RakamEkle("5");
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            RakamEkle("6");
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            RakamEkle("7");
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            RakamEkle("8");
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            RakamEkle("9");
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            RakamEkle("0");
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }

        private void toplaButton_Click(object sender, EventArgs e)
        {
            IslemSec('+');
        }

        private void cikarButton_Click(object sender, EventArgs e)
        {
            IslemSec('-');
        }

        private void carpButton_Click(object sender, EventArgs e)
        {
            IslemSec('*');
        }

        private void bolButton_Click(object sender, EventArgs e)
        {
            IslemSec('/');
        }

        private void esitButton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekranLabel.Text = Convert.ToString(sonuc);
        }


        private void RakamEkle(string rakam)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += rakam;
        }

        private void IslemSec(char islem)
        {
            _islem = islem;
            _ekranTemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }


    }
}
