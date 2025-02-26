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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmerForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel2 = new Panel();
            pictureBoxExpand = new PictureBox();
            pictureBoxTab = new PictureBox();
            pictureBoxBack = new PictureBox();
            pictureBoxClose = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridFarmer = new DataGridView();
            panel1 = new Panel();
            labelAddFarmer = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridFarmer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 56, 39);
            panel2.Controls.Add(pictureBoxExpand);
            panel2.Controls.Add(pictureBoxTab);
            panel2.Controls.Add(pictureBoxBack);
            panel2.Controls.Add(pictureBoxClose);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1235, 114);
            panel2.TabIndex = 2;
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
            pictureBoxTab.Click += pictureBoxTab_Click;
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
            pictureBoxBack.Click += pictureBoxBack_Click;
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
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.Font = new Font("Candara", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(577, 40);
            label1.Name = "label1";
            label1.Size = new Size(144, 36);
            label1.TabIndex = 0;
            label1.Text = "Çiftçi Liste";
            // 
            // dataGridFarmer
            // 
            dataGridViewCellStyle1.BackColor = Color.AntiqueWhite;
            dataGridViewCellStyle1.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(22, 56, 39);
            dataGridViewCellStyle1.SelectionBackColor = Color.PapayaWhip;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(22, 56, 39);          
            dataGridFarmer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridFarmer.Dock = DockStyle.Fill;
            dataGridFarmer.BackgroundColor = Color.AntiqueWhite;
            dataGridFarmer.CellBorderStyle = DataGridViewCellBorderStyle.Raised;            
            dataGridFarmer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridFarmer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFarmer.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridFarmer.GridColor = Color.AntiqueWhite;
            dataGridFarmer.Location = new Point(0, 114);
            dataGridFarmer.Name = "dataGridFarmer";
            dataGridFarmer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridFarmer.RowHeadersWidth = 62;
            dataGridFarmer.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridFarmer.Size = new Size(1235, 389);
            dataGridFarmer.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(labelAddFarmer);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 498);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 61);
            panel1.TabIndex = 4;
            // 
            // labelAddFarmer
            // 
            labelAddFarmer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAddFarmer.AutoSize = true;
            labelAddFarmer.BackColor = Color.FromArgb(22, 56, 39);
            labelAddFarmer.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddFarmer.ForeColor = Color.AntiqueWhite;
            labelAddFarmer.Location = new Point(1093, 23);
            labelAddFarmer.Name = "labelAddFarmer";
            labelAddFarmer.Size = new Size(112, 29);
            labelAddFarmer.TabIndex = 0;
            labelAddFarmer.Text = "Çiftçi Ekle";
            labelAddFarmer.Click += labelAddFarmer_Click;
            // 
            // FarmerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 559);
            Controls.Add(panel1);
            Controls.Add(dataGridFarmer);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FarmerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FarmerForm";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridFarmer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridFarmer;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBoxClose;
        private Panel panel1;
        private Label labelAddFarmer;
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBoxTab;
        private PictureBox pictureBoxBack;
    }
}