namespace OrderSystem2.forms.user
{
    partial class AddUserForm
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
            panel1 = new Panel();
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            label8 = new Label();
            label7 = new Label();
            labelPassword = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxTc = new TextBox();
            label2 = new Label();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 105);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(159, 31);
            label1.Name = "label1";
            label1.Size = new Size(188, 39);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Ekle";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.LightYellow;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(144, 147);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(306, 31);
            textBoxName.TabIndex = 62;
            textBoxName.KeyPress += TextBoxName_KeyPress;
            // 
            // textBoxSurname
            // 
            textBoxSurname.BackColor = Color.LightYellow;
            textBoxSurname.BorderStyle = BorderStyle.FixedSingle;
            textBoxSurname.Location = new Point(144, 199);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(306, 31);
            textBoxSurname.TabIndex = 63;
            textBoxSurname.KeyPress += TextBoxSurname_KeyPress;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.LightYellow;
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Location = new Point(144, 298);
            textBoxPassword.MaxLength = 11;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(306, 31);
            textBoxPassword.TabIndex = 65;
            textBoxPassword.KeyPress += TextBoxPassword_KeyPress;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.LightYellow;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(144, 250);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(306, 31);
            textBoxEmail.TabIndex = 64;
            textBoxEmail.KeyPress += TextBoxEmail_KeyPress;
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.LightYellow;
            textBoxPhone.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhone.Location = new Point(144, 393);
            textBoxPhone.MaxLength = 11;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(306, 31);
            textBoxPhone.TabIndex = 67;
            textBoxPhone.KeyPress += TextBoxPhone_KeyPress;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.LightYellow;
            textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddress.Location = new Point(144, 436);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(306, 80);
            textBoxAddress.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 56, 39);
            label8.Location = new Point(19, 152);
            label8.Margin = new Padding(3, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(47, 29);
            label8.TabIndex = 61;
            label8.Text = "Ad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(22, 56, 39);
            label7.Location = new Point(19, 201);
            label7.Margin = new Padding(3, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 29);
            label7.TabIndex = 60;
            label7.Text = "Soyad:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.FromArgb(22, 56, 39);
            labelPassword.Location = new Point(19, 297);
            labelPassword.Margin = new Padding(3, 0, 5, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(65, 29);
            labelPassword.TabIndex = 59;
            labelPassword.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 56, 39);
            label5.Location = new Point(19, 253);
            label5.Margin = new Padding(15);
            label5.Name = "label5";
            label5.Size = new Size(75, 29);
            label5.TabIndex = 58;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 56, 39);
            label4.Location = new Point(19, 435);
            label4.Margin = new Padding(3, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 29);
            label4.TabIndex = 57;
            label4.Text = "Adres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 56, 39);
            label3.Location = new Point(19, 397);
            label3.Margin = new Padding(3, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 29);
            label3.TabIndex = 56;
            label3.Text = "Telefon:";
            // 
            // textBoxTc
            // 
            textBoxTc.BackColor = Color.LightYellow;
            textBoxTc.BorderStyle = BorderStyle.FixedSingle;
            textBoxTc.Location = new Point(144, 347);
            textBoxTc.MaxLength = 11;
            textBoxTc.Name = "textBoxTc";
            textBoxTc.Size = new Size(306, 31);
            textBoxTc.TabIndex = 66;
            textBoxTc.KeyPress += TextBoxTc_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(19, 348);
            label2.Margin = new Padding(3, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 29);
            label2.TabIndex = 69;
            label2.Text = "Tc:";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(22, 56, 39);
            buttonSave.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.AntiqueWhite;
            buttonSave.Location = new Point(295, 578);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(186, 50);
            buttonSave.TabIndex = 70;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(493, 652);
            Controls.Add(buttonSave);
            Controls.Add(textBoxTc);
            Controls.Add(label2);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxAddress);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "AddUserForm";
            Text = "AddUserForm";
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(textBoxAddress, 0);
            Controls.SetChildIndex(textBoxPhone, 0);
            Controls.SetChildIndex(textBoxEmail, 0);
            Controls.SetChildIndex(textBoxSurname, 0);
            Controls.SetChildIndex(textBoxName, 0);
            Controls.SetChildIndex(textBoxPassword, 0);
            Controls.SetChildIndex(labelPassword, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(textBoxTc, 0);
            Controls.SetChildIndex(buttonSave, 0);
            Controls.SetChildIndex(pictureBoxClose, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBoxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void TextBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private Label label8;
        private Label label7;
        private Label labelPassword;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxTc;
        private Label label2;
        private Button buttonSave;
    }
}