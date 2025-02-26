namespace OrderSystem2.forms.order
{
    partial class MakeOrderForm
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
            textBoxFarmerId = new TextBox();
            labelFactory = new Label();
            comboBox1 = new ComboBox();
            buttonSave = new Button();
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
            panel1.Size = new Size(398, 99);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(113, 35);
            label1.Name = "label1";
            label1.Size = new Size(158, 29);
            label1.TabIndex = 0;
            label1.Text = "Sipariş Oluştur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(53, 131);
            label2.Name = "label2";
            label2.Size = new Size(85, 24);
            label2.TabIndex = 1;
            label2.Text = "Çiftçi No:";
            // 
            // textBoxFarmerId
            // 
            textBoxFarmerId.BackColor = Color.LightYellow;
            textBoxFarmerId.BorderStyle = BorderStyle.FixedSingle;
            textBoxFarmerId.Location = new Point(144, 131);
            textBoxFarmerId.Name = "textBoxFarmerId";
            textBoxFarmerId.Size = new Size(176, 31);
            textBoxFarmerId.TabIndex = 23;
            // 
            // labelFactory
            // 
            labelFactory.AutoSize = true;
            labelFactory.BackColor = Color.AntiqueWhite;
            labelFactory.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFactory.ForeColor = Color.FromArgb(22, 56, 39);
            labelFactory.Location = new Point(53, 208);
            labelFactory.Name = "labelFactory";
            labelFactory.Size = new Size(77, 24);
            labelFactory.TabIndex = 24;
            labelFactory.Text = "Fabrika:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LightYellow;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kayseri", "Boğazlıyan", "Turhal" });
            comboBox1.Location = new Point(144, 208);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 33);
            comboBox1.TabIndex = 25;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(22, 56, 39);
            buttonSave.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.AntiqueWhite;
            buttonSave.Location = new Point(200, 446);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(176, 47);
            buttonSave.TabIndex = 35;
            buttonSave.Text = "Sonraki";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // MakeOrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(398, 515);
            Controls.Add(buttonSave);
            Controls.Add(comboBox1);
            Controls.Add(labelFactory);
            Controls.Add(textBoxFarmerId);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MakeOrderForm";
            Text = "MakeOrderForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBoxFarmerId;
        private Label labelFactory;
        private ComboBox comboBox1;
        private Button buttonSave;
    }
}