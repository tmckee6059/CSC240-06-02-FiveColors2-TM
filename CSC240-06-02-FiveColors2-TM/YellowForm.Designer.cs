namespace CSC240_06_02_FiveColors2_TM
{
    partial class YellowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YellowForm));
            yellowformLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // yellowformLabel
            // 
            yellowformLabel.AutoSize = true;
            yellowformLabel.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            yellowformLabel.Location = new Point(109, 46);
            yellowformLabel.Name = "yellowformLabel";
            yellowformLabel.Size = new Size(243, 27);
            yellowformLabel.TabIndex = 0;
            yellowformLabel.Text = "This is a yellow bird";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 303);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // YellowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 450);
            Controls.Add(pictureBox1);
            Controls.Add(yellowformLabel);
            Name = "YellowForm";
            Text = "YellowForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label yellowformLabel;
        private PictureBox pictureBox1;
    }
}