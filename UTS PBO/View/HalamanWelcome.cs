using UTS_PBO.View;

namespace UTS_PBO
{
    public partial class HalamanWelcome : Form
    {
        public HalamanWelcome()
        {
            InitializeComponent();
        }

        private void buttonHalPendaftaranPengguna_Click(object sender, EventArgs e)
        {
            HalamanPendaftaranPengguna halamanPendaftaranPengguna = new HalamanPendaftaranPengguna();
            halamanPendaftaranPengguna.Show();
            this.Hide();
        }

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalamanLoginAdmin halamanLoginAdmin = new HalamanLoginAdmin();
            halamanLoginAdmin.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalamanFormLogin halamanFormLogin = new HalamanFormLogin();
            halamanFormLogin.Show();
        }
    }
}
