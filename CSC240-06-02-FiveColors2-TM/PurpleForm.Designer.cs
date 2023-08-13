namespace CSC240_06_02_FiveColors2_TM
{
    partial class PurpleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurpleForm));
            purpleformLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // purpleformLabel
            // 
            purpleformLabel.AutoSize = true;
            purpleformLabel.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            purpleformLabel.Location = new Point(58, 54);
            purpleformLabel.Name = "purpleformLabel";
            purpleformLabel.Size = new Size(216, 27);
            purpleformLabel.TabIndex = 0;
            purpleformLabel.Text = "This is purple rain";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // PurpleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(348, 380);
            Controls.Add(pictureBox1);
            Controls.Add(purpleformLabel);
            Name = "PurpleForm";
            Text = "PurpleForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button purplerainButton;
        private Label purpleformLabel;
        private PictureBox pictureBox1;
    }
}