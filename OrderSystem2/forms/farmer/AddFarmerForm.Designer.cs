
namespace OrderSystem2.forms
{
    partial class AddFarmerForm
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
            pictureBoxClose = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            labelPlaceholder = new Label();
            comboBoxFactory = new ComboBox();
            label2 = new Label();
            comboBoxZone = new ComboBox();
            buttonSave = new Button();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxTc = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 56, 39);
            panel2.Controls.Add(pictureBoxClose);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 114);
            panel2.TabIndex = 3;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.close_button;
            pictureBoxClose.Location = new Point(489, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(38, 35);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(199, 30);
            label1.Name = "label1";
            label1.Size = new Size(143, 39);
            label1.TabIndex = 0;
            label1.Text = "Çiftçi Ekle";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(labelPlaceholder);
            panel1.Controls.Add(comboBoxFactory);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxZone);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(textBoxSurname);
            panel1.Controls.Add(textBoxTc);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxPhone);
            panel1.Controls.Add(textBoxAddress);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 114);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 538);
            panel1.TabIndex = 4;
            // 
            // labelPlaceholder
            // 
            labelPlaceholder.AutoSize = true;
            labelPlaceholder.BackColor = Color.LightYellow;
            labelPlaceholder.ForeColor = SystemColors.ActiveBorder;
            labelPlaceholder.Location = new Point(170, 34);
            labelPlaceholder.Name = "labelPlaceholder";
            labelPlaceholder.Size = new Size(126, 25);
            labelPlaceholder.TabIndex = 36;
            labelPlaceholder.Text = "Fabrika Seçiniz";
            // 
            // comboBoxFactory
            // 
            comboBoxFactory.BackColor = Color.LightYellow;
            comboBoxFactory.FormattingEnabled = true;
            comboBoxFactory.Location = new Point(167, 31);
            comboBoxFactory.Name = "comboBoxFactory";
            comboBoxFactory.Size = new Size(306, 33);
            comboBoxFactory.TabIndex = 37;
            comboBoxFactory.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(42, 35);
            label2.Margin = new Padding(3, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 29);
            label2.TabIndex = 35;
            label2.Text = "Fabrika:";
            // 
            // comboBoxZone
            // 
            comboBoxZone.BackColor = Color.LightYellow;
            comboBoxZone.FormattingEnabled = true;
            comboBoxZone.Location = new Point(167, 81);
            comboBoxZone.Name = "comboBoxZone";
            comboBoxZone.Size = new Size(306, 33);
            comboBoxZone.TabIndex = 38;
            comboBoxZone.TabStop = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(22, 56, 39);
            buttonSave.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.AntiqueWhite;
            buttonSave.Location = new Point(326, 471);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(186, 50);
            buttonSave.TabIndex = 56;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.LightYellow;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(167, 132);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(306, 31);
            textBoxName.TabIndex = 50;
            textBoxName.KeyPress += TextBoxName_KeyPress;
            // 
            // textBoxSurname
            // 
            textBoxSurname.BackColor = Color.LightYellow;
            textBoxSurname.BorderStyle = BorderStyle.FixedSingle;
            textBoxSurname.Location = new Point(167, 184);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(306, 31);
            textBoxSurname.TabIndex = 51;
            textBoxSurname.KeyPress += TextBoxSurname_KeyPress;
            // 
            // textBoxTc
            // 
            textBoxTc.BackColor = Color.LightYellow;
            textBoxTc.BorderStyle = BorderStyle.FixedSingle;
            textBoxTc.Location = new Point(167, 229);
            textBoxTc.MaxLength = 11;
            textBoxTc.Name = "textBoxTc";
            textBoxTc.Size = new Size(306, 31);
            textBoxTc.TabIndex = 52;
            textBoxTc.KeyPress += textBoxTc_KeyPress;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.LightYellow;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(167, 274);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(306, 31);
            textBoxEmail.TabIndex = 53;
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.LightYellow;
            textBoxPhone.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhone.Location = new Point(167, 318);
            textBoxPhone.MaxLength = 11;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(306, 31);
            textBoxPhone.TabIndex = 54;
            textBoxPhone.KeyPress += TextBoxPhone_KeyPress;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.LightYellow;
            textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddress.Location = new Point(167, 361);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(306, 80);
            textBoxAddress.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(22, 56, 39);
            label9.Location = new Point(42, 85);
            label9.Margin = new Padding(3, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(77, 29);
            label9.TabIndex = 10;
            label9.Text = "Bölge:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 56, 39);
            label8.Location = new Point(42, 137);
            label8.Margin = new Padding(3, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(47, 29);
            label8.TabIndex = 9;
            label8.Text = "Ad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(22, 56, 39);
            label7.Location = new Point(42, 186);
            label7.Margin = new Padding(3, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 29);
            label7.TabIndex = 8;
            label7.Text = "Soyad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(22, 56, 39);
            label6.Location = new Point(42, 230);
            label6.Margin = new Padding(3, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 29);
            label6.TabIndex = 7;
            label6.Text = "Tc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 56, 39);
            label5.Location = new Point(42, 277);
            label5.Margin = new Padding(15);
            label5.Name = "label5";
            label5.Size = new Size(75, 29);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 56, 39);
            label4.Location = new Point(42, 360);
            label4.Margin = new Padding(3, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 29);
            label4.TabIndex = 5;
            label4.Text = "Adres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 56, 39);
            label3.Location = new Point(42, 322);
            label3.Margin = new Padding(3, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 29);
            label3.TabIndex = 4;
            label3.Text = "Telefon:";
            // 
            // AddFarmerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 652);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddFarmerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FarmerDetail";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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

        private void textBoxZoneId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxTc_KeyPress(object sender, KeyPressEventArgs e)
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

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxTc;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private Button buttonSave;
        private PictureBox pictureBoxClose;
        private ComboBox comboBoxZone;
        private ComboBox comboBoxFactory;
        private Label label2;
        private Label labelPlaceholder;
    }
}