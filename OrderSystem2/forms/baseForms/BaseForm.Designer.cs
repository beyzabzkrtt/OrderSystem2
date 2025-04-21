namespace OrderSystem2.forms
{
    partial class BaseForm
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
            pictureBoxBack = new PictureBox();
            pictureBoxClose = new PictureBox();
            pictureBoxTab = new PictureBox();
            pictureBoxExpand = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.BackColor = Color.FromArgb(22, 56, 39);
            pictureBoxBack.Image = Properties.Resources.back;
            pictureBoxBack.Location = new Point(-1, -3);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(37, 34);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBack.TabIndex = 4;
            pictureBoxBack.TabStop = false;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.BackColor = Color.FromArgb(22, 56, 39);
            pictureBoxClose.Image = Properties.Resources.close_button;
            pictureBoxClose.Location = new Point(1202, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(33, 31);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 6;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // pictureBoxTab
            // 
            pictureBoxTab.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxTab.BackColor = Color.FromArgb(22, 56, 39);
            pictureBoxTab.Image = Properties.Resources.tab;
            pictureBoxTab.Location = new Point(1140, 0);
            pictureBoxTab.Name = "pictureBoxTab";
            pictureBoxTab.Size = new Size(33, 31);
            pictureBoxTab.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTab.TabIndex = 7;
            pictureBoxTab.TabStop = false;
            // 
            // pictureBoxExpand
            // 
            pictureBoxExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxExpand.BackColor = Color.FromArgb(22, 56, 39);
            pictureBoxExpand.Image = Properties.Resources.expand;
            pictureBoxExpand.Location = new Point(1170, -3);
            pictureBoxExpand.Name = "pictureBoxExpand";
            pictureBoxExpand.Size = new Size(33, 33);
            pictureBoxExpand.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExpand.TabIndex = 8;
            pictureBoxExpand.TabStop = false;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1235, 559);
            Controls.Add(pictureBoxClose);
            Controls.Add(pictureBoxTab);
            Controls.Add(pictureBoxBack);
            Controls.Add(pictureBoxExpand);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTab).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExpand).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxBack;
        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxTab;
        private PictureBox pictureBoxExpand;
    }
}