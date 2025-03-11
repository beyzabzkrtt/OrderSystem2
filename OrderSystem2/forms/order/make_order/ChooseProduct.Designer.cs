namespace OrderSystem2.forms.order.make_order
{
    partial class ChooseProduct
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
            pictureBoxClose = new PictureBox();
            label1 = new Label();
            labelPlaceHolder3 = new Label();
            labelPlaceHolder2 = new Label();
            labelPlaceholder = new Label();
            comboBoxProduct = new ComboBox();
            label5 = new Label();
            comboBoxCategory = new ComboBox();
            label4 = new Label();
            comboBoxFactory = new ComboBox();
            labelFactory = new Label();
            textBoxFarmerId = new TextBox();
            label2 = new Label();
            buttonLater = new Button();
            label3 = new Label();
            comboBoxField = new ComboBox();
            labelPlaceHolderField = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 99);
            panel1.TabIndex = 1;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxClose.Image = Properties.Resources.close_button;
            pictureBoxClose.Location = new Point(414, 2);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(34, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 12;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(171, 34);
            label1.Name = "label1";
            label1.Size = new Size(104, 29);
            label1.TabIndex = 0;
            label1.Text = "Ürün Seç";
            // 
            // labelPlaceHolder3
            // 
            labelPlaceHolder3.AutoSize = true;
            labelPlaceHolder3.BackColor = Color.LightYellow;
            labelPlaceHolder3.ForeColor = SystemColors.ActiveBorder;
            labelPlaceHolder3.Location = new Point(182, 408);
            labelPlaceHolder3.Name = "labelPlaceHolder3";
            labelPlaceHolder3.Size = new Size(108, 25);
            labelPlaceHolder3.TabIndex = 57;
            labelPlaceHolder3.Text = "Ürün Seçiniz";
            // 
            // labelPlaceHolder2
            // 
            labelPlaceHolder2.AutoSize = true;
            labelPlaceHolder2.BackColor = Color.LightYellow;
            labelPlaceHolder2.ForeColor = SystemColors.ActiveBorder;
            labelPlaceHolder2.Location = new Point(182, 353);
            labelPlaceHolder2.Name = "labelPlaceHolder2";
            labelPlaceHolder2.Size = new Size(136, 25);
            labelPlaceHolder2.TabIndex = 56;
            labelPlaceHolder2.Text = "Kategori Seçiniz";
            // 
            // labelPlaceholder
            // 
            labelPlaceholder.AutoSize = true;
            labelPlaceholder.BackColor = Color.LightYellow;
            labelPlaceholder.ForeColor = SystemColors.ActiveBorder;
            labelPlaceholder.Location = new Point(180, 286);
            labelPlaceholder.Name = "labelPlaceholder";
            labelPlaceholder.Size = new Size(126, 25);
            labelPlaceholder.TabIndex = 55;
            labelPlaceholder.Text = "Fabrika Seçiniz";
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.BackColor = Color.LightYellow;
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(180, 405);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(185, 33);
            comboBoxProduct.TabIndex = 73;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AntiqueWhite;
            label5.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 56, 39);
            label5.Location = new Point(58, 409);
            label5.Name = "label5";
            label5.Size = new Size(58, 24);
            label5.TabIndex = 53;
            label5.Text = "Ürün:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = Color.LightYellow;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(180, 350);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(185, 33);
            comboBoxCategory.TabIndex = 71;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 56, 39);
            label4.Location = new Point(58, 343);
            label4.Name = "label4";
            label4.Size = new Size(87, 24);
            label4.TabIndex = 51;
            label4.Text = "Kategori:";
            // 
            // comboBoxFactory
            // 
            comboBoxFactory.BackColor = Color.LightYellow;
            comboBoxFactory.FormattingEnabled = true;
            comboBoxFactory.Items.AddRange(new object[] { "Kayseri", "Boğazlıyan", "Turhal" });
            comboBoxFactory.Location = new Point(179, 283);
            comboBoxFactory.Name = "comboBoxFactory";
            comboBoxFactory.Size = new Size(185, 33);
            comboBoxFactory.TabIndex = 70;
            // 
            // labelFactory
            // 
            labelFactory.AutoSize = true;
            labelFactory.BackColor = Color.AntiqueWhite;
            labelFactory.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFactory.ForeColor = Color.FromArgb(22, 56, 39);
            labelFactory.Location = new Point(58, 277);
            labelFactory.Name = "labelFactory";
            labelFactory.Size = new Size(77, 24);
            labelFactory.TabIndex = 47;
            labelFactory.Text = "Fabrika:";
            // 
            // textBoxFarmerId
            // 
            textBoxFarmerId.BackColor = SystemColors.ActiveBorder;
            textBoxFarmerId.BorderStyle = BorderStyle.FixedSingle;
            textBoxFarmerId.Location = new Point(180, 142);
            textBoxFarmerId.Name = "textBoxFarmerId";
            textBoxFarmerId.ReadOnly = true;
            textBoxFarmerId.Size = new Size(185, 31);
            textBoxFarmerId.TabIndex = 61;
            textBoxFarmerId.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(58, 145);
            label2.Name = "label2";
            label2.Size = new Size(85, 24);
            label2.TabIndex = 45;
            label2.Text = "Çiftçi No:";
            // 
            // buttonLater
            // 
            buttonLater.BackColor = Color.FromArgb(22, 56, 39);
            buttonLater.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLater.ForeColor = Color.AntiqueWhite;
            buttonLater.Location = new Point(249, 528);
            buttonLater.Name = "buttonLater";
            buttonLater.Size = new Size(176, 47);
            buttonLater.TabIndex = 75;
            buttonLater.Text = "Sonraki";
            buttonLater.UseVisualStyleBackColor = false;
            buttonLater.Click += buttonLater_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 56, 39);
            label3.Location = new Point(58, 216);
            label3.Name = "label3";
            label3.Size = new Size(56, 24);
            label3.TabIndex = 76;
            label3.Text = "Tarla:";
            // 
            // comboBoxField
            // 
            comboBoxField.BackColor = Color.LightYellow;
            comboBoxField.FormattingEnabled = true;
            comboBoxField.Items.AddRange(new object[] { "Kayseri", "Boğazlıyan", "Turhal" });
            comboBoxField.Location = new Point(180, 207);
            comboBoxField.Name = "comboBoxField";
            comboBoxField.Size = new Size(185, 33);
            comboBoxField.TabIndex = 77;
            comboBoxField.TabStop = false;
            // 
            // labelPlaceHolderField
            // 
            labelPlaceHolderField.AutoSize = true;
            labelPlaceHolderField.BackColor = Color.LightYellow;
            labelPlaceHolderField.ForeColor = SystemColors.ActiveBorder;
            labelPlaceHolderField.Location = new Point(181, 210);
            labelPlaceHolderField.Name = "labelPlaceHolderField";
            labelPlaceHolderField.Size = new Size(105, 25);
            labelPlaceHolderField.TabIndex = 78;
            labelPlaceHolderField.Text = "Tarla Seçiniz";
            // 
            // ChooseProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(450, 600);
            Controls.Add(labelPlaceHolderField);
            Controls.Add(comboBoxField);
            Controls.Add(label3);
            Controls.Add(buttonLater);
            Controls.Add(labelPlaceHolder3);
            Controls.Add(labelPlaceHolder2);
            Controls.Add(labelPlaceholder);
            Controls.Add(comboBoxProduct);
            Controls.Add(label5);
            Controls.Add(comboBoxCategory);
            Controls.Add(label4);
            Controls.Add(comboBoxFactory);
            Controls.Add(labelFactory);
            Controls.Add(textBoxFarmerId);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChooseProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MakeOrderLaterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Label label1;
        private Label labelPlaceHolder3;
        private Label labelPlaceHolder2;
        private Label labelPlaceholder;
        private ComboBox comboBoxProduct;
        private Label label5;
        private ComboBox comboBoxCategory;
        private Label label4;
        private ComboBox comboBoxFactory;
        private Label labelFactory;
        private TextBox textBoxFarmerId;
        private Label label2;
        private Button buttonLater;
        private Label label3;
        private ComboBox comboBoxField;
        private Label labelPlaceHolderField;
    }
}