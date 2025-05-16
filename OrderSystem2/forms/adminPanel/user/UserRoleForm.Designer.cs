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
            panel1 = new Panel();
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 105);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(91, 31);
            label1.Name = "label1";
            label1.Size = new Size(167, 39);
            label1.TabIndex = 2;
            label1.Text = "Yetki Detay";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxName.BackColor = Color.LightYellow;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Location = new Point(248, 173);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(306, 31);
            textBoxName.TabIndex = 80;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxSurname.BackColor = Color.LightYellow;
            textBoxSurname.BorderStyle = BorderStyle.FixedSingle;
            textBoxSurname.Location = new Point(248, 225);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(306, 31);
            textBoxSurname.TabIndex = 81;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 56, 39);
            label8.Location = new Point(91, 173);
            label8.Margin = new Padding(3, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(69, 29);
            label8.TabIndex = 79;
            label8.Text = "Yetki:";
            // 
            // UserRoleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 559);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSurname);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "UserRoleForm";
            Text = "UserRoleForm";
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(textBoxSurname, 0);
            Controls.SetChildIndex(textBoxName, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Label label8;
    }
}