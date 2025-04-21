namespace OrderSystem2.forms.product
{
    partial class AddProductForm
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
            label1 = new Label();
            label9 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxStok = new TextBox();
            buttonSave = new Button();
            comboBoxFactory = new ComboBox();
            comboBoxUnit = new ComboBox();
            comboBoxCategory = new ComboBox();
            labelPlaceholder = new Label();
            labelCategory = new Label();
            labelUnit = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 56, 39);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 114);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(187, 36);
            label1.Name = "label1";
            label1.Size = new Size(145, 39);
            label1.TabIndex = 0;
            label1.Text = "Ürün Ekle";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(22, 56, 39);
            label9.Location = new Point(71, 168);
            label9.Margin = new Padding(3, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(94, 29);
            label9.TabIndex = 11;
            label9.Text = "Fabrika:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(71, 444);
            label2.Margin = new Padding(3, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 29);
            label2.TabIndex = 12;
            label2.Text = "Stok:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 56, 39);
            label3.Location = new Point(71, 386);
            label3.Margin = new Padding(3, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 29);
            label3.TabIndex = 13;
            label3.Text = "Fiyat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 56, 39);
            label4.Location = new Point(71, 331);
            label4.Margin = new Padding(3, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 29);
            label4.TabIndex = 14;
            label4.Text = "İsim:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 56, 39);
            label5.Location = new Point(71, 277);
            label5.Margin = new Padding(3, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 29);
            label5.TabIndex = 15;
            label5.Text = "Birim:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(22, 56, 39);
            label6.Location = new Point(71, 221);
            label6.Margin = new Padding(3, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 29);
            label6.TabIndex = 16;
            label6.Text = "Kategori:";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.LightYellow;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(217, 332);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(222, 31);
            textBoxName.TabIndex = 26;
            textBoxName.KeyPress += TextBoxName_KeyPress;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.LightYellow;
            textBoxPrice.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrice.Location = new Point(217, 387);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(222, 31);
            textBoxPrice.TabIndex = 29;
            textBoxPrice.KeyPress += TextBoxPrice_KeyPress;
            // 
            // textBoxStok
            // 
            textBoxStok.BackColor = Color.LightYellow;
            textBoxStok.BorderStyle = BorderStyle.FixedSingle;
            textBoxStok.Location = new Point(217, 445);
            textBoxStok.Name = "textBoxStok";
            textBoxStok.Size = new Size(222, 31);
            textBoxStok.TabIndex = 30;
            textBoxStok.KeyPress += TextBoxStok_KeyPress;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(22, 56, 39);
            buttonSave.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.AntiqueWhite;
            buttonSave.Location = new Point(314, 567);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(186, 59);
            buttonSave.TabIndex = 34;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // comboBoxFactory
            // 
            comboBoxFactory.BackColor = Color.LightYellow;
            comboBoxFactory.FormattingEnabled = true;
            comboBoxFactory.Location = new Point(217, 164);
            comboBoxFactory.Name = "comboBoxFactory";
            comboBoxFactory.Size = new Size(222, 33);
            comboBoxFactory.TabIndex = 38;
            comboBoxFactory.TabStop = false;
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.BackColor = Color.LightYellow;
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Location = new Point(217, 277);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(222, 33);
            comboBoxUnit.TabIndex = 39;
            comboBoxUnit.TabStop = false;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = Color.LightYellow;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(217, 221);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(222, 33);
            comboBoxCategory.TabIndex = 40;
            comboBoxCategory.TabStop = false;
            // 
            // labelPlaceholder
            // 
            labelPlaceholder.AutoSize = true;
            labelPlaceholder.BackColor = Color.LightYellow;
            labelPlaceholder.ForeColor = SystemColors.ActiveBorder;
            labelPlaceholder.Location = new Point(219, 167);
            labelPlaceholder.Name = "labelPlaceholder";
            labelPlaceholder.Size = new Size(126, 25);
            labelPlaceholder.TabIndex = 41;
            labelPlaceholder.Text = "Fabrika Seçiniz";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.BackColor = Color.LightYellow;
            labelCategory.ForeColor = SystemColors.ActiveBorder;
            labelCategory.Location = new Point(219, 224);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(136, 25);
            labelCategory.TabIndex = 42;
            labelCategory.Text = "Kategori Seçiniz";
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.BackColor = Color.LightYellow;
            labelUnit.ForeColor = SystemColors.ActiveBorder;
            labelUnit.Location = new Point(219, 280);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(110, 25);
            labelUnit.TabIndex = 43;
            labelUnit.Text = "Birim Seçiniz";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(labelUnit);
            Controls.Add(labelCategory);
            Controls.Add(labelPlaceholder);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxUnit);
            Controls.Add(comboBoxFactory);
            Controls.Add(buttonSave);
            Controls.Add(textBoxStok);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProductForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBoxStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
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
        private Label label9;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxStok;
        private Button buttonSave;
        private ComboBox comboBoxFactory;
        private ComboBox comboBoxUnit;
        private ComboBox comboBoxCategory;
        private Label labelPlaceholder;
        private Label labelCategory;
        private Label labelUnit;
    }
}