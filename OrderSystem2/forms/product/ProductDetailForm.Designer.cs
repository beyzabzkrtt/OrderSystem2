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
            textBoxCreatedBy = new TextBox();
            textBoxCreatedAt = new TextBox();
            textBoxUpdatedBy = new TextBox();
            textBoxupdatedAt = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            textBoxProductNo = new TextBox();
            textBoxCategoryNo = new TextBox();
            textBoxUnitNo = new TextBox();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxStock = new TextBox();
            textBoxFactoryNo = new TextBox();
            buttonDelete = new Button();
            buttonSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
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
            pictureBoxExpand.Click += pictureBoxExpand_Click;
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
            pictureBoxTab.Click += pictureBoxTab_Click;
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
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(40, 30);
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
            label3.Location = new Point(69, 429);
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
            label4.Size = new Size(128, 29);
            label4.TabIndex = 6;
            label4.Text = "Fabrika No:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 56, 39);
            label5.Location = new Point(69, 383);
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
            label6.Location = new Point(69, 337);
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
            label7.Size = new Size(106, 29);
            label7.TabIndex = 9;
            label7.Text = "Birim No:";
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
            label8.Size = new Size(140, 29);
            label8.TabIndex = 10;
            label8.Text = "Kategori No:";
            // 
            // textBoxCreatedBy
            // 
            textBoxCreatedBy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxCreatedBy.BackColor = Color.LightYellow;
            textBoxCreatedBy.BorderStyle = BorderStyle.FixedSingle;
            textBoxCreatedBy.Location = new Point(839, 156);
            textBoxCreatedBy.Name = "textBoxCreatedBy";
            textBoxCreatedBy.Size = new Size(306, 31);
            textBoxCreatedBy.TabIndex = 38;
            // 
            // textBoxCreatedAt
            // 
            textBoxCreatedAt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxCreatedAt.BackColor = Color.LightYellow;
            textBoxCreatedAt.BorderStyle = BorderStyle.FixedSingle;
            textBoxCreatedAt.Location = new Point(839, 200);
            textBoxCreatedAt.Name = "textBoxCreatedAt";
            textBoxCreatedAt.Size = new Size(306, 31);
            textBoxCreatedAt.TabIndex = 37;
            // 
            // textBoxUpdatedBy
            // 
            textBoxUpdatedBy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxUpdatedBy.BackColor = Color.LightYellow;
            textBoxUpdatedBy.BorderStyle = BorderStyle.FixedSingle;
            textBoxUpdatedBy.Location = new Point(839, 242);
            textBoxUpdatedBy.Name = "textBoxUpdatedBy";
            textBoxUpdatedBy.Size = new Size(306, 31);
            textBoxUpdatedBy.TabIndex = 36;
            // 
            // textBoxupdatedAt
            // 
            textBoxupdatedAt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxupdatedAt.BackColor = Color.LightYellow;
            textBoxupdatedAt.BorderStyle = BorderStyle.FixedSingle;
            textBoxupdatedAt.Location = new Point(839, 285);
            textBoxupdatedAt.Name = "textBoxupdatedAt";
            textBoxupdatedAt.Size = new Size(306, 31);
            textBoxupdatedAt.TabIndex = 35;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(22, 56, 39);
            label13.Location = new Point(632, 243);
            label13.Name = "label13";
            label13.Size = new Size(143, 29);
            label13.TabIndex = 34;
            label13.Text = "Güncelleyen:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(22, 56, 39);
            label12.Location = new Point(632, 283);
            label12.Name = "label12";
            label12.Size = new Size(199, 29);
            label12.TabIndex = 33;
            label12.Text = "Güncelleme Tarihi:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(22, 56, 39);
            label11.Location = new Point(632, 197);
            label11.Name = "label11";
            label11.Size = new Size(130, 29);
            label11.TabIndex = 32;
            label11.Text = "Kayıt Tarihi:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(22, 56, 39);
            label10.Location = new Point(632, 153);
            label10.Name = "label10";
            label10.Size = new Size(181, 29);
            label10.TabIndex = 31;
            label10.Text = "Kaydı Oluşturan:";
            // 
            // textBoxProductNo
            // 
            textBoxProductNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxProductNo.BackColor = Color.LightYellow;
            textBoxProductNo.BorderStyle = BorderStyle.FixedSingle;
            textBoxProductNo.Location = new Point(240, 153);
            textBoxProductNo.Name = "textBoxProductNo";
            textBoxProductNo.Size = new Size(306, 31);
            textBoxProductNo.TabIndex = 39;
            // 
            // textBoxCategoryNo
            // 
            textBoxCategoryNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxCategoryNo.BackColor = Color.LightYellow;
            textBoxCategoryNo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCategoryNo.Location = new Point(240, 245);
            textBoxCategoryNo.Name = "textBoxCategoryNo";
            textBoxCategoryNo.Size = new Size(306, 31);
            textBoxCategoryNo.TabIndex = 41;
            // 
            // textBoxUnitNo
            // 
            textBoxUnitNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxUnitNo.BackColor = Color.LightYellow;
            textBoxUnitNo.BorderStyle = BorderStyle.FixedSingle;
            textBoxUnitNo.Location = new Point(240, 289);
            textBoxUnitNo.Name = "textBoxUnitNo";
            textBoxUnitNo.Size = new Size(306, 31);
            textBoxUnitNo.TabIndex = 42;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxName.BackColor = Color.LightYellow;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(240, 334);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(306, 31);
            textBoxName.TabIndex = 43;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxPrice.BackColor = Color.LightYellow;
            textBoxPrice.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrice.Location = new Point(240, 381);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(306, 31);
            textBoxPrice.TabIndex = 44;
            // 
            // textBoxStock
            // 
            textBoxStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxStock.BackColor = Color.LightYellow;
            textBoxStock.BorderStyle = BorderStyle.FixedSingle;
            textBoxStock.Location = new Point(240, 430);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(306, 31);
            textBoxStock.TabIndex = 45;
            // 
            // textBoxFactoryNo
            // 
            textBoxFactoryNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxFactoryNo.BackColor = Color.LightYellow;
            textBoxFactoryNo.BorderStyle = BorderStyle.FixedSingle;
            textBoxFactoryNo.Location = new Point(240, 199);
            textBoxFactoryNo.Name = "textBoxFactoryNo";
            textBoxFactoryNo.Size = new Size(306, 31);
            textBoxFactoryNo.TabIndex = 46;
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
            buttonDelete.TabIndex = 48;
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
            buttonSave.TabIndex = 47;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // ProductDetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1235, 559);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFactoryNo);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(textBoxUnitNo);
            Controls.Add(textBoxCategoryNo);
            Controls.Add(textBoxProductNo);
            Controls.Add(textBoxCreatedBy);
            Controls.Add(textBoxCreatedAt);
            Controls.Add(textBoxUpdatedBy);
            Controls.Add(textBoxupdatedAt);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
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
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox textBoxCreatedBy;
        private TextBox textBoxCreatedAt;
        private TextBox textBoxUpdatedBy;
        private TextBox textBoxupdatedAt;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
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
    }
}