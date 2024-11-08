namespace UTS_PBO
{
    partial class HalamanWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonHalPendaftaranPengguna = new Button();
            buttonLoginAdmin = new Button();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 27);
            label1.Name = "label1";
            label1.Size = new Size(278, 48);
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang";
            // 
            // buttonHalPendaftaranPengguna
            // 
            buttonHalPendaftaranPengguna.Location = new Point(187, 183);
            buttonHalPendaftaranPengguna.Name = "buttonHalPendaftaranPengguna";
            buttonHalPendaftaranPengguna.Size = new Size(159, 97);
            buttonHalPendaftaranPengguna.TabIndex = 2;
            buttonHalPendaftaranPengguna.Text = "Register";
            buttonHalPendaftaranPengguna.UseVisualStyleBackColor = true;
            buttonHalPendaftaranPengguna.Click += buttonHalPendaftaranPengguna_Click;
            // 
            // buttonLoginAdmin
            // 
            buttonLoginAdmin.Location = new Point(446, 183);
            buttonLoginAdmin.Name = "buttonLoginAdmin";
            buttonLoginAdmin.Size = new Size(182, 38);
            buttonLoginAdmin.TabIndex = 3;
            buttonLoginAdmin.Text = "Login (admin)";
            buttonLoginAdmin.UseVisualStyleBackColor = true;
            buttonLoginAdmin.Click += buttonLoginAdmin_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(446, 242);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(182, 38);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login ";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // HalamanWelcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogin);
            Controls.Add(buttonLoginAdmin);
            Controls.Add(buttonHalPendaftaranPengguna);
            Controls.Add(label1);
            Name = "HalamanWelcome";
            Text = "Mainform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonHalPendaftaranPengguna;
        private Button buttonLoginAdmin;
        private Button buttonLogin;
    }
}
