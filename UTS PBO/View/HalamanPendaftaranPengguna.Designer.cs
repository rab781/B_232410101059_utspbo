namespace UTS_PBO.View
{
    partial class HalamanPendaftaranPengguna
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
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 44);
            label1.Name = "label1";
            label1.Size = new Size(418, 48);
            label1.TabIndex = 0;
            label1.Text = "Register terlebih dahulu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 155);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 216);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(350, 152);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(256, 31);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(350, 213);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(256, 31);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(443, 333);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(163, 61);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // HalamanPendaftaranPengguna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HalamanPendaftaranPengguna";
            Text = "HalamanPendaftaranPengguna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonRegister;
    }
}