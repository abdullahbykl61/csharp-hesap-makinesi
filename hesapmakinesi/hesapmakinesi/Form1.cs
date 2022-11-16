namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        char secim;
        double ilksayi, ikincisayi, sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void sayibutonlari(object sender, EventArgs e)
        {
            if (ekran.Text == "0")
            {
                ekran.Text = "";
            }
            ekran.Text = ekran.Text + ((Button)sender).Text;
        }

        private void btntumusil_Click(object sender, EventArgs e)
        {
            ekran.Text = "0";
        }

        private void btnarti_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(ekran.Text);
            ekran.Text = "0";
            secim = '+';
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(ekran.Text);
            ekran.Text = "0";
            secim = '-';
        }

        private void btncarpma_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(ekran.Text);
            ekran.Text = "0";
            secim = 'x';
        }

        private void btnbolme_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(ekran.Text);
            ekran.Text = "0";
            secim = '/';
        }

        private void btnesittir_Click(object sender, EventArgs e)
        {
            ikincisayi=Convert.ToDouble(ekran.Text);
            switch (secim)
            {
                case '+':
                    sonuc = ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = ilksayi - ikincisayi;
                    break;
                case 'x':
                    sonuc = ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = ilksayi / ikincisayi;
                    break;
                
            }
            ekran.Text = sonuc.ToString();
        }

        private void btnkarekok_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(ekran.Text);
            sonuc = Math.Sqrt(ilksayi);
            ekran.Text = sonuc.ToString();
        }

        private void btnusalma_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(ekran.Text);
            sonuc = Math.Pow(ilksayi, 2);
            ekran.Text = sonuc.ToString();
        }

        private void btnsilme_Click(object sender, EventArgs e)
        {
            ekran.Text = ekran.Text.Substring(0, ekran.Text.Length - 1);
            if (ekran.Text.Length == 0)
            {
                ekran.Text = "0";
            }
        }

        private void btnvirgul_Click(object sender, EventArgs e)
        {
            if (ekran.Text.IndexOf(",") < 1)
            {
                ekran.Text = ekran.Text + ",";
            }
        }
    }
}