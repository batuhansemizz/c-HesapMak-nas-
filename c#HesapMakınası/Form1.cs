namespace c_HesapMakınası
{
    public partial class Form1 : Form
    {
        private char _islem;
        Boolean _ekranTemizlenecekMi;
        int _ilkSayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void ekranLabel_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "1";
        }

        private void rakam1Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void rakam2Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam3buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam4Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam5Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam6Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam0Buton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void artıButon_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);

        }


        private void esittirButon_Click(object sender, EventArgs e)
        {
            int İkinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
            switch (_islem)
            {

                case '+':
                    sonuc = _ilkSayi + İkinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - İkinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * İkinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / İkinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void eskiButon_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void carpıbuton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);

        }

        private void boluButon_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void temizleButon_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "";
        }
    }
}