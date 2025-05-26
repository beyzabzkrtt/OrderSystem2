namespace OrderSystem2.forms.adminPanel.user
{
    partial class UserDetailForm
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
            buttonDelete = new Button();
            buttonSave = new Button();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxTc = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            textBoxUserID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            buttonRoles = new Button();
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
            panel1.Size = new Size(1235, 105);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(69, 32);
            label1.Name = "label1";
            label1.Size = new Size(212, 39);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Detay";
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.BackColor = Color.FromArgb(22, 56, 39);
            buttonDelete.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.AntiqueWhite;
            buttonDelete.Location = new Point(932, 481);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(96, 45);
            buttonDelete.TabIndex = 65;
            buttonDelete.TabStop = false;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(22, 56, 39);
            buttonSave.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.AntiqueWhite;
            buttonSave.Location = new Point(1028, 481);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(160, 45);
            buttonSave.TabIndex = 66;
            buttonSave.TabStop = false;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxName.BackColor = Color.LightYellow;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(245, 195);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(306, 31);
            textBoxName.TabIndex = 76;
            textBoxName.KeyPress += TextBoxName_KeyPress;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSurname.BackColor = Color.LightYellow;
            textBoxSurname.BorderStyle = BorderStyle.FixedSingle;
            textBoxSurname.Location = new Point(245, 247);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(306, 31);
            textBoxSurname.TabIndex = 77;
            textBoxSurname.KeyPress += TextBoxSurname_KeyPress;
            // 
            // textBoxTc
            // 
            textBoxTc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxTc.BackColor = Color.LightYellow;
            textBoxTc.BorderStyle = BorderStyle.FixedSingle;
            textBoxTc.Location = new Point(245, 303);
            textBoxTc.MaxLength = 11;
            textBoxTc.Name = "textBoxTc";
            textBoxTc.Size = new Size(306, 31);
            textBoxTc.TabIndex = 78;
            textBoxTc.KeyPress += TextBoxTc_KeyPress;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxEmail.BackColor = Color.LightYellow;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(245, 367);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(306, 31);
            textBoxEmail.TabIndex = 79;
            textBoxEmail.KeyPress += TextBoxEmail_KeyPress;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxPhone.BackColor = Color.LightYellow;
            textBoxPhone.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhone.Location = new Point(245, 423);
            textBoxPhone.MaxLength = 11;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(306, 31);
            textBoxPhone.TabIndex = 80;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxAddress.BackColor = Color.LightYellow;
            textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddress.Location = new Point(775, 141);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(306, 102);
            textBoxAddress.TabIndex = 81;
            // 
            // textBoxUserID
            // 
            textBoxUserID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxUserID.BackColor = SystemColors.ActiveBorder;
            textBoxUserID.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserID.Location = new Point(245, 144);
            textBoxUserID.Name = "textBoxUserID";
            textBoxUserID.Size = new Size(306, 31);
            textBoxUserID.TabIndex = 82;
            textBoxUserID.TabStop = false;
            textBoxUserID.ReadOnly = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 56, 39);
            label8.Location = new Point(88, 195);
            label8.Margin = new Padding(3, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(47, 29);
            label8.TabIndex = 75;
            label8.Text = "Ad:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(22, 56, 39);
            label7.Location = new Point(88, 244);
            label7.Margin = new Padding(3, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 29);
            label7.TabIndex = 74;
            label7.Text = "Soyad:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(22, 56, 39);
            label6.Location = new Point(94, 302);
            label6.Margin = new Padding(3, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 29);
            label6.TabIndex = 73;
            label6.Text = "Tc:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 56, 39);
            label5.Location = new Point(88, 365);
            label5.Margin = new Padding(15);
            label5.Name = "label5";
            label5.Size = new Size(75, 29);
            label5.TabIndex = 72;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 56, 39);
            label4.Location = new Point(658, 138);
            label4.Margin = new Padding(3, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 29);
            label4.TabIndex = 71;
            label4.Text = "Adres:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 56, 39);
            label3.Location = new Point(88, 422);
            label3.Margin = new Padding(3, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 29);
            label3.TabIndex = 70;
            label3.Text = "Telefon:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(88, 145);
            label2.Margin = new Padding(3, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 29);
            label2.TabIndex = 68;
            label2.Text = "Kullanıcı No:";
            // 
            // buttonRoles
            // 
            buttonRoles.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonRoles.BackColor = Color.FromArgb(22, 56, 39);
            buttonRoles.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRoles.ForeColor = Color.AntiqueWhite;
            buttonRoles.Location = new Point(932, 423);
            buttonRoles.Name = "buttonRoles";
            buttonRoles.Size = new Size(256, 45);
            buttonRoles.TabIndex = 83;
            buttonRoles.TabStop = false;
            buttonRoles.Text = "Yetkiler";
            buttonRoles.UseVisualStyleBackColor = false;
            buttonRoles.Click += buttonRoles_Click;



            // 
            // UserDetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 559);
            Controls.Add(buttonRoles);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxTc);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxUserID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "UserDetailForm";
            Text = "UserDetailForm";
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(textBoxUserID, 0);
            Controls.SetChildIndex(textBoxAddress, 0);
            Controls.SetChildIndex(textBoxPhone, 0);
            Controls.SetChildIndex(textBoxEmail, 0);
            Controls.SetChildIndex(textBoxTc, 0);
            Controls.SetChildIndex(textBoxSurname, 0);
            Controls.SetChildIndex(textBoxName, 0);
            Controls.SetChildIndex(buttonSave, 0);
            Controls.SetChildIndex(buttonDelete, 0);
            Controls.SetChildIndex(buttonRoles, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private void TextBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
        private Button buttonDelete;
        private Button buttonSave;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxTc;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private TextBox textBoxUserID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonRoles;
    }
}