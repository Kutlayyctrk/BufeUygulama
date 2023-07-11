namespace büfeuygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int mısır, bilet, su, cay, toplam;
            mısır = Convert.ToInt16(TxtMisir.Text);
            bilet = Convert.ToInt16(txtBilet.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(txtCay.Text);

            toplam = mısır * 4 + su * 5 + cay * 6 + bilet * 30;
            lblToplam.Text = ("Toplam: " + toplam.ToString() + "₺");
            kasatutar = kasatutar + toplam;
            lblkasa.Text = "Kasa: " + kasatutar.ToString() + "₺";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtCay.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";
            lblToplam.Text = "Toplam: 00₺";
            TxtMisir.Focus();
        }
    }
}