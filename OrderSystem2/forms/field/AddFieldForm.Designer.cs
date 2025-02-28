namespace OrderSystem2.forms.field
{
    partial class AddFieldForm
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
            panel2 = new Panel();
            pictureBoxClose = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxFarmerArea = new TextBox();
            textBoxFarmerNo = new TextBox();
            buttonSave = new Button();
            label5 = new Label();
            comboBoxFactory = new ComboBox();
            comboBoxZone = new ComboBox();
            labelPlaceholder = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 56, 39);
            panel2.Controls.Add(pictureBoxClose);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 114);
            panel2.TabIndex = 4;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.close_button;
            pictureBoxClose.Location = new Point(488, -1);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(38, 35);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(181, 35);
            label1.Name = "label1";
            label1.Size = new Size(142, 39);
            label1.TabIndex = 0;
            label1.Text = "Tarla Ekle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(76, 396);
            label2.Margin = new Padding(3, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 29);
            label2.TabIndex = 12;
            label2.Text = "Büyüklük:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 56, 39);
            label3.Location = new Point(76, 258);
            label3.Margin = new Padding(3, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 29);
            label3.TabIndex = 13;
            label3.Text = "Bölge:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 56, 39);
            label4.Location = new Point(76, 329);
            label4.Margin = new Padding(3, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 29);
            label4.TabIndex = 14;
            label4.Text = "Çiftçi No:";
            // 
            // textBoxFarmerArea
            // 
            textBoxFarmerArea.BackColor = Color.LightYellow;
            textBoxFarmerArea.BorderStyle = BorderStyle.FixedSingle;
            textBoxFarmerArea.Location = new Point(197, 397);
            textBoxFarmerArea.Name = "textBoxFarmerArea";
            textBoxFarmerArea.Size = new Size(222, 31);
            textBoxFarmerArea.TabIndex = 23;
            textBoxFarmerArea.KeyPress += TextBoxFarmerArea_KeyPress;
            // 
            // textBoxFarmerNo
            // 
            textBoxFarmerNo.BackColor = Color.LightYellow;
            textBoxFarmerNo.BorderStyle = BorderStyle.FixedSingle;
            textBoxFarmerNo.Location = new Point(197, 327);
            textBoxFarmerNo.Name = "textBoxFarmerNo";
            textBoxFarmerNo.Size = new Size(222, 31);
            textBoxFarmerNo.TabIndex = 24;
            textBoxFarmerNo.KeyPress += TextBoxFarmerNo_KeyPress;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(22, 56, 39);
            buttonSave.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.AntiqueWhite;
            buttonSave.Location = new Point(317, 562);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(186, 59);
            buttonSave.TabIndex = 34;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 56, 39);
            label5.Location = new Point(76, 188);
            label5.Margin = new Padding(3, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 29);
            label5.TabIndex = 35;
            label5.Text = "Fabrika:";
            // 
            // comboBoxFactory
            // 
            comboBoxFactory.BackColor = Color.LightYellow;
            comboBoxFactory.FormattingEnabled = true;
            comboBoxFactory.Location = new Point(197, 184);
            comboBoxFactory.Name = "comboBoxFactory";
            comboBoxFactory.Size = new Size(222, 33);
            comboBoxFactory.TabStop = false;
            // 
            // comboBoxZone
            // 
            comboBoxZone.BackColor = Color.LightYellow;
            comboBoxZone.FormattingEnabled = true;
            comboBoxZone.Location = new Point(197, 257);
            comboBoxZone.Name = "comboBoxZone";
            comboBoxZone.Size = new Size(222, 33);
            comboBoxZone.TabStop = false;
            // 
            // labelPlaceholder
            // 
            labelPlaceholder.AutoSize = true;
            labelPlaceholder.BackColor = Color.LightYellow;
            labelPlaceholder.ForeColor = SystemColors.ActiveBorder;
            labelPlaceholder.Location = new Point(199, 188);
            labelPlaceholder.Name = "labelPlaceholder";
            labelPlaceholder.Size = new Size(126, 25);
            labelPlaceholder.TabIndex = 38;
            labelPlaceholder.Text = "Fabrika Seçiniz";
            // 
            // AddFieldForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(524, 652);
            Controls.Add(labelPlaceholder);
            Controls.Add(comboBoxZone);
            Controls.Add(comboBoxFactory);
            Controls.Add(label5);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFarmerNo);
            Controls.Add(textBoxFarmerArea);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddFieldForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddFieldForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TextBoxFarmerNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxFarmerArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar ) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBoxClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxFarmerArea;
        private TextBox textBoxFarmerNo;
        private Button buttonSave;
        private Label label5;
        private ComboBox comboBoxFactory;
        private ComboBox comboBoxZone;
        private Label labelPlaceholder;
    }
}