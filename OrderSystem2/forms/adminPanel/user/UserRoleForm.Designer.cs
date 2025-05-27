namespace OrderSystem2.forms.adminPanel.user
{
    partial class UserRoleForm
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
            textBoxRole = new TextBox();
            label8 = new Label();
            buttonChange = new Button();
            buttonDelete = new Button();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxRole
            // 
            textBoxRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxRole.BackColor = Color.LightYellow;
            textBoxRole.BorderStyle = BorderStyle.FixedSingle;
            textBoxRole.Location = new Point(124, 170);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.ReadOnly = true;
            textBoxRole.Size = new Size(274, 31);
            textBoxRole.TabIndex = 80;
            textBoxRole.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 56, 39);
            label8.Location = new Point(44, 170);
            label8.Margin = new Padding(3, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 29);
            label8.TabIndex = 79;
            label8.Text = "Yetki:";
            // 
            // buttonChange
            // 
            buttonChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonChange.BackColor = Color.FromArgb(22, 56, 39);
            buttonChange.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonChange.ForeColor = Color.AntiqueWhite;
            buttonChange.Location = new Point(229, 449);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(160, 45);
            buttonChange.TabIndex = 82;
            buttonChange.TabStop = false;
            buttonChange.Text = "Değiştir";
            buttonChange.UseVisualStyleBackColor = false;
            buttonChange.Click += buttonChange_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.BackColor = Color.FromArgb(22, 56, 39);
            buttonDelete.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.AntiqueWhite;
            buttonDelete.Location = new Point(50, 449);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(160, 45);
            buttonDelete.TabIndex = 83;
            buttonDelete.TabStop = false;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(143, 28);
            label1.Name = "label1";
            label1.Size = new Size(167, 39);
            label1.TabIndex = 2;
            label1.Text = "Yetki Detay";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 105);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close_button;
            pictureBox1.Location = new Point(411, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 84;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // UserRoleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 559);
            Controls.Add(buttonDelete);
            Controls.Add(buttonChange);
            Controls.Add(textBoxRole);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "UserRoleForm";
            Text = "UserRoleForm";
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(textBoxRole, 0);
            Controls.SetChildIndex(buttonChange, 0);
            Controls.SetChildIndex(buttonDelete, 0);
            Controls.SetChildIndex(pictureBoxClose, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxRole;
        private Label label8;
        private Button buttonChange;
        private Button buttonDelete;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}