namespace OrderSystem2.forms
{
    partial class FarmerForm
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
            pictureBoxExpand = new PictureBox();
            pictureBoxTab = new PictureBox();
            pictureBoxBack = new PictureBox();
            pictureBoxClose = new PictureBox();
            labelAddFarmer = new Label();
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            dataGridFarmer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFarmer).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxExpand.Image = Properties.Resources.expand;
            pictureBoxExpand.Location = new Point(1171, -1);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(34, 32);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 5;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Parent = panel1;
            // 
            // pictureBoxTab
            // 
            pictureBoxTab.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxTab.Image = Properties.Resources.tab;
            pictureBoxTab.Location = new Point(1139, -1);
            pictureBoxTab.Name = "pictureBoxTab";
            pictureBoxTab.Size = new Size(34, 32);
            pictureBoxTab.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTab.TabIndex = 4;
            pictureBoxTab.TabStop = false;
            pictureBoxTab.Parent = panel1;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Image = Properties.Resources.back;
            pictureBoxBack.Location = new Point(0, -1);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(29, 32);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBack.TabIndex = 3;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Parent = panel1;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxClose.Image = Properties.Resources.close_button;
            pictureBoxClose.Location = new Point(1201, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(34, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 2;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.Parent = panel1;
            // 
            // labelAddFarmer
            // 
            labelAddFarmer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAddFarmer.AutoSize = true;
            labelAddFarmer.BackColor = Color.FromArgb(22, 56, 39);
            labelAddFarmer.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddFarmer.ForeColor = Color.AntiqueWhite;
            labelAddFarmer.Location = new Point(1111, 18);
            labelAddFarmer.Name = "labelAddFarmer";
            labelAddFarmer.Size = new Size(112, 29);
            labelAddFarmer.TabIndex = 0;
            labelAddFarmer.Text = "Çiftçi Ekle";
            labelAddFarmer.Click += labelAddFarmer_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 108);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(22, 56, 39);
            label6.Font = new Font("Candara", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.AntiqueWhite;
            label6.Location = new Point(540, 38);
            label6.Name = "label6";
            label6.Size = new Size(136, 35);
            label6.TabIndex = 1;
            label6.Text = "Çiftçi Liste";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 56, 39);
            panel2.Controls.Add(labelAddFarmer);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 493);
            panel2.Name = "panel2";
            panel2.Size = new Size(1235, 66);
            panel2.TabIndex = 10;
            // 
            // dataGridFarmer
            // 
            dataGridFarmer.BackgroundColor = Color.AntiqueWhite;
            dataGridFarmer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFarmer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridFarmer.Location = new Point(0, 108);
            dataGridFarmer.Name = "dataGridFarmer";
            dataGridFarmer.RowHeadersWidth = 62;
            dataGridFarmer.Size = new Size(1235, 385);
            dataGridFarmer.TabIndex = 11;
            // 
            // FarmerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 559);
            Controls.Add(dataGridFarmer);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FarmerForm";
            Text = "FarmerForm";
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(dataGridFarmer, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFarmer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelAddFarmer;
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBoxTab;
        private PictureBox pictureBoxBack;
        private PictureBox pictureBoxClose;
        private Panel panel1;
        private Label label6;
        private Panel panel2;
        private DataGridView dataGridFarmer;
    }
}