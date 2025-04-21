namespace OrderSystem2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBoxTab = new PictureBox();
            pictureBoxClose = new PictureBox();
            pictureBoxExpand = new PictureBox();
            pictureBox1 = new PictureBox();
            labelFarmerMn = new Label();
            labelFieldMn = new Label();
            labelProductMn = new Label();
            labelOrderMn = new Label();
            labelMakeOrder = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label8 = new Label();
            label1 = new Label();
            comboBoxManager = new ComboBox();
            comboBoxLiable = new ComboBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBoxTab);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(pictureBoxExpand);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelFarmerMn);
            panel1.Controls.Add(labelFieldMn);
            panel1.Controls.Add(labelProductMn);
            panel1.Controls.Add(labelOrderMn);
            panel1.Controls.Add(labelMakeOrder);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1118, 115);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AntiqueWhite;
            panel3.Location = new Point(0, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(1118, 336);
            panel3.TabIndex = 2;
            // 
            // pictureBoxTab
            // 
            pictureBoxTab.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxTab.Image = Properties.Resources.tab;
            pictureBoxTab.Location = new Point(1027, 0);
            pictureBoxTab.Name = "pictureBoxTab";
            pictureBoxTab.Size = new Size(32, 31);
            pictureBoxTab.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTab.TabIndex = 8;
            pictureBoxTab.TabStop = false;
            pictureBoxTab.Click += pictureBoxTab_Click;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxClose.Image = Properties.Resources.close_button;
            pictureBoxClose.Location = new Point(1086, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(32, 31);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 10;
            pictureBoxClose.TabStop = false;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxExpand.Image = Properties.Resources.expand;
            pictureBoxExpand.Location = new Point(1057, 0);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(32, 31);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 9;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelFarmerMn
            // 
            labelFarmerMn.Anchor = AnchorStyles.Top;
            labelFarmerMn.AutoSize = true;
            labelFarmerMn.Font = new Font("Candara Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFarmerMn.ForeColor = Color.AntiqueWhite;
            labelFarmerMn.Location = new Point(729, 46);
            labelFarmerMn.Name = "labelFarmerMn";
            labelFarmerMn.Size = new Size(128, 24);
            labelFarmerMn.TabIndex = 6;
            labelFarmerMn.Text = "Çiftçi Yönetimi";
            labelFarmerMn.Click += labelFarmerMn_Click;
            // 
            // labelFieldMn
            // 
            labelFieldMn.Anchor = AnchorStyles.Top;
            labelFieldMn.AutoSize = true;
            labelFieldMn.Font = new Font("Candara Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFieldMn.ForeColor = Color.AntiqueWhite;
            labelFieldMn.Location = new Point(912, 46);
            labelFieldMn.Name = "labelFieldMn";
            labelFieldMn.Size = new Size(126, 24);
            labelFieldMn.TabIndex = 5;
            labelFieldMn.Text = "Tarla Yönetimi";
            labelFieldMn.Click += labelFieldMn_Click;
            // 
            // labelProductMn
            // 
            labelProductMn.Anchor = AnchorStyles.Top;
            labelProductMn.AutoSize = true;
            labelProductMn.Font = new Font("Candara Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelProductMn.ForeColor = Color.AntiqueWhite;
            labelProductMn.Location = new Point(546, 46);
            labelProductMn.Name = "labelProductMn";
            labelProductMn.Size = new Size(129, 24);
            labelProductMn.TabIndex = 4;
            labelProductMn.Text = "Ürün Yönetimi";
            labelProductMn.Click += labelProductMn_Click;
            // 
            // labelOrderMn
            // 
            labelOrderMn.Anchor = AnchorStyles.Top;
            labelOrderMn.AutoSize = true;
            labelOrderMn.Font = new Font("Candara Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOrderMn.ForeColor = Color.AntiqueWhite;
            labelOrderMn.Location = new Point(350, 46);
            labelOrderMn.Name = "labelOrderMn";
            labelOrderMn.Size = new Size(140, 24);
            labelOrderMn.TabIndex = 3;
            labelOrderMn.Text = "Sipariş Yönetimi";
            labelOrderMn.Click += labelOrderMn_Click;
            // 
            // labelMakeOrder
            // 
            labelMakeOrder.Anchor = AnchorStyles.Top;
            labelMakeOrder.AutoSize = true;
            labelMakeOrder.Font = new Font("Candara Light", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMakeOrder.ForeColor = Color.AntiqueWhite;
            labelMakeOrder.Location = new Point(167, 46);
            labelMakeOrder.Name = "labelMakeOrder";
            labelMakeOrder.Size = new Size(128, 24);
            labelMakeOrder.TabIndex = 2;
            labelMakeOrder.Text = "Sipariş Oluştur";
            labelMakeOrder.Click += labelMakeOrder_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(270, 161);
            label2.Name = "label2";
            label2.Size = new Size(179, 24);
            label2.TabIndex = 11;
            label2.Text = "Yönetici Paneli            ";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.Image = Properties.Resources.floters_Photoroom;
            pictureBox3.Location = new Point(-44, 109);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(189, 324);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.flor_Photoroom;
            pictureBox2.Location = new Point(928, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(238, 313);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 56, 39);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 446);
            panel2.Name = "panel2";
            panel2.Size = new Size(1118, 50);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.AntiqueWhite;
            label8.Location = new Point(12, 12);
            label8.Name = "label8";
            label8.Size = new Size(75, 29);
            label8.TabIndex = 17;
            label8.Text = "Rapor";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1032, 12);
            label1.Name = "label1";
            label1.Size = new Size(83, 24);
            label1.TabIndex = 0;
            label1.Text = "Çıkış Yap";
            label1.Click += label1_Click;
            // 
            // comboBoxManager
            // 
            comboBoxManager.BackColor = Color.AntiqueWhite;
            comboBoxManager.ForeColor = Color.FromArgb(22, 59, 36);
            comboBoxManager.FormattingEnabled = true;
            comboBoxManager.Items.AddRange(new object[] { "Kullanıcı Yönetimi", "Rol Yönetimi", "Fabrika Yönetimi", "Bölge Yönetimi" });
            comboBoxManager.Location = new Point(268, 159);
            comboBoxManager.Name = "comboBoxManager";
            comboBoxManager.Size = new Size(222, 32);
            comboBoxManager.TabIndex = 19;
            comboBoxManager.TabStop = false;
            // 
            // comboBoxLiable
            // 
            comboBoxLiable.BackColor = Color.AntiqueWhite;
            comboBoxLiable.ForeColor = Color.FromArgb(22, 59, 36);
            comboBoxLiable.FormattingEnabled = true;
            comboBoxLiable.Items.AddRange(new object[] { "Ürün Kısıt Yönetimi", "Ürün Birim Yönetimi" });
            comboBoxLiable.Location = new Point(559, 159);
            comboBoxLiable.Name = "comboBoxLiable";
            comboBoxLiable.Size = new Size(222, 32);
            comboBoxLiable.TabIndex = 20;
            comboBoxLiable.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.FromArgb(22, 56, 39);
            label4.Location = new Point(562, 162);
            label4.Name = "label4";
            label4.Size = new Size(136, 24);
            label4.TabIndex = 22;
            label4.Text = "Sorumlu Paneli";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1118, 496);
            Controls.Add(label4);
            Controls.Add(comboBoxLiable);
            Controls.Add(label2);
            Controls.Add(comboBoxManager);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.AntiqueWhite;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label labelMakeOrder;
        private PictureBox pictureBox1;
        private Label labelFarmerMn;
        private Label labelFieldMn;
        private Label labelProductMn;
        private Label labelOrderMn;
        private Panel panel3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBoxTab;
        private PictureBox pictureBoxClose;
        private Label label1;
        private Label label8;
        private Label label2;
        private ComboBox comboBoxManager;
        private ComboBox comboBoxLiable;
        private Label label4;
    }
}
