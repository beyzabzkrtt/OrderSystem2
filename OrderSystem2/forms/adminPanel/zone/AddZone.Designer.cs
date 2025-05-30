namespace OrderSystem2.forms.adminPanel.zone
{
    partial class AddZone
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
            label2 = new Label();
            label3 = new Label();
            comboBoxFactory = new ComboBox();
            textBoxName = new TextBox();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
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
            panel1.Size = new Size(493, 97);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(160, 25);
            label1.Name = "label1";
            label1.Size = new Size(154, 39);
            label1.TabIndex = 4;
            label1.Text = "Bölge Ekle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(45, 184);
            label2.Name = "label2";
            label2.Size = new Size(94, 29);
            label2.TabIndex = 4;
            label2.Text = "Fabrika:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 56, 39);
            label3.Location = new Point(45, 271);
            label3.Name = "label3";
            label3.Size = new Size(115, 29);
            label3.TabIndex = 5;
            label3.Text = "Bölge Adı:";
            // 
            // comboBoxFactory
            // 
            comboBoxFactory.BackColor = Color.LightYellow;
            comboBoxFactory.FormattingEnabled = true;
            comboBoxFactory.Items.AddRange(new object[] { "Kayseri", "Boğazlıyan", "Turhal" });
            comboBoxFactory.Location = new Point(166, 180);
            comboBoxFactory.Name = "comboBoxFactory";
            comboBoxFactory.Size = new Size(238, 33);
            comboBoxFactory.TabIndex = 81;
            comboBoxFactory.TabStop = false;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.LightYellow;
            textBoxName.Location = new Point(166, 269);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(238, 31);
            textBoxName.TabIndex = 83;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(22, 56, 39);
            buttonSave.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.AntiqueWhite;
            buttonSave.Location = new Point(160, 575);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(160, 45);
            buttonSave.TabIndex = 84;
            buttonSave.TabStop = false;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddZone
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 652);
            Controls.Add(buttonSave);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxFactory);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "AddZone";
            Text = "AddZone";
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(pictureBoxClose, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(comboBoxFactory, 0);
            Controls.SetChildIndex(textBoxName, 0);
            Controls.SetChildIndex(buttonSave, 0);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxFactory;
        private TextBox textBoxName;
        private Button buttonSave;
    }
}