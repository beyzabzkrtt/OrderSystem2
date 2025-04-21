namespace OrderSystem2.forms.field
{
    partial class FieldDetail
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
            textBoxAddress = new TextBox();
            label3 = new Label();
            textBoxFieldId = new TextBox();
            txtboxArea = new TextBox();
            label4 = new Label();
            label2 = new Label();
            textBoxFarmerId = new TextBox();
            label5 = new Label();
            buttonDelete = new Button();
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
            panel1.Size = new Size(483, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara Light", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AntiqueWhite;
            label1.Location = new Point(158, 29);
            label1.Name = "label1";
            label1.Size = new Size(161, 39);
            label1.TabIndex = 1;
            label1.Text = "Tarla Bilgisi";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxAddress.BackColor = Color.LightYellow;
            textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddress.Location = new Point(189, 352);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(222, 68);
            textBoxAddress.TabIndex = 48;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(22, 56, 39);
            label3.Location = new Point(68, 351);
            label3.Margin = new Padding(3, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 29);
            label3.TabIndex = 47;
            label3.Text = "Adres:";
            // 
            // textBoxFieldId
            // 
            textBoxFieldId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxFieldId.BackColor = SystemColors.ActiveBorder;
            textBoxFieldId.BorderStyle = BorderStyle.FixedSingle;
            textBoxFieldId.Location = new Point(189, 214);
            textBoxFieldId.Name = "textBoxFieldId";
            textBoxFieldId.Size = new Size(222, 31);
            textBoxFieldId.TabIndex = 54;
            textBoxFieldId.TabStop = false;
            // 
            // txtboxArea
            // 
            txtboxArea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtboxArea.BackColor = Color.LightYellow;
            txtboxArea.BorderStyle = BorderStyle.FixedSingle;
            txtboxArea.Location = new Point(189, 284);
            txtboxArea.Name = "txtboxArea";
            txtboxArea.Size = new Size(222, 31);
            txtboxArea.TabIndex = 45;
            txtboxArea.KeyPress += TxtboxArea_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(22, 56, 39);
            label4.Location = new Point(68, 216);
            label4.Margin = new Padding(3, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 29);
            label4.TabIndex = 44;
            label4.Text = "Tarla No:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 56, 39);
            label2.Location = new Point(68, 283);
            label2.Margin = new Padding(3, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 29);
            label2.TabIndex = 43;
            label2.Text = "Büyüklük:";
            // 
            // textBoxFarmerId
            // 
            textBoxFarmerId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxFarmerId.BackColor = SystemColors.ActiveBorder;
            textBoxFarmerId.BorderStyle = BorderStyle.FixedSingle;
            textBoxFarmerId.Location = new Point(189, 157);
            textBoxFarmerId.Name = "textBoxFarmerId";
            textBoxFarmerId.Size = new Size(222, 31);
            textBoxFarmerId.TabIndex = 53;
            textBoxFarmerId.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(22, 56, 39);
            label5.Location = new Point(68, 159);
            label5.Margin = new Padding(3, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 29);
            label5.TabIndex = 49;
            label5.Text = "Çiftçi No:";
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDelete.BackColor = Color.FromArgb(22, 56, 39);
            buttonDelete.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = Color.AntiqueWhite;
            buttonDelete.Location = new Point(29, 513);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(188, 43);
            buttonDelete.TabIndex = 51;
            buttonDelete.TabStop = false;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(22, 56, 39);
            buttonSave.Font = new Font("Candara", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = Color.AntiqueWhite;
            buttonSave.Location = new Point(265, 513);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(188, 43);
            buttonSave.TabIndex = 52;
            buttonSave.TabStop = false;
            buttonSave.Text = "Kaydet";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // FieldDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(483, 600);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFarmerId);
            Controls.Add(label5);
            Controls.Add(textBoxAddress);
            Controls.Add(label3);
            Controls.Add(textBoxFieldId);
            Controls.Add(txtboxArea);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FieldDetail";
            Text = "FieldDetail";
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(txtboxArea, 0);
            Controls.SetChildIndex(textBoxFieldId, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(textBoxAddress, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(textBoxFarmerId, 0);
            Controls.SetChildIndex(buttonSave, 0);
            Controls.SetChildIndex(buttonDelete, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TxtboxArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBoxClose;
        private TextBox textBoxAddress;
        private Label label3;
        private TextBox textBoxFieldId;
        private TextBox txtboxArea;
        private Label label4;
        private Label label2;
        private TextBox textBoxFarmerId;
        private Label label5;
        private Button buttonDelete;
        private Button buttonSave;
    }
}