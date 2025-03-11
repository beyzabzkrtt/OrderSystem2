namespace OrderSystem2.forms.order
{
    partial class MakeOrderForm
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
            textBoxFarmerId = new TextBox();
            buttonLater = new Button();
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
            panel1.Size = new Size(430, 99);
            panel1.TabIndex = 0;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxClose.Image = Properties.Resources.close_button;
            pictureBoxClose.Location = new Point(396, 0);
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
            label1.Location = new Point(142, 32);
            label1.Name = "label1";
            label1.Size = new Size(158, 29);
            label1.TabIndex = 0;
            label1.Text = "Sipariş Oluştur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(75, 184);
            label2.Name = "label2";
            label2.Size = new Size(85, 24);
            label2.TabIndex = 1;
            label2.Text = "Çiftçi No:";
            // 
            // textBoxFarmerId
            // 
            textBoxFarmerId.BackColor = Color.LightYellow;
            textBoxFarmerId.BorderStyle = BorderStyle.FixedSingle;
            textBoxFarmerId.Location = new Point(174, 181);
            textBoxFarmerId.Name = "textBoxFarmerId";
            textBoxFarmerId.Size = new Size(185, 31);
            textBoxFarmerId.TabIndex = 23;
            textBoxFarmerId.KeyPress += TextBoxFarmerId_KeyPress;
            // 
            // buttonLater
            // 
            buttonLater.BackColor = Color.FromArgb(22, 56, 39);
            buttonLater.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLater.ForeColor = Color.AntiqueWhite;
            buttonLater.Location = new Point(235, 526);
            buttonLater.Name = "buttonLater";
            buttonLater.Size = new Size(176, 47);
            buttonLater.TabIndex = 35;
            buttonLater.Text = "Sonraki";
            buttonLater.UseVisualStyleBackColor = false;
            buttonLater.Click += buttonLater_Click;
            // 
            // MakeOrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(430, 600);
            Controls.Add(buttonLater);
            Controls.Add(textBoxFarmerId);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MakeOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MakeOrderForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBoxFarmerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBoxFarmerId;
        private Button buttonLater;
        private PictureBox pictureBoxClose;
    }
}