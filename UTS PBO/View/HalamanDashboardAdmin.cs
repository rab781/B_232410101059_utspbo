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

namespace UTS_PBO.View
{
    public partial class HalamanDashboardAdmin : Form
    {
        public HalamanDashboardAdmin()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDataTugas();
        }

        private void LoadDataTugas()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                DataTable tugasdata = TugasContext.All();
                if (tugasdata == null)
                {
                    MessageBox.Show("Error: Gagal mengambil data mahasiswa");
                    return;
                }

                dataGridView1.Columns.Clear();

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn();
                nomorColumn.HeaderText = "No";
                nomorColumn.Name = "nomor";
                dataGridView1.Columns.Add(nomorColumn);

                dataGridView1.DataSource = tugasdata;

                if (dataGridView1.Columns["id"] != null) dataGridView1.Columns["id"].Visible = false;
                if (dataGridView1.Columns["Judul"] != null)
                    dataGridView1.Columns["Judul"].HeaderText = "Judul";
                if (dataGridView1.Columns["Deskripsi"] != null)
                    dataGridView1.Columns["Deskripsi"].HeaderText = "Deskripsi";
                if (dataGridView1.Columns["Deadline"] != null)
                    dataGridView1.Columns["Deadline"].HeaderText = "Deadline";


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["nomor"].Value = (i + 1).ToString();
                }


                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Update",
                    HeaderText = "Update",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(updateButtonColumn);

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataMahasiswa: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTambahTugas formTambahTugas = new FormTambahTugas();
            formTambahTugas.ShowDialog();
        }
    }
}
