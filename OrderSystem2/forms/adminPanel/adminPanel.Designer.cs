namespace OrderSystem2.forms.adminPanel
{
    partial class adminPanel
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelMakeOrder = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelMakeOrder);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 114);
            panel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Candara Light", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.AntiqueWhite;
            label3.Location = new Point(833, 44);
            label3.Name = "label3";
            label3.Size = new Size(163, 27);
            label3.TabIndex = 6;
            label3.Text = "Fabrika Yönetimi";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Candara Light", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.AntiqueWhite;
            label2.Location = new Point(647, 44);
            label2.Name = "label2";
            label2.Size = new Size(150, 27);
            label2.TabIndex = 5;
            label2.Text = "Bölge Yönetimi";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(471, 45);
            label1.Name = "label1";
            label1.Size = new Size(128, 27);
            label1.TabIndex = 4;
            label1.Text = "Rol Yönetimi";
            // 
            // labelMakeOrder
            // 
            labelMakeOrder.Anchor = AnchorStyles.Top;
            labelMakeOrder.AutoSize = true;
            labelMakeOrder.Font = new Font("Candara Light", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMakeOrder.ForeColor = Color.AntiqueWhite;
            labelMakeOrder.Location = new Point(266, 45);
            labelMakeOrder.Name = "labelMakeOrder";
            labelMakeOrder.Size = new Size(173, 27);
            labelMakeOrder.TabIndex = 3;
            labelMakeOrder.Text = "Kullanıcı Yönetimi";
            labelMakeOrder.Click += labelMakeOrder_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(60, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // adminPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 559);
            Controls.Add(panel1);
            Name = "adminPanel";
            Text = "adminPanel";
            Controls.SetChildIndex(panel1, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelMakeOrder;
    }
}