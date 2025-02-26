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
            panel1 = new Panel();
            buttonDelete = new Button();
            buttonSave = new Button();
            buttonShowOrders = new Button();
            buttonShowField = new Button();
            textBoxCreatedBy = new TextBox();
            textBoxCreatedAt = new TextBox();
            textBoxUpdatedBy = new TextBox();
            textBoxupdatedAt = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            textBoxZoneId = new TextBox();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxTc = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            textBoxFarmerID = new TextBox();
            label9 = new Label();
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
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonShowOrders);
            panel1.Controls.Add(buttonShowField);
            panel1.Controls.Add(textBoxCreatedBy);
            panel1.Controls.Add(textBoxCreatedAt);
            panel1.Controls.Add(textBoxUpdatedBy);
            panel1.Controls.Add(textBoxupdatedAt);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBoxZoneId);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(textBoxSurname);
            panel1.Controls.Add(textBoxTc);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxPhone);
            panel1.Controls.Add(textBoxAddress);
            panel1.Controls.Add(textBoxFarmerID);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 114);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 445);
            panel1.TabIndex = 4;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.BackColor = Color.FromArgb(22, 56, 39);
            buttonDelete.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.AntiqueWhite;
            buttonDelete.Location = new Point(846, 321);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(96, 45);
            buttonDelete.TabIndex = 35;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(22, 56, 39);
            buttonSave.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.AntiqueWhite;
            buttonSave.Location = new Point(942, 321);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(160, 45);
            buttonSave.TabIndex = 33;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonShowOrders
            // 
            buttonShowOrders.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonShowOrders.BackColor = Color.FromArgb(22, 56, 39);
            buttonShowOrders.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonShowOrders.ForeColor = Color.AntiqueWhite;
            buttonShowOrders.Location = new Point(846, 270);
            buttonShowOrders.Name = "buttonShowOrders";
            buttonShowOrders.Size = new Size(256, 45);
            buttonShowOrders.TabIndex = 32;
            buttonShowOrders.Text = "Siparişleri Görüntüle";
            buttonShowOrders.UseVisualStyleBackColor = false;
            buttonShowOrders.Click += buttonShowOrders_Click;
            // 
            // buttonShowField
            // 
            buttonShowField.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonShowField.BackColor = Color.FromArgb(22, 56, 39);
            buttonShowField.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonShowField.ForeColor = Color.AntiqueWhite;
            buttonShowField.Location = new Point(846, 221);
            buttonShowField.Name = "buttonShowField";
            buttonShowField.Size = new Size(256, 43);
            buttonShowField.TabIndex = 31;
            buttonShowField.Text = "Tarlaları Görüntüle";
            buttonShowField.UseVisualStyleBackColor = false;
            buttonShowField.Click += buttonShowField_Click;
            // 
            // textBoxCreatedBy
            // 
            textBoxCreatedBy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxCreatedBy.BackColor = Color.LightYellow;
            textBoxCreatedBy.BorderStyle = BorderStyle.FixedSingle;
            textBoxCreatedBy.Location = new Point(782, 28);
            textBoxCreatedBy.Name = "textBoxCreatedBy";
            textBoxCreatedBy.Size = new Size(306, 31);
            textBoxCreatedBy.TabIndex = 30;
            // 
            // textBoxCreatedAt
            // 
            textBoxCreatedAt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxCreatedAt.BackColor = Color.LightYellow;
            textBoxCreatedAt.BorderStyle = BorderStyle.FixedSingle;
            textBoxCreatedAt.Location = new Point(782, 72);
            textBoxCreatedAt.Name = "textBoxCreatedAt";
            textBoxCreatedAt.Size = new Size(306, 31);
            textBoxCreatedAt.TabIndex = 29;
            // 
            // textBoxUpdatedBy
            // 
            textBoxUpdatedBy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxUpdatedBy.BackColor = Color.LightYellow;
            textBoxUpdatedBy.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpdatedBy.Location = new Point(782, 114);
            textBoxUpdatedBy.Name = "textBoxUpdatedBy";
            textBoxUpdatedBy.Size = new Size(306, 31);
            textBoxUpdatedBy.TabIndex = 28;
            // 
            // textBoxupdatedAt
            // 
            textBoxupdatedAt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxupdatedAt.BackColor = Color.LightYellow;
            textBoxupdatedAt.BorderStyle = BorderStyle.FixedSingle;
            textBoxupdatedAt.Location = new Point(782, 157);
            textBoxupdatedAt.Name = "textBoxupdatedAt";
            textBoxupdatedAt.Size = new Size(306, 31);
            textBoxupdatedAt.TabIndex = 27;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(22, 56, 39);
            label13.Location = new Point(575, 115);
            label13.Name = "label13";
            label13.Size = new Size(143, 29);
            label13.TabIndex = 26;
            label13.Text = "Güncelleyen:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(22, 56, 39);
            label12.Location = new Point(575, 155);
            label12.Name = "label12";
            label12.Size = new Size(199, 29);
            label12.TabIndex = 25;
            label12.Text = "Güncelleme Tarihi:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(22, 56, 39);
            label11.Location = new Point(575, 69);
            label11.Name = "label11";
            label11.Size = new Size(130, 29);
            label11.TabIndex = 24;
            label11.Text = "Kayıt Tarihi:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(22, 56, 39);
            label10.Location = new Point(575, 25);
            label10.Name = "label10";
            label10.Size = new Size(181, 29);
            label10.TabIndex = 23;
            label10.Text = "Kaydı Oluşturan:";
            // 
            // textBoxZoneId
            // 
            textBoxZoneId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxZoneId.BackColor = Color.LightYellow;
            textBoxZoneId.BorderStyle = BorderStyle.FixedSingle;
            textBoxZoneId.Location = new Point(233, 70);
            textBoxZoneId.Name = "textBoxZoneId";
            textBoxZoneId.Size = new Size(306, 31);
            textBoxZoneId.TabIndex = 22;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxName.BackColor = Color.LightYellow;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(233, 113);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(306, 31);
            textBoxName.TabIndex = 21;
            textBoxName.KeyPress += TextBoxName_KeyPress;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSurname.BackColor = Color.LightYellow;
            textBoxSurname.BorderStyle = BorderStyle.FixedSingle;
            textBoxSurname.Location = new Point(233, 165);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(306, 31);
            textBoxSurname.TabIndex = 20;
            textBoxSurname.KeyPress += TextBoxSurname_KeyPress;
            // 
            // textBoxTc
            // 
            textBoxTc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxTc.BackColor = Color.LightYellow;
            textBoxTc.BorderStyle = BorderStyle.FixedSingle;
            textBoxTc.Location = new Point(233, 210);
            textBoxTc.Name = "textBoxTc";
            textBoxTc.Size = new Size(306, 31);
            textBoxTc.TabIndex = 19;
            textBoxTc.KeyPress += TextBoxTc_KeyPress;
            textBoxTc.MaxLength = 11;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxEmail.BackColor = Color.LightYellow;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(233, 255);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(306, 31);
            textBoxEmail.TabIndex = 18;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxPhone.BackColor = Color.LightYellow;
            textBoxPhone.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhone.Location = new Point(233, 299);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(306, 31);
            textBoxPhone.TabIndex = 17;
            textBoxPhone.KeyPress += TextBoxPhone_KeyPress;
            textBoxPhone.MaxLength = 11;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxAddress.BackColor = Color.LightYellow;
            textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddress.Location = new Point(233, 342);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(306, 31);
            textBoxAddress.TabIndex = 16;
            // 
            // textBoxFarmerID
            // 
            textBoxFarmerID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxFarmerID.BackColor = Color.LightYellow;
            textBoxFarmerID.BorderStyle = BorderStyle.FixedSingle;
            textBoxFarmerID.Location = new Point(233, 26);
            textBoxFarmerID.Name = "textBoxFarmerID";
            textBoxFarmerID.Size = new Size(306, 31);
            textBoxFarmerID.TabIndex = 11;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(22, 56, 39);
            label9.Location = new Point(116, 71);
            label9.Margin = new Padding(3, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(111, 29);
            label9.TabIndex = 10;
            label9.Text = "Bölge No:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 56, 39);
            label8.Location = new Point(116, 116);
            label8.Margin = new Padding(3, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(47, 29);
            label8.TabIndex = 9;
            label8.Text = "Ad:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(22, 56, 39);
            label7.Location = new Point(116, 165);
            label7.Margin = new Padding(3, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 29);
            label7.TabIndex = 8;
            label7.Text = "Soyad:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(22, 56, 39);
            label6.Location = new Point(116, 209);
            label6.Margin = new Padding(3, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 29);
            label6.TabIndex = 7;
            label6.Text = "Tc:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 56, 39);
            label5.Location = new Point(116, 256);
            label5.Margin = new Padding(15);
            label5.Name = "label5";
            label5.Size = new Size(75, 29);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 56, 39);
            label4.Location = new Point(116, 339);
            label4.Margin = new Padding(3, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 29);
            label4.TabIndex = 5;
            label4.Text = "Adres:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 56, 39);
            label3.Location = new Point(116, 301);
            label3.Margin = new Padding(3, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 29);
            label3.TabIndex = 4;
            label3.Text = "Telefon:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(116, 30);
            label2.Margin = new Padding(3, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 29);
            label2.TabIndex = 3;
            label2.Text = "Çiftçi No:";
            // 
            // FarmerDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 559);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxFarmerID;
        private TextBox textBoxZoneId;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxTc;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private TextBox textBoxCreatedBy;
        private TextBox textBoxCreatedAt;
        private TextBox textBoxUpdatedBy;
        private TextBox textBoxupdatedAt;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button buttonSave;
        private Button buttonShowOrders;
        private Button buttonShowField;
        private Button buttonDelete;
        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBoxTab;
        private PictureBox pictureBoxBack;
    }
}