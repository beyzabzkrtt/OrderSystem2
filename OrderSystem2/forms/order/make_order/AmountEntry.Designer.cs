namespace OrderSystem2.forms.order
{
    partial class AmountEntry
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
            label2 = new Label();
            label3 = new Label();
            textBoxProduct = new TextBox();
            textBoxAreaSize = new TextBox();
            label4 = new Label();
            label6 = new Label();
            textBoxCondition = new TextBox();
            textBoxMaxAmount = new TextBox();
            label5 = new Label();
            label7 = new Label();
            textBoxLimit = new TextBox();
            label8 = new Label();
            textBoxAmount = new TextBox();
            buttonConfirm = new Button();
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
            panel1.Size = new Size(470, 99);
            panel1.TabIndex = 1;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxClose.Image = Properties.Resources.close_button;
            pictureBoxClose.Location = new Point(436, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(34, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 13;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(118, 32);
            label1.Name = "label1";
            label1.Size = new Size(230, 29);
            label1.TabIndex = 0;
            label1.Text = "Alınabilir Ürün Miktarı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(23, 129);
            label2.Name = "label2";
            label2.Size = new Size(121, 24);
            label2.TabIndex = 2;
            label2.Text = "Seçilen Ürün:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AntiqueWhite;
            label3.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 56, 39);
            label3.Location = new Point(23, 185);
            label3.Name = "label3";
            label3.Size = new Size(151, 24);
            label3.TabIndex = 3;
            label3.Text = "Tarla Büyüklüğü:";
            // 
            // textBoxProduct
            // 
            textBoxProduct.BackColor = SystemColors.ActiveBorder;
            textBoxProduct.BorderStyle = BorderStyle.FixedSingle;
            textBoxProduct.Location = new Point(183, 122);
            textBoxProduct.Name = "textBoxProduct";
            textBoxProduct.ReadOnly = true;
            textBoxProduct.Size = new Size(254, 31);
            textBoxProduct.TabIndex = 42;
            textBoxProduct.TabStop = false;
            // 
            // textBoxAreaSize
            // 
            textBoxAreaSize.BackColor = SystemColors.ActiveBorder;
            textBoxAreaSize.BorderStyle = BorderStyle.FixedSingle;
            textBoxAreaSize.Location = new Point(183, 174);
            textBoxAreaSize.Name = "textBoxAreaSize";
            textBoxAreaSize.ReadOnly = true;
            textBoxAreaSize.Size = new Size(254, 31);
            textBoxAreaSize.TabIndex = 41;
            textBoxAreaSize.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AntiqueWhite;
            label4.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 56, 39);
            label4.Location = new Point(23, 241);
            label4.Name = "label4";
            label4.Size = new Size(49, 24);
            label4.TabIndex = 26;
            label4.Text = "Şart:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.AntiqueWhite;
            label6.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(22, 56, 39);
            label6.Location = new Point(38, 390);
            label6.Name = "label6";
            label6.Size = new Size(236, 24);
            label6.TabIndex = 28;
            label6.Text = "Alınabilir En Yüksek Miktar:";
            // 
            // textBoxCondition
            // 
            textBoxCondition.BackColor = SystemColors.ActiveBorder;
            textBoxCondition.BorderStyle = BorderStyle.FixedSingle;
            textBoxCondition.Location = new Point(183, 223);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.ReadOnly = true;
            textBoxCondition.Size = new Size(254, 53);
            textBoxCondition.TabIndex = 40;
            textBoxCondition.TabStop = false;
            // 
            // textBoxMaxAmount
            // 
            textBoxMaxAmount.BackColor = SystemColors.ActiveBorder;
            textBoxMaxAmount.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaxAmount.Location = new Point(64, 427);
            textBoxMaxAmount.Name = "textBoxMaxAmount";
            textBoxMaxAmount.ReadOnly = true;
            textBoxMaxAmount.Size = new Size(178, 31);
            textBoxMaxAmount.TabIndex = 39;
            textBoxMaxAmount.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AntiqueWhite;
            label5.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 56, 39);
            label5.Location = new Point(17, 254);
            label5.Name = "label5";
            label5.Size = new Size(0, 24);
            label5.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AntiqueWhite;
            label7.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(22, 56, 39);
            label7.Location = new Point(23, 297);
            label7.Name = "label7";
            label7.Size = new Size(50, 24);
            label7.TabIndex = 33;
            label7.Text = "Kısıt:";
            // 
            // textBoxLimit
            // 
            textBoxLimit.BackColor = SystemColors.ActiveBorder;
            textBoxLimit.BorderStyle = BorderStyle.FixedSingle;
            textBoxLimit.Location = new Point(183, 299);
            textBoxLimit.Multiline = true;
            textBoxLimit.Name = "textBoxLimit";
            textBoxLimit.ReadOnly = true;
            textBoxLimit.Size = new Size(254, 53);
            textBoxLimit.TabIndex = 38;
            textBoxLimit.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AntiqueWhite;
            label8.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 56, 39);
            label8.Location = new Point(97, 481);
            label8.Name = "label8";
            label8.Size = new Size(114, 24);
            label8.TabIndex = 35;
            label8.Text = "Tutar Giriniz:";
            // 
            // textBoxAmount
            // 
            textBoxAmount.BackColor = Color.LightYellow;
            textBoxAmount.BorderStyle = BorderStyle.FixedSingle;
            textBoxAmount.Location = new Point(64, 518);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(178, 31);
            textBoxAmount.TabIndex = 36;
            textBoxAmount.KeyPress += TextBoxAmount_KeyPress;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.FromArgb(22, 56, 39);
            buttonConfirm.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonConfirm.ForeColor = Color.AntiqueWhite;
            buttonConfirm.Location = new Point(313, 541);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(138, 47);
            buttonConfirm.TabIndex = 37;
            buttonConfirm.Text = "Onayla";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // AmountEntry
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(470, 600);
            Controls.Add(buttonConfirm);
            Controls.Add(textBoxAmount);
            Controls.Add(label8);
            Controls.Add(textBoxLimit);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBoxMaxAmount);
            Controls.Add(textBoxCondition);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBoxAreaSize);
            Controls.Add(textBoxProduct);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AmountEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MakeOrder2Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxProduct;
        private TextBox textBoxAreaSize;
        private Label label4;
        private Label label6;
        private PictureBox pictureBoxClose;
        private TextBox textBoxCondition;
        private TextBox textBoxMaxAmount;
        private Label label5;
        private Label label7;
        private TextBox textBoxLimit;
        private Label label8;
        private TextBox textBoxAmount;
        private Button buttonConfirm;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}