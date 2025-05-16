namespace OrderSystem2.forms.liablePanel
{
    partial class LiablePanel
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
            pictureBox1 = new PictureBox();
            labelMakeOrder = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelMakeOrder);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 114);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(67, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelMakeOrder
            // 
            labelMakeOrder.Anchor = AnchorStyles.Top;
            labelMakeOrder.AutoSize = true;
            labelMakeOrder.Font = new Font("Candara Light", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMakeOrder.ForeColor = Color.AntiqueWhite;
            labelMakeOrder.Location = new Point(359, 44);
            labelMakeOrder.Name = "labelMakeOrder";
            labelMakeOrder.Size = new Size(195, 27);
            labelMakeOrder.TabIndex = 4;
            labelMakeOrder.Text = "Ürün Birim Yönetimi";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(700, 44);
            label1.Name = "label1";
            label1.Size = new Size(187, 27);
            label1.TabIndex = 5;
            label1.Text = "Ürün Kısıt Yönetimi";
            // 
            // LiablePanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 559);
            Controls.Add(panel1);
            Name = "LiablePanel";
            Text = "LiablePanel";
            Controls.SetChildIndex(panel1, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label labelMakeOrder;
    }
}