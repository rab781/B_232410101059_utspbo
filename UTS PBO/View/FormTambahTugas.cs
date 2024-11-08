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
    public partial class FormTambahTugas : Form
    {

        public bool IsEditMode { get; set; } = false;
        public int tugasId { get; set; }

        public FormTambahTugas()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            M_Tugas tugas = new M_Tugas();
            {
                tugas.judul = textBoxJudul.Text;
                tugas.deskripsi = textBoxDeskripsi.Text;
                tugas.deadline = dateTimePicker1.Value;


            };

            if (IsEditMode)
            {
                tugas.id = tugasId;
                TugasContext.UpdateTugas(tugas);
                MessageBox.Show("Tugas berhasil diupdate");

            }
            else
            {
                TugasContext.AddTugas(tugas);
                MessageBox.Show("Tugas baru berhasil ditambahkan");
            }

            ClearFields();

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }



        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxJudul.Text) ||
                string.IsNullOrWhiteSpace(textBoxDeskripsi.Text) ||
                dateTimePicker1.Value == null)

            {
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            textBoxJudul.Clear();
            textBoxDeskripsi.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }




        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Inputan tidak valid");
                return;
            }

            M_Tugas tugas = new M_Tugas();
            {
                tugas.judul = textBoxJudul.Text;
                tugas.deskripsi = textBoxDeskripsi.Text;
                tugas.deadline = dateTimePicker1.Value;


            };

            if (IsEditMode)
            {
                tugas.id = tugasId;
                TugasContext.UpdateTugas(tugas);
                MessageBox.Show("Tugas berhasil diupdate");

            }
            else
            {
                TugasContext.AddTugas(tugas);
                MessageBox.Show("Tugas baru berhasil ditambahkan");
            }

            ClearFields();

            this.DialogResult = DialogResult.OK;
            this.Hide();

            HalamanDashboardAdmin halamanDashboardAdmin = new HalamanDashboardAdmin();
            halamanDashboardAdmin.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void textBoxDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
