namespace OrderSystem2.forms.product
{
    partial class ProductDetailForm
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
            pictureBoxExpand = new PictureBox();
            pictureBoxTab = new PictureBox();
            pictureBoxClose = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxProductNo = new TextBox();
            textBoxCategoryNo = new TextBox();
            textBoxUnitNo = new TextBox();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxStock = new TextBox();
            textBoxFactoryNo = new TextBox();
            buttonDelete = new Button();
            buttonSave = new Button();
            button1 = new Button();
            pictureBoxBack = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(pictureBoxBack);
            panel1.Controls.Add(pictureBoxExpand);
            panel1.Controls.Add(pictureBoxTab);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxExpand.Image = Properties.Resources.expand;
            pictureBoxExpand.Location = new Point(1171, 0);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(34, 32);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 11;
            pictureBoxExpand.TabStop = false;
            // 
            // pictureBoxTab
            // 
            pictureBoxTab.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxTab.Image = Properties.Resources.tab;
            pictureBoxTab.Location = new Point(1139, 0);
            pictureBoxTab.Name = "pictureBoxTab";
            pictureBoxTab.Size = new Size(34, 32);
            pictureBoxTab.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTab.TabIndex = 10;
            pictureBoxTab.TabStop = false;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxClose.Image = Properties.Resources.close_button;
            pictureBoxClose.Location = new Point(1201, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(34, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 9;
            pictureBoxClose.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(69, 31);
            label1.Name = "label1";
            label1.Size = new Size(169, 39);
            label1.TabIndex = 0;
            label1.Text = "Ürün Detay";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(69, 153);
            label2.Margin = new Padding(3, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 29);
            label2.TabIndex = 4;
            label2.Text = "Ürün No:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 56, 39);
            label3.Location = new Point(701, 258);
            label3.Margin = new Padding(3, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 29);
            label3.TabIndex = 5;
            label3.Text = "Stok:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 56, 39);
            label4.Location = new Point(69, 199);
            label4.Margin = new Padding(3, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 29);
            label4.TabIndex = 6;
            label4.Text = "Fabrika:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 56, 39);
            label5.Location = new Point(701, 212);
            label5.Margin = new Padding(3, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 29);
            label5.TabIndex = 7;
            label5.Text = "Fiyat";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(22, 56, 39);
            label6.Location = new Point(701, 166);
            label6.Margin = new Padding(3, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(47, 29);
            label6.TabIndex = 8;
            label6.Text = "Ad:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(22, 56, 39);
            label7.Location = new Point(69, 291);
            label7.Margin = new Padding(3, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 29);
            label7.TabIndex = 9;
            label7.Text = "Birim:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 56, 39);
            label8.Location = new Point(69, 245);
            label8.Margin = new Padding(3, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 29);
            label8.TabIndex = 10;
            label8.Text = "Kategori:";
            // 
            // textBoxProductNo
            // 
            textBoxProductNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxProductNo.BackColor = SystemColors.ActiveBorder;
            textBoxProductNo.BorderStyle = BorderStyle.FixedSingle;
            textBoxProductNo.Location = new Point(240, 153);
            textBoxProductNo.Name = "textBoxProductNo";
            textBoxProductNo.Size = new Size(306, 31);
            textBoxProductNo.TabIndex = 48;
            textBoxProductNo.TabStop = false;
            // 
            // textBoxCategoryNo
            // 
            textBoxCategoryNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxCategoryNo.BackColor = SystemColors.ActiveBorder;
            textBoxCategoryNo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCategoryNo.Location = new Point(240, 245);
            textBoxCategoryNo.Name = "textBoxCategoryNo";
            textBoxCategoryNo.Size = new Size(306, 31);
            textBoxCategoryNo.TabIndex = 47;
            textBoxCategoryNo.TabStop = false;
            // 
            // textBoxUnitNo
            // 
            textBoxUnitNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxUnitNo.BackColor = SystemColors.ActiveBorder;
            textBoxUnitNo.BorderStyle = BorderStyle.FixedSingle;
            textBoxUnitNo.Location = new Point(240, 289);
            textBoxUnitNo.Name = "textBoxUnitNo";
            textBoxUnitNo.Size = new Size(306, 31);
            textBoxUnitNo.TabIndex = 46;
            textBoxUnitNo.TabStop = false;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxName.BackColor = Color.LightYellow;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(816, 163);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(306, 31);
            textBoxName.TabIndex = 43;
            textBoxName.KeyPress += TextBoxName_KeyPress;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxPrice.BackColor = Color.LightYellow;
            textBoxPrice.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrice.Location = new Point(816, 210);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(306, 31);
            textBoxPrice.TabIndex = 44;
            textBoxPrice.KeyPress += TextBoxPrice_KeyPress;
            // 
            // textBoxStock
            // 
            textBoxStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxStock.BackColor = Color.LightYellow;
            textBoxStock.BorderStyle = BorderStyle.FixedSingle;
            textBoxStock.Location = new Point(816, 259);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(306, 31);
            textBoxStock.TabIndex = 45;
            textBoxStock.KeyPress += TextBoxStock_KeyPress;
            // 
            // textBoxFactoryNo
            // 
            textBoxFactoryNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxFactoryNo.BackColor = SystemColors.ActiveBorder;
            textBoxFactoryNo.BorderStyle = BorderStyle.FixedSingle;
            textBoxFactoryNo.Location = new Point(240, 199);
            textBoxFactoryNo.Name = "textBoxFactoryNo";
            textBoxFactoryNo.Size = new Size(306, 31);
            textBoxFactoryNo.TabIndex = 2;
            textBoxFactoryNo.TabStop = false;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.BackColor = Color.FromArgb(22, 56, 39);
            buttonDelete.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.AntiqueWhite;
            buttonDelete.Location = new Point(902, 456);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(96, 45);
            buttonDelete.TabIndex = 0;
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
            buttonSave.Location = new Point(1016, 456);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(160, 45);
            buttonSave.TabIndex = 1;
            buttonSave.TabStop = false;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(22, 56, 39);
            button1.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.AntiqueWhite;
            button1.Location = new Point(902, 396);
            button1.Name = "button1";
            button1.Size = new Size(274, 45);
            button1.TabIndex = 49;
            button1.TabStop = false;
            button1.Text = "Kısıtları Görüntüle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Image = Properties.Resources.back;
            pictureBoxBack.Location = new Point(4, 1);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(29, 32);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBack.TabIndex = 12;
            pictureBoxBack.TabStop = false;
            // 
            // ProductDetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1235, 559);
            Controls.Add(button1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFactoryNo);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(textBoxUnitNo);
            Controls.Add(textBoxCategoryNo);
            Controls.Add(textBoxProductNo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductDetailForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBoxStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxProductNo;
        private TextBox textBoxCategoryNo;
        private TextBox textBoxUnitNo;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private TextBox textBoxStock;
        private TextBox textBoxFactoryNo;
        private Button buttonDelete;
        private Button buttonSave;
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBoxTab;
        private PictureBox pictureBoxClose;
        private Button button1;
        private PictureBox pictureBoxBack;
    }
}