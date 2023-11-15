namespace Inlämning3Grafik
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            pictureBox1 = new PictureBox();
            AtmLabel = new Label();
            CardButton = new Button();
            EndButton = new Button();
            PinTextbox = new TextBox();
            PinLabel = new Label();
            EnterButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(913, 557);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AtmLabel
            // 
            AtmLabel.AutoSize = true;
            AtmLabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            AtmLabel.ForeColor = SystemColors.ControlLightLight;
            AtmLabel.Location = new Point(410, 76);
            AtmLabel.Name = "AtmLabel";
            AtmLabel.Size = new Size(98, 50);
            AtmLabel.TabIndex = 1;
            AtmLabel.Text = "ATM";
            // 
            // CardButton
            // 
            CardButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            CardButton.ForeColor = SystemColors.ControlDarkDark;
            CardButton.Location = new Point(403, 160);
            CardButton.Name = "CardButton";
            CardButton.Size = new Size(113, 29);
            CardButton.TabIndex = 2;
            CardButton.Text = "INSERT CARD";
            CardButton.UseVisualStyleBackColor = true;
            CardButton.Click += CardButton_Click;
            // 
            // EndButton
            // 
            EndButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EndButton.ForeColor = SystemColors.ControlDarkDark;
            EndButton.Location = new Point(412, 218);
            EndButton.Name = "EndButton";
            EndButton.Size = new Size(94, 29);
            EndButton.TabIndex = 3;
            EndButton.Text = "END";
            EndButton.UseVisualStyleBackColor = true;
            EndButton.Click += EndButton_Click;
            // 
            // PinTextbox
            // 
            PinTextbox.Location = new Point(482, 218);
            PinTextbox.Name = "PinTextbox";
            PinTextbox.PasswordChar = '*';
            PinTextbox.Size = new Size(67, 27);
            PinTextbox.TabIndex = 4;
            PinTextbox.Visible = false;
            // 
            // PinLabel
            // 
            PinLabel.AutoSize = true;
            PinLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PinLabel.ForeColor = SystemColors.ControlDarkDark;
            PinLabel.Location = new Point(378, 221);
            PinLabel.Name = "PinLabel";
            PinLabel.Size = new Size(87, 20);
            PinLabel.TabIndex = 5;
            PinLabel.Text = "ENTER PIN:";
            PinLabel.Visible = false;
            // 
            // EnterButton
            // 
            EnterButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EnterButton.ForeColor = SystemColors.ControlDarkDark;
            EnterButton.Location = new Point(410, 267);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(94, 29);
            EnterButton.TabIndex = 6;
            EnterButton.Text = "ENTER";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Visible = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 556);
            Controls.Add(EnterButton);
            Controls.Add(PinLabel);
            Controls.Add(PinTextbox);
            Controls.Add(EndButton);
            Controls.Add(CardButton);
            Controls.Add(AtmLabel);
            Controls.Add(pictureBox1);
            Name = "Start";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label AtmLabel;
        private Button CardButton;
        private Button EndButton;
        private TextBox PinTextbox;
        private Label PinLabel;
        private Button EnterButton;
    }
}