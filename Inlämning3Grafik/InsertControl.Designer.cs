namespace Inlämning3Grafik
{
    partial class InsertControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertControl));
            pictureBox2 = new PictureBox();
            InsInsLabel = new Label();
            HunInsLabel = new Label();
            ThoInsLabel = new Label();
            FivInsLabel = new Label();
            TwoInsLabel = new Label();
            HunInsTextbox = new TextBox();
            ThoInsTextbox = new TextBox();
            FivInsTextbox = new TextBox();
            TwoInsTextbox = new TextBox();
            AccountListBox = new ListBox();
            InsertButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(913, 556);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // InsInsLabel
            // 
            InsInsLabel.AutoSize = true;
            InsInsLabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            InsInsLabel.ForeColor = SystemColors.ControlLightLight;
            InsInsLabel.Location = new Point(302, 61);
            InsInsLabel.Name = "InsInsLabel";
            InsInsLabel.Size = new Size(248, 50);
            InsInsLabel.TabIndex = 1;
            InsInsLabel.Text = "ATM | INSERT";
            // 
            // HunInsLabel
            // 
            HunInsLabel.AutoSize = true;
            HunInsLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            HunInsLabel.ForeColor = SystemColors.ControlDarkDark;
            HunInsLabel.Location = new Point(102, 196);
            HunInsLabel.Name = "HunInsLabel";
            HunInsLabel.Size = new Size(105, 23);
            HunInsLabel.TabIndex = 2;
            HunInsLabel.Text = "HUNDREDS:";
            // 
            // ThoInsLabel
            // 
            ThoInsLabel.AutoSize = true;
            ThoInsLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ThoInsLabel.ForeColor = SystemColors.ControlDarkDark;
            ThoInsLabel.Location = new Point(102, 319);
            ThoInsLabel.Name = "ThoInsLabel";
            ThoInsLabel.Size = new Size(115, 23);
            ThoInsLabel.TabIndex = 3;
            ThoInsLabel.Text = "THOUSANDS:";
            // 
            // FivInsLabel
            // 
            FivInsLabel.AutoSize = true;
            FivInsLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FivInsLabel.ForeColor = SystemColors.ControlDarkDark;
            FivInsLabel.Location = new Point(102, 278);
            FivInsLabel.Name = "FivInsLabel";
            FivInsLabel.Size = new Size(139, 23);
            FivInsLabel.TabIndex = 4;
            FivInsLabel.Text = "FIVEHUNDREDS:";
            // 
            // TwoInsLabel
            // 
            TwoInsLabel.AutoSize = true;
            TwoInsLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TwoInsLabel.ForeColor = SystemColors.ControlDarkDark;
            TwoInsLabel.Location = new Point(102, 238);
            TwoInsLabel.Name = "TwoInsLabel";
            TwoInsLabel.Size = new Size(143, 23);
            TwoInsLabel.TabIndex = 5;
            TwoInsLabel.Text = "TWOHUNDREDS:";
            // 
            // HunInsTextbox
            // 
            HunInsTextbox.Location = new Point(234, 195);
            HunInsTextbox.Name = "HunInsTextbox";
            HunInsTextbox.Size = new Size(87, 27);
            HunInsTextbox.TabIndex = 6;
            // 
            // ThoInsTextbox
            // 
            ThoInsTextbox.Location = new Point(244, 318);
            ThoInsTextbox.Name = "ThoInsTextbox";
            ThoInsTextbox.Size = new Size(87, 27);
            ThoInsTextbox.TabIndex = 7;
            // 
            // FivInsTextbox
            // 
            FivInsTextbox.Location = new Point(269, 274);
            FivInsTextbox.Name = "FivInsTextbox";
            FivInsTextbox.Size = new Size(87, 27);
            FivInsTextbox.TabIndex = 8;
            // 
            // TwoInsTextbox
            // 
            TwoInsTextbox.Location = new Point(269, 237);
            TwoInsTextbox.Name = "TwoInsTextbox";
            TwoInsTextbox.Size = new Size(87, 27);
            TwoInsTextbox.TabIndex = 9;
            // 
            // AccountListBox
            // 
            AccountListBox.FormattingEnabled = true;
            AccountListBox.ItemHeight = 20;
            AccountListBox.Location = new Point(539, 195);
            AccountListBox.Name = "AccountListBox";
            AccountListBox.Size = new Size(150, 104);
            AccountListBox.TabIndex = 10;
            // 
            // InsertButton
            // 
            InsertButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            InsertButton.ForeColor = SystemColors.ControlDarkDark;
            InsertButton.Location = new Point(539, 318);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(94, 29);
            InsertButton.TabIndex = 11;
            InsertButton.Text = "INSERT";
            InsertButton.UseVisualStyleBackColor = true;
            // 
            // InsertControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InsertButton);
            Controls.Add(AccountListBox);
            Controls.Add(TwoInsTextbox);
            Controls.Add(FivInsTextbox);
            Controls.Add(ThoInsTextbox);
            Controls.Add(HunInsTextbox);
            Controls.Add(TwoInsLabel);
            Controls.Add(FivInsLabel);
            Controls.Add(ThoInsLabel);
            Controls.Add(HunInsLabel);
            Controls.Add(InsInsLabel);
            Controls.Add(pictureBox2);
            Name = "InsertControl";
            Size = new Size(913, 556);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label InsInsLabel;
        private Label HunInsLabel;
        private Label ThoInsLabel;
        private Label FivInsLabel;
        private Label TwoInsLabel;
        private TextBox HunInsTextbox;
        private TextBox ThoInsTextbox;
        private TextBox FivInsTextbox;
        private TextBox TwoInsTextbox;
        private ListBox AccountListBox;
        private Button InsertButton;
    }
}
