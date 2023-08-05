namespace CSC240_06_02_FiveColors2_TM
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
            redRadioButton = new RadioButton();
            blueRadioButton = new RadioButton();
            greenRadioButton = new RadioButton();
            yellowRadioButton = new RadioButton();
            purpleRadioButton = new RadioButton();
            resetButton = new Button();
            defaultRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // redRadioButton
            // 
            redRadioButton.AutoSize = true;
            redRadioButton.BackColor = Color.Transparent;
            redRadioButton.Location = new Point(60, 115);
            redRadioButton.Name = "redRadioButton";
            redRadioButton.Size = new Size(45, 19);
            redRadioButton.TabIndex = 0;
            redRadioButton.TabStop = true;
            redRadioButton.Text = "Red";
            redRadioButton.UseVisualStyleBackColor = false;
            redRadioButton.CheckedChanged += redRadioButton_CheckedChanged;
            // 
            // blueRadioButton
            // 
            blueRadioButton.AutoSize = true;
            blueRadioButton.BackColor = Color.Transparent;
            blueRadioButton.Location = new Point(60, 140);
            blueRadioButton.Name = "blueRadioButton";
            blueRadioButton.Size = new Size(48, 19);
            blueRadioButton.TabIndex = 1;
            blueRadioButton.TabStop = true;
            blueRadioButton.Text = "Blue";
            blueRadioButton.UseVisualStyleBackColor = false;
            blueRadioButton.CheckedChanged += blueRadioButton_CheckedChanged;
            // 
            // greenRadioButton
            // 
            greenRadioButton.AutoSize = true;
            greenRadioButton.BackColor = Color.Transparent;
            greenRadioButton.Location = new Point(60, 165);
            greenRadioButton.Name = "greenRadioButton";
            greenRadioButton.Size = new Size(56, 19);
            greenRadioButton.TabIndex = 2;
            greenRadioButton.TabStop = true;
            greenRadioButton.Text = "Green";
            greenRadioButton.UseVisualStyleBackColor = false;
            greenRadioButton.CheckedChanged += greenRadioButton_CheckedChanged;
            // 
            // yellowRadioButton
            // 
            yellowRadioButton.AutoSize = true;
            yellowRadioButton.BackColor = Color.Transparent;
            yellowRadioButton.Location = new Point(60, 190);
            yellowRadioButton.Name = "yellowRadioButton";
            yellowRadioButton.Size = new Size(59, 19);
            yellowRadioButton.TabIndex = 3;
            yellowRadioButton.TabStop = true;
            yellowRadioButton.Text = "Yellow";
            yellowRadioButton.UseVisualStyleBackColor = false;
            yellowRadioButton.CheckedChanged += yellowRadioButton_CheckedChanged;
            // 
            // purpleRadioButton
            // 
            purpleRadioButton.AutoSize = true;
            purpleRadioButton.BackColor = Color.Transparent;
            purpleRadioButton.Location = new Point(60, 215);
            purpleRadioButton.Name = "purpleRadioButton";
            purpleRadioButton.Size = new Size(59, 19);
            purpleRadioButton.TabIndex = 4;
            purpleRadioButton.TabStop = true;
            purpleRadioButton.Text = "Purple";
            purpleRadioButton.UseVisualStyleBackColor = false;
            purpleRadioButton.CheckedChanged += purpleRadioButton_CheckedChanged;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(60, 257);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(84, 23);
            resetButton.TabIndex = 5;
            resetButton.Text = "Reset Color";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // defaultRadioButton
            // 
            defaultRadioButton.AutoSize = true;
            defaultRadioButton.Location = new Point(146, 67);
            defaultRadioButton.Name = "defaultRadioButton";
            defaultRadioButton.Size = new Size(63, 19);
            defaultRadioButton.TabIndex = 6;
            defaultRadioButton.TabStop = true;
            defaultRadioButton.Text = "Default";
            defaultRadioButton.UseVisualStyleBackColor = true;
            defaultRadioButton.Visible = false;
            defaultRadioButton.CheckedChanged += defaultRadioButton_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 366);
            Controls.Add(defaultRadioButton);
            Controls.Add(resetButton);
            Controls.Add(purpleRadioButton);
            Controls.Add(yellowRadioButton);
            Controls.Add(greenRadioButton);
            Controls.Add(blueRadioButton);
            Controls.Add(redRadioButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton redRadioButton;
        private RadioButton blueRadioButton;
        private RadioButton greenRadioButton;
        private RadioButton yellowRadioButton;
        private RadioButton purpleRadioButton;
        private Button resetButton;
        private RadioButton defaultRadioButton;
    }
}