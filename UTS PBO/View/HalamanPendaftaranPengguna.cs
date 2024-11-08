using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTS_PBO.App.Context;
using UTS_PBO.App.Models;

namespace UTS_PBO.View
{
    public partial class HalamanPendaftaranPengguna : Form
    {
        public HalamanPendaftaranPengguna()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            {
                if (!validateinput())
                {
                    MessageBox.Show("Please fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                M_Pengguna user = new M_Pengguna();
                user.username = textBoxUsername.Text;
                user.password = textBoxPassword.Text;



                PenggunaContext.AddPengguna(user);
                MessageBox.Show("Register Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearfield();

                this.Close();
                HalamanWelcome halamanWelcome = new HalamanWelcome();
                halamanWelcome.Show();
            }


        }
        private bool validateinput()
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                return false;
            }
            return true;
        }

        private void clearfield()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }


    }
}
