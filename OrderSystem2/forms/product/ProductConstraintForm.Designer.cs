namespace OrderSystem2.forms.product
{
    partial class ProductConstraintForm
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
            dataGridConstraint = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridConstraint).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridConstraint
            // 
            dataGridConstraint.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridConstraint.BackgroundColor = Color.AntiqueWhite;
            dataGridConstraint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridConstraint.Dock = DockStyle.Fill;
            dataGridConstraint.Location = new Point(0, 107);
            dataGridConstraint.Name = "dataGridConstraint";
            dataGridConstraint.RowHeadersWidth = 62;
            dataGridConstraint.Size = new Size(1235, 452);
            dataGridConstraint.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(512, 25);
            label1.Name = "label1";
            label1.Size = new Size(209, 44);
            label1.TabIndex = 0;
            label1.Text = "Ürün Kısıtları";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlDark;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 107);
            panel1.TabIndex = 0;
            // 
            // ProductConstraintForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1235, 559);
            Controls.Add(dataGridConstraint);
            Controls.Add(panel1);
            Name = "ProductConstraintForm";
            Text = "ProductConstraintForm";
            Controls.SetChildIndex(panel1, Controls.Count-1);
            Controls.SetChildIndex(dataGridConstraint, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridConstraint).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridConstraint;
        private Label label1;
        private Panel panel1;
    }
}