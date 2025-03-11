namespace OrderSystem2.forms.order
{
    partial class OrderItemsForm
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
            labelCanceled = new Label();
            labelPaid = new Label();
            labelCompleted = new Label();
            dataGridOrderItem = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOrderItem).BeginInit();
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
            panel1.Size = new Size(1235, 109);
            panel1.TabIndex = 0;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Image = Properties.Resources.back;
            pictureBoxBack.Location = new Point(0, -1);
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
            pictureBoxExpand.Location = new Point(1171, -1);
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
            pictureBoxTab.Location = new Point(1139, -1);
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
            pictureBoxClose.Location = new Point(1201, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(34, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 6;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(85, 47);
            label1.Name = "label1";
            label1.Size = new Size(132, 29);
            label1.TabIndex = 2;
            label1.Text = "Ürün Listesi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 56, 39);
            panel2.Controls.Add(labelCanceled);
            panel2.Controls.Add(labelPaid);
            panel2.Controls.Add(labelCompleted);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 498);
            panel2.Name = "panel2";
            panel2.Size = new Size(1235, 61);
            panel2.TabIndex = 1;
            // 
            // labelCanceled
            // 
            labelCanceled.AutoSize = true;
            labelCanceled.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCanceled.ForeColor = Color.AntiqueWhite;
            labelCanceled.Location = new Point(1060, 15);
            labelCanceled.Name = "labelCanceled";
            labelCanceled.Size = new Size(163, 29);
            labelCanceled.TabIndex = 10;
            labelCanceled.Text = "Siparişi İptal Et";
            labelCanceled.Click += labelCanceled_Click;
            // 
            // labelPaid
            // 
            labelPaid.AutoSize = true;
            labelPaid.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaid.ForeColor = Color.AntiqueWhite;
            labelPaid.Location = new Point(288, 15);
            labelPaid.Name = "labelPaid";
            labelPaid.Size = new Size(146, 29);
            labelPaid.TabIndex = 11;
            labelPaid.Text = "Ödeme alındı";
            labelPaid.Click += labelPaid_Click;
            // 
            // labelCompleted
            // 
            labelCompleted.AutoSize = true;
            labelCompleted.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCompleted.ForeColor = Color.AntiqueWhite;
            labelCompleted.Location = new Point(26, 15);
            labelCompleted.Name = "labelCompleted";
            labelCompleted.Size = new Size(208, 29);
            labelCompleted.TabIndex = 12;
            labelCompleted.Text = "Sipariş Teslim Edildi";
            labelCompleted.Click += labelCompleted_Click;
            // 
            // dataGridOrderItem
            // 
            dataGridOrderItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridOrderItem.BackgroundColor = Color.AntiqueWhite;
            dataGridOrderItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrderItem.Dock = DockStyle.Fill;
            dataGridOrderItem.GridColor = Color.AntiqueWhite;
            dataGridOrderItem.Location = new Point(0, 109);
            dataGridOrderItem.Name = "dataGridOrderItem";
            dataGridOrderItem.RowHeadersWidth = 62;
            dataGridOrderItem.Size = new Size(1235, 389);
            dataGridOrderItem.TabIndex = 2;
            // 
            // OrderItemsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 559);
            Controls.Add(dataGridOrderItem);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderItemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderItemsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOrderItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridOrderItem;
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBoxTab;
        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxBack;
        private Label labelCanceled;
        private Label labelPaid;
        private Label labelCompleted;
    }
}