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
            textBoxFarmerId = new TextBox();
            textBoxAreSize = new TextBox();
            textBoxZoneId = new TextBox();
            buttonSave = new Button();
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
            label2.Location = new Point(76, 317);
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
            label3.Location = new Point(76, 248);
            label3.Margin = new Padding(3, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 29);
            label3.TabIndex = 13;
            label3.Text = "Bölge No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 56, 39);
            label4.Location = new Point(76, 178);
            label4.Margin = new Padding(3, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 29);
            label4.TabIndex = 14;
            label4.Text = "Çiftçi No:";
            // 
            // textBoxFarmerId
            // 
            textBoxFarmerId.BackColor = Color.LightYellow;
            textBoxFarmerId.BorderStyle = BorderStyle.FixedSingle;
            textBoxFarmerId.Location = new Point(197, 179);
            textBoxFarmerId.Name = "textBoxFarmerId";
            textBoxFarmerId.Size = new Size(222, 31);
            textBoxFarmerId.TabIndex = 23;
            // 
            // textBoxAreSize
            // 
            textBoxAreSize.BackColor = Color.LightYellow;
            textBoxAreSize.BorderStyle = BorderStyle.FixedSingle;
            textBoxAreSize.Location = new Point(197, 318);
            textBoxAreSize.Name = "textBoxAreSize";
            textBoxAreSize.Size = new Size(222, 31);
            textBoxAreSize.TabIndex = 24;
            // 
            // textBoxZoneId
            // 
            textBoxZoneId.BackColor = Color.LightYellow;
            textBoxZoneId.BorderStyle = BorderStyle.FixedSingle;
            textBoxZoneId.Location = new Point(197, 246);
            textBoxZoneId.Name = "textBoxZoneId";
            textBoxZoneId.Size = new Size(222, 31);
            textBoxZoneId.TabIndex = 25;
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
            // AddFieldForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(524, 652);
            Controls.Add(buttonSave);
            Controls.Add(textBoxZoneId);
            Controls.Add(textBoxAreSize);
            Controls.Add(textBoxFarmerId);
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

        #endregion

        private Panel panel2;
        private PictureBox pictureBoxClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxFarmerId;
        private TextBox textBoxAreSize;
        private TextBox textBoxZoneId;
        private Button buttonSave;
    }
}