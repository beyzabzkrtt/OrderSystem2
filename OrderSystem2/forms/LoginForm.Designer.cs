
using OrderSystem2.Properties;

namespace OrderSystem2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBoxShowHide = new PictureBox();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            buttonLogin = new Button();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 106);
            panel1.TabIndex = 0;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxClose.Image = Resources.close_button;
            pictureBoxClose.Location = new Point(434, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(34, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 11;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBoxShowHide);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(buttonLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 602);
            panel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(360, 443);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 184);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-16, -35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(82, 166);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBoxShowHide
            // 
            pictureBoxShowHide.BackColor = Color.OldLace;
            pictureBoxShowHide.Image = Resources.closed_eye;
            pictureBoxShowHide.Location = new Point(375, 366);
            pictureBoxShowHide.Name = "pictureBoxShowHide";
            pictureBoxShowHide.Size = new Size(34, 32);
            pictureBoxShowHide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShowHide.TabIndex = 7;
            pictureBoxShowHide.TabStop = false;
            pictureBoxShowHide.Click += pictureBoxShowHide_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.OldLace;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Candara", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(53, 365);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '.';
            txtPassword.Size = new Size(357, 34);
            txtPassword.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(164, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(22, 56, 39);
            buttonLogin.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.AntiqueWhite;
            buttonLogin.Location = new Point(152, 443);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(168, 52);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "Giriş Yap";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 56, 39);
            label3.Location = new Point(53, 321);
            label3.Name = "label3";
            label3.Size = new Size(60, 27);
            label3.TabIndex = 4;
            label3.Text = "Şifre:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.OldLace;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Candara", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(53, 251);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(357, 34);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(53, 208);
            label2.Name = "label2";
            label2.Size = new Size(68, 27);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 708);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txtEmail;
        private Label label2;
        private Button buttonLogin;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxShowHide;
        private TextBox txtPassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBoxClose;
    }
}