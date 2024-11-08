using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_PBO.View
{
    public partial class HalamanLoginAdmin : Form
    {
        public HalamanLoginAdmin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalamanDashboardAdmin halamanDashboardAdmin = new HalamanDashboardAdmin();
            halamanDashboardAdmin.Show();
        }
    }
}
