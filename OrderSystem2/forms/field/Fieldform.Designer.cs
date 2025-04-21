namespace OrderSystem2.forms.field
{
    partial class Fieldform
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
            label1 = new Label();
            dataGridField = new DataGridView();
            panel2 = new Panel();
            pictureBoxBack = new PictureBox();
            pictureBoxExpand = new PictureBox();
            pictureBoxTab = new PictureBox();
            pictureBoxClose = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridField).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.Font = new Font("Candara", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(554, 35);
            label1.Name = "label1";
            label1.Size = new Size(159, 43);
            label1.TabIndex = 0;
            label1.Text = "Tarla Listesi";
            // 
            // dataGridField
            // 
            dataGridField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridField.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridField.BackgroundColor = Color.AntiqueWhite;
            dataGridField.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridField.Location = new Point(0, 117);
            dataGridField.Name = "dataGridField";
            dataGridField.RowHeadersWidth = 62;
            dataGridField.Size = new Size(1235, 380);
            dataGridField.TabIndex = 4;
            dataGridField.CellDoubleClick += dataGridField_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 56, 39);
            panel2.Controls.Add(pictureBoxBack);
            panel2.Controls.Add(pictureBoxExpand);
            panel2.Controls.Add(pictureBoxTab);
            panel2.Controls.Add(pictureBoxClose);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1235, 118);
            panel2.TabIndex = 6;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Image = Properties.Resources.back;
            pictureBoxBack.Location = new Point(0, 0);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(29, 32);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBack.TabIndex = 10;
            pictureBoxBack.TabStop = false;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxExpand.Image = Properties.Resources.expand;
            pictureBoxExpand.Location = new Point(1171, 0);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(34, 32);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 8;
            pictureBoxExpand.TabStop = false;
            // 
            // pictureBoxTab
            // 
            pictureBoxTab.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxTab.Image = Properties.Resources.tab;
            pictureBoxTab.Location = new Point(1139, 0);
            pictureBoxTab.Name = "pictureBoxTab";
            pictureBoxTab.Size = new Size(34, 32);
            pictureBoxTab.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTab.TabIndex = 7;
            pictureBoxTab.TabStop = false;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxClose.Image = Properties.Resources.close_button;
            pictureBoxClose.Location = new Point(1201, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(34, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 6;
            pictureBoxClose.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.Font = new Font("Candara", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.AntiqueWhite;
            label3.Location = new Point(556, 46);
            label3.Name = "label3";
            label3.Size = new Size(180, 35);
            label3.TabIndex = 2;
            label3.Text = "Tarla Listesi";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.AntiqueWhite;
            label2.Location = new Point(1110, 21);
            label2.Name = "label2";
            label2.Size = new Size(122, 33);
            label2.TabIndex = 1;
            label2.Text = "Tarla Ekle";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 496);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 63);
            panel1.TabIndex = 7;
            // 
            // Fieldform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 559);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dataGridField);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fieldform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fieldform";
            ((System.ComponentModel.ISupportInitialize)dataGridField).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridField;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBoxTab;
        private PictureBox pictureBoxClose;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBoxBack;
    }
}