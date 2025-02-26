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
            pictureBoxClose = new PictureBox();
            label1 = new Label();
            label9 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxFactory = new TextBox();
            textBoxName = new TextBox();
            textBoxUnit = new TextBox();
            textBoxCategory = new TextBox();
            textBoxPrice = new TextBox();
            textBoxStok = new TextBox();
            buttonSave = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
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
            panel2.TabIndex = 4;
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
            pictureBoxClose.Click += pictureBoxClose_Click;
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
            label9.Location = new Point(80, 166);
            label9.Margin = new Padding(3, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(128, 29);
            label9.TabIndex = 11;
            label9.Text = "Fabrika No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(80, 442);
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
            label3.Location = new Point(80, 384);
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
            label4.Location = new Point(80, 329);
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
            label5.Location = new Point(80, 275);
            label5.Margin = new Padding(3, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 29);
            label5.TabIndex = 15;
            label5.Text = "Birim No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(22, 56, 39);
            label6.Location = new Point(80, 219);
            label6.Margin = new Padding(3, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 29);
            label6.TabIndex = 16;
            label6.Text = "Kategori No:";
            // 
            // textBoxFactory
            // 
            textBoxFactory.BackColor = Color.LightYellow;
            textBoxFactory.BorderStyle = BorderStyle.FixedSingle;
            textBoxFactory.Location = new Point(226, 164);
            textBoxFactory.Name = "textBoxFactory";
            textBoxFactory.Size = new Size(203, 31);
            textBoxFactory.TabIndex = 23;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.LightYellow;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(226, 330);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(203, 31);
            textBoxName.TabIndex = 26;
            // 
            // textBoxUnit
            // 
            textBoxUnit.BackColor = Color.LightYellow;
            textBoxUnit.BorderStyle = BorderStyle.FixedSingle;
            textBoxUnit.Location = new Point(226, 276);
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.Size = new Size(203, 31);
            textBoxUnit.TabIndex = 27;
            // 
            // textBoxCategory
            // 
            textBoxCategory.BackColor = Color.LightYellow;
            textBoxCategory.BorderStyle = BorderStyle.FixedSingle;
            textBoxCategory.Location = new Point(226, 219);
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(203, 31);
            textBoxCategory.TabIndex = 28;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.LightYellow;
            textBoxPrice.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrice.Location = new Point(226, 385);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(203, 31);
            textBoxPrice.TabIndex = 29;
            // 
            // textBoxStok
            // 
            textBoxStok.BackColor = Color.LightYellow;
            textBoxStok.BorderStyle = BorderStyle.FixedSingle;
            textBoxStok.Location = new Point(226, 443);
            textBoxStok.Name = "textBoxStok";
            textBoxStok.Size = new Size(203, 31);
            textBoxStok.TabIndex = 30;
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
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(524, 652);
            Controls.Add(buttonSave);
            Controls.Add(textBoxStok);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxCategory);
            Controls.Add(textBoxUnit);
            Controls.Add(textBoxName);
            Controls.Add(textBoxFactory);
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBoxClose;
        private Label label1;
        private Label label9;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxFactory;
        private TextBox textBoxName;
        private TextBox textBoxUnit;
        private TextBox textBoxCategory;
        private TextBox textBoxPrice;
        private TextBox textBoxStok;
        private Button buttonSave;
    }
}