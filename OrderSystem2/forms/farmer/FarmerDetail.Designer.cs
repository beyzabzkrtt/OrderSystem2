namespace OrderSystem2.forms
{
    partial class FarmerDetail
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
            panel2 = new Panel();
            pictureBoxBack = new PictureBox();
            pictureBoxExpand = new PictureBox();
            pictureBoxTab = new PictureBox();
            pictureBoxClose = new PictureBox();
            label1 = new Label();
            buttonDelete = new Button();
            buttonSave = new Button();
            buttonShowOrders = new Button();
            buttonShowField = new Button();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxTc = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            textBoxFarmerID = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 56, 39);
            panel2.Controls.Add(pictureBoxBack);
            panel2.Controls.Add(pictureBoxExpand);
            panel2.Controls.Add(pictureBoxTab);
            panel2.Controls.Add(pictureBoxClose);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1235, 114);
            panel2.TabIndex = 3;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Image = Properties.Resources.back;
            pictureBoxBack.Location = new Point(0, -1);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(29, 32);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBack.TabIndex = 9;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxExpand.Image = Properties.Resources.expand;
            pictureBoxExpand.Location = new Point(1172, -1);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(34, 32);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 8;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // pictureBoxTab
            // 
            pictureBoxTab.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxTab.Image = Properties.Resources.tab;
            pictureBoxTab.Location = new Point(1139, -1);
            pictureBoxTab.Name = "pictureBoxTab";
            pictureBoxTab.Size = new Size(34, 32);
            pictureBoxTab.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTab.TabIndex = 7;
            pictureBoxTab.TabStop = false;
            pictureBoxTab.Click += pictureBoxTab_Click;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxClose.Image = Properties.Resources.close_button;
            pictureBoxClose.Location = new Point(1201, -1);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(34, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 3;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(53, 35);
            label1.Name = "label1";
            label1.Size = new Size(167, 39);
            label1.TabIndex = 0;
            label1.Text = "Çiftçi Detay";
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.BackColor = Color.FromArgb(22, 56, 39);
            buttonDelete.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.AntiqueWhite;
            buttonDelete.Location = new Point(943, 487);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(96, 45);
            buttonDelete.TabIndex = 47;
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
            buttonSave.Location = new Point(1039, 487);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(160, 45);
            buttonSave.TabIndex = 48;
            buttonSave.TabStop = false;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonShowOrders
            // 
            buttonShowOrders.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonShowOrders.BackColor = Color.FromArgb(22, 56, 39);
            buttonShowOrders.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonShowOrders.ForeColor = Color.AntiqueWhite;
            buttonShowOrders.Location = new Point(943, 436);
            buttonShowOrders.Name = "buttonShowOrders";
            buttonShowOrders.Size = new Size(256, 45);
            buttonShowOrders.TabIndex = 49;
            buttonShowOrders.TabStop = false;
            buttonShowOrders.Text = "Siparişleri Görüntüle";
            buttonShowOrders.UseVisualStyleBackColor = false;
            // 
            // buttonShowField
            // 
            buttonShowField.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonShowField.BackColor = Color.FromArgb(22, 56, 39);
            buttonShowField.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonShowField.ForeColor = Color.AntiqueWhite;
            buttonShowField.Location = new Point(943, 380);
            buttonShowField.Name = "buttonShowField";
            buttonShowField.Size = new Size(256, 43);
            buttonShowField.TabIndex = 51;
            buttonShowField.TabStop = false;
            buttonShowField.Text = "Tarlaları Görüntüle";
            buttonShowField.UseVisualStyleBackColor = false;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxName.BackColor = Color.LightYellow;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(206, 199);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(306, 31);
            textBoxName.TabIndex = 58;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSurname.BackColor = Color.LightYellow;
            textBoxSurname.BorderStyle = BorderStyle.FixedSingle;
            textBoxSurname.Location = new Point(206, 251);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(306, 31);
            textBoxSurname.TabIndex = 59;
            // 
            // textBoxTc
            // 
            textBoxTc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxTc.BackColor = Color.LightYellow;
            textBoxTc.BorderStyle = BorderStyle.FixedSingle;
            textBoxTc.Location = new Point(206, 307);
            textBoxTc.MaxLength = 11;
            textBoxTc.Name = "textBoxTc";
            textBoxTc.Size = new Size(306, 31);
            textBoxTc.TabIndex = 60;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxEmail.BackColor = Color.LightYellow;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(206, 371);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(306, 31);
            textBoxEmail.TabIndex = 61;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxPhone.BackColor = Color.LightYellow;
            textBoxPhone.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhone.Location = new Point(206, 427);
            textBoxPhone.MaxLength = 11;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(306, 31);
            textBoxPhone.TabIndex = 62;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxAddress.BackColor = Color.LightYellow;
            textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddress.Location = new Point(776, 148);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(306, 102);
            textBoxAddress.TabIndex = 63;
            // 
            // textBoxFarmerID
            // 
            textBoxFarmerID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxFarmerID.BackColor = SystemColors.ActiveBorder;
            textBoxFarmerID.BorderStyle = BorderStyle.FixedSingle;
            textBoxFarmerID.Location = new Point(206, 148);
            textBoxFarmerID.Name = "textBoxFarmerID";
            textBoxFarmerID.Size = new Size(306, 31);
            textBoxFarmerID.TabIndex = 64;
            textBoxFarmerID.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 56, 39);
            label8.Location = new Point(89, 202);
            label8.Margin = new Padding(3, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(47, 29);
            label8.TabIndex = 57;
            label8.Text = "Ad:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(22, 56, 39);
            label7.Location = new Point(89, 251);
            label7.Margin = new Padding(3, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 29);
            label7.TabIndex = 56;
            label7.Text = "Soyad:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(22, 56, 39);
            label6.Location = new Point(95, 309);
            label6.Margin = new Padding(3, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 29);
            label6.TabIndex = 55;
            label6.Text = "Tc:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 56, 39);
            label5.Location = new Point(89, 372);
            label5.Margin = new Padding(15);
            label5.Name = "label5";
            label5.Size = new Size(75, 29);
            label5.TabIndex = 54;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 56, 39);
            label4.Location = new Point(659, 145);
            label4.Margin = new Padding(3, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 29);
            label4.TabIndex = 53;
            label4.Text = "Adres:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 56, 39);
            label3.Location = new Point(89, 429);
            label3.Margin = new Padding(3, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 29);
            label3.TabIndex = 52;
            label3.Text = "Telefon:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(89, 152);
            label2.Margin = new Padding(3, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 29);
            label2.TabIndex = 50;
            label2.Text = "Çiftçi No:";
            // 
            // FarmerDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1235, 559);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(buttonShowOrders);
            Controls.Add(buttonShowField);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxTc);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxFarmerID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FarmerDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FarmerDetail";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
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

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBoxTab;
        private PictureBox pictureBoxBack;
        private Button buttonDelete;
        private Button buttonSave;
        private Button buttonShowOrders;
        private Button buttonShowField;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxTc;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private TextBox textBoxFarmerID;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}