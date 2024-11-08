namespace UTS_PBO.View
{
    partial class FormTambahTugas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxJudul = new TextBox();
            textBoxDeskripsi = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            buttonTambah = new Button();
            buttonCancel = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 140);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 0;
            label1.Text = "Judul";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 199);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 1;
            label2.Text = "Deskripsi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 262);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 2;
            label3.Text = "Deadline";
            // 
            // textBoxJudul
            // 
            textBoxJudul.Location = new Point(334, 140);
            textBoxJudul.Name = "textBoxJudul";
            textBoxJudul.Size = new Size(300, 31);
            textBoxJudul.TabIndex = 3;
            // 
            // textBoxDeskripsi
            // 
            textBoxDeskripsi.ForeColor = Color.White;
            textBoxDeskripsi.Location = new Point(334, 199);
            textBoxDeskripsi.Name = "textBoxDeskripsi";
            textBoxDeskripsi.Size = new Size(300, 31);
            textBoxDeskripsi.TabIndex = 4;
            textBoxDeskripsi.TextChanged += textBoxDeskripsi_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(334, 256);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // buttonTambah
            // 
            buttonTambah.Location = new Point(522, 374);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(112, 34);
            buttonTambah.TabIndex = 6;
            buttonTambah.Text = "Tambah";
            buttonTambah.UseVisualStyleBackColor = true;
            buttonTambah.Click += buttonTambah_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Location = new Point(404, 374);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(283, 21);
            label4.Name = "label4";
            label4.Size = new Size(255, 48);
            label4.TabIndex = 8;
            label4.Text = "Tambah Tugas";
            // 
            // FormTambahTugas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(buttonCancel);
            Controls.Add(buttonTambah);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxDeskripsi);
            Controls.Add(textBoxJudul);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTambahTugas";
            Text = "FormTambahTugas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxJudul;
        private TextBox textBoxDeskripsi;
        private DateTimePicker dateTimePicker1;
        private Button buttonTambah;
        private Button buttonCancel;
        private Label label4;
    }
}