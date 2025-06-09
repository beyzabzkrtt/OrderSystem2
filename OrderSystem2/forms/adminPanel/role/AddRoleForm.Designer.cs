namespace OrderSystem2.forms.adminPanel.role
{
    partial class AddRoleForm
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
            label8 = new Label();
            label7 = new Label();
            buttonSave = new Button();
            comboBoxRole = new ComboBox();
            comboBoxZone = new ComboBox();
            label2 = new Label();
            textBoxRole = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Click += pictureBoxClose_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 39);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(173, 27);
            label1.Name = "label1";
            label1.Size = new Size(156, 39);
            label1.TabIndex = 2;
            label1.Text = "Yetkilendir";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(22, 56, 39);
            label8.Location = new Point(48, 187);
            label8.Margin = new Padding(3, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(77, 29);
            label8.TabIndex = 77;
            label8.Text = "Bölge:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(22, 56, 39);
            label7.Location = new Point(48, 256);
            label7.Margin = new Padding(3, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(108, 29);
            label7.TabIndex = 76;
            label7.Text = "Pozisyon:";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(22, 56, 39);
            buttonSave.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.AntiqueWhite;
            buttonSave.Location = new Point(173, 558);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(160, 45);
            buttonSave.TabIndex = 78;
            buttonSave.TabStop = false;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = Color.LightYellow;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Kayseri", "Boğazlıyan", "Turhal" });
            comboBoxRole.Location = new Point(173, 256);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(238, 33);
            comboBoxRole.TabIndex = 79;
            comboBoxRole.TabStop = false;
            // 
            // comboBoxZone
            // 
            comboBoxZone.BackColor = Color.LightYellow;
            comboBoxZone.FormattingEnabled = true;
            comboBoxZone.Items.AddRange(new object[] { "Kayseri", "Boğazlıyan", "Turhal" });
            comboBoxZone.Location = new Point(173, 187);
            comboBoxZone.Name = "comboBoxZone";
            comboBoxZone.Size = new Size(238, 33);
            comboBoxZone.TabIndex = 80;
            comboBoxZone.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(164, 352);
            label2.Margin = new Padding(3, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(173, 29);
            label2.TabIndex = 81;
            label2.Text = "Oluşturulan Rol";
            // 
            // textBoxRole
            // 
            textBoxRole.BackColor = Color.LightYellow;
            textBoxRole.Location = new Point(110, 406);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.Size = new Size(277, 31);
            textBoxRole.TabIndex = 82;
            // 
            // AddRoleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 652);
            Controls.Add(textBoxRole);
            Controls.Add(label2);
            Controls.Add(comboBoxZone);
            Controls.Add(comboBoxRole);
            Controls.Add(buttonSave);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel1);
            Name = "AddRoleForm";
            Text = "AddRoleForm";
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(pictureBoxClose, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(buttonSave, 0);
            Controls.SetChildIndex(comboBoxRole, 0);
            Controls.SetChildIndex(comboBoxZone, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(textBoxRole, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label8;
        private Label label7;
        private Button buttonSave;
        private ComboBox comboBoxRole;
        private ComboBox comboBoxZone;
        private Label label2;
        private TextBox textBoxRole;
    }
}