﻿namespace OrderSystem2.forms.adminPanel.zone
{
    partial class ZoneForm
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
            label1 = new Label();
            dataGridZones = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridZones).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 108);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(89, 28);
            label1.Name = "label1";
            label1.Size = new Size(126, 39);
            label1.TabIndex = 3;
            label1.Text = "Bölgeler";
            // 
            // dataGridZones
            // 
            dataGridZones.AllowUserToAddRows = false;
            dataGridZones.BackgroundColor = Color.AntiqueWhite;
            dataGridZones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridZones.Location = new Point(0, 108);
            dataGridZones.Name = "dataGridZones";
            dataGridZones.RowHeadersWidth = 62;
            dataGridZones.Size = new Size(1235, 394);
            dataGridZones.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 56, 39);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 501);
            panel2.Name = "panel2";
            panel2.Size = new Size(1235, 58);
            panel2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.AntiqueWhite;
            label2.Location = new Point(1105, 14);
            label2.Name = "label2";
            label2.Size = new Size(115, 29);
            label2.TabIndex = 4;
            label2.Text = "Bölge Ekle";
            label2.Click += label2_Click;
            // 
            // ZoneForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 559);
            Controls.Add(panel2);
            Controls.Add(dataGridZones);
            Controls.Add(panel1);
            Name = "ZoneForm";
            Text = "ZoneFomr";
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(dataGridZones, 0);
            Controls.SetChildIndex(panel2, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridZones).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridZones;
        private Panel panel2;
        private Label label2;
    }
}