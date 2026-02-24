namespace CookieClicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cookiePictureBox = new PictureBox();
            clicksLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)cookiePictureBox).BeginInit();
            SuspendLayout();
            // 
            // cookiePictureBox
            // 
            cookiePictureBox.Image = (Image)resources.GetObject("cookiePictureBox.Image");
            cookiePictureBox.Location = new Point(270, 128);
            cookiePictureBox.Name = "cookiePictureBox";
            cookiePictureBox.Size = new Size(268, 209);
            cookiePictureBox.TabIndex = 0;
            cookiePictureBox.TabStop = false;
            cookiePictureBox.Click += cookiePictureBox_Click;
            cookiePictureBox.MouseDown += cookiePictureBox_MouseDown;
            cookiePictureBox.MouseUp += cookiePictureBox_MouseUp;
            // 
            // clicksLabel
            // 
            clicksLabel.AutoSize = true;
            clicksLabel.Location = new Point(278, 74);
            clicksLabel.Name = "clicksLabel";
            clicksLabel.Size = new Size(50, 15);
            clicksLabel.TabIndex = 1;
            clicksLabel.Text = "Clicks: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clicksLabel);
            Controls.Add(cookiePictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cookiePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox cookiePictureBox;
        private Label clicksLabel;
    }
}
