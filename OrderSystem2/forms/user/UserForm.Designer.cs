namespace OrderSystem2.forms.user
{
    partial class UserForm
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
            pictureBoxBack = new PictureBox();
            pictureBoxExpand = new PictureBox();
            pictureBoxTab = new PictureBox();
            pictureBoxClose = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            labelAddFarmer = new Label();
            dataGridUsers = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(pictureBoxBack);
            panel1.Controls.Add(pictureBoxExpand);
            panel1.Controls.Add(pictureBoxTab);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1118, 88);
            panel1.TabIndex = 0;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Image = Properties.Resources.back;
            pictureBoxBack.Location = new Point(0, 0);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(29, 32);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBack.TabIndex = 9;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxExpand.Image = Properties.Resources.expand;
            pictureBoxExpand.Location = new Point(1051, 3);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(34, 32);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 8;
            pictureBoxExpand.TabStop = false;
            pictureBoxExpand.Click += pictureBoxExpand_Click;
            // 
            // pictureBoxTab
            // 
            pictureBoxTab.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxTab.Image = Properties.Resources.tab;
            pictureBoxTab.Location = new Point(1019, 3);
            pictureBoxTab.Name = "pictureBoxTab";
            pictureBoxTab.Size = new Size(34, 32);
            pictureBoxTab.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTab.TabIndex = 7;
            pictureBoxTab.TabStop = false;
            pictureBoxTab.Click += pictureBoxTab_Click;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxClose.Image = Properties.Resources.close_button;
            pictureBoxClose.Location = new Point(1081, 3);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(34, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 6;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.Font = new Font("Candara", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(470, 24);
            label1.Name = "label1";
            label1.Size = new Size(214, 36);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Listesi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 56, 39);
            panel2.Controls.Add(labelAddFarmer);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 435);
            panel2.Name = "panel2";
            panel2.Size = new Size(1118, 61);
            panel2.TabIndex = 1;
            // 
            // labelAddFarmer
            // 
            labelAddFarmer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelAddFarmer.AutoSize = true;
            labelAddFarmer.BackColor = Color.FromArgb(22, 56, 39);
            labelAddFarmer.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddFarmer.ForeColor = Color.AntiqueWhite;
            labelAddFarmer.Location = new Point(963, 14);
            labelAddFarmer.Name = "labelAddFarmer";
            labelAddFarmer.Size = new Size(146, 29);
            labelAddFarmer.TabIndex = 1;
            labelAddFarmer.Text = "Kullanıcı Ekle";
            // 
            // dataGridUsers
            // 
            dataGridUsers.BackgroundColor = Color.AntiqueWhite;
            dataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsers.Dock = DockStyle.Fill;
            dataGridUsers.Location = new Point(0, 88);
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.RowHeadersWidth = 62;
            dataGridUsers.Size = new Size(1118, 347);
            dataGridUsers.TabIndex = 2;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1118, 496);
            Controls.Add(dataGridUsers);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridUsers;
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBoxTab;
        private PictureBox pictureBoxClose;
        private Label labelAddFarmer;
        private PictureBox pictureBoxBack;
    }
}