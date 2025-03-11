namespace OrderSystem2.forms.order.make_order
{
    partial class ConfirmORder
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
            dataGridOrderItems = new DataGridView();
            buttonAdd = new Button();
            label8 = new Label();
            textBoxTotal = new TextBox();
            buttonComplete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrderItems).BeginInit();
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
            panel1.Size = new Size(547, 99);
            panel1.TabIndex = 2;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBoxClose.Image = Properties.Resources.close_button;
            pictureBoxClose.Location = new Point(513, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(34, 32);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 13;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(213, 31);
            label1.Name = "label1";
            label1.Size = new Size(136, 29);
            label1.TabIndex = 0;
            label1.Text = "Sipariş Onay";
            // 
            // dataGridOrderItems
            // 
            dataGridOrderItems.BackgroundColor = Color.AntiqueWhite;
            dataGridOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrderItems.Location = new Point(0, 96);
            dataGridOrderItems.Name = "dataGridOrderItems";
            dataGridOrderItems.ReadOnly = true;
            dataGridOrderItems.RowHeadersWidth = 62;
            dataGridOrderItems.Size = new Size(547, 316);
            dataGridOrderItems.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(22, 56, 39);
            buttonAdd.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.AntiqueWhite;
            buttonAdd.Location = new Point(76, 514);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(176, 47);
            buttonAdd.TabIndex = 36;
            buttonAdd.Text = "Ürün Ekle";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AntiqueWhite;
            label8.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 56, 39);
            label8.Location = new Point(99, 446);
            label8.Name = "label8";
            label8.Size = new Size(153, 29);
            label8.TabIndex = 37;
            label8.Text = "Toplam Tutar:";
            // 
            // textBoxTotal
            // 
            textBoxTotal.BackColor = Color.LightYellow;
            textBoxTotal.BorderStyle = BorderStyle.FixedSingle;
            textBoxTotal.Location = new Point(277, 447);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(178, 31);
            textBoxTotal.TabIndex = 40;
            textBoxTotal.TabStop = false;
            // 
            // buttonComplete
            // 
            buttonComplete.BackColor = Color.FromArgb(22, 56, 39);
            buttonComplete.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonComplete.ForeColor = Color.AntiqueWhite;
            buttonComplete.Location = new Point(292, 514);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new Size(176, 47);
            buttonComplete.TabIndex = 39;
            buttonComplete.Text = "Tamamla";
            buttonComplete.UseVisualStyleBackColor = false;
            buttonComplete.Click += buttonComplete_Click;
            // 
            // ConfirmORder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(547, 600);
            Controls.Add(buttonComplete);
            Controls.Add(textBoxTotal);
            Controls.Add(label8);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridOrderItems);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmORder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MakeOrder3cs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Label label1;
        private DataGridView dataGridOrderItems;
        private Button buttonAdd;
        private Label label8;
        private TextBox textBoxTotal;
        private Button buttonComplete;
    }
}