namespace Inlämning3Grafik
{
    partial class TransferMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferMenu));
            pictureBox1 = new PictureBox();
            AtmTraLabel = new Label();
            InstLabel = new Label();
            InstLabel2 = new Label();
            HunTraLabel = new Label();
            FromListbox = new ListBox();
            ToListbox = new ListBox();
            ThoTraLabel = new Label();
            FivTraLabel = new Label();
            TwoTraLabel = new Label();
            HunTraTextbox = new TextBox();
            TwoTraTextbox = new TextBox();
            FivTraTextbox = new TextBox();
            ThoTraTextbox = new TextBox();
            TransferButton = new Button();
            GoBackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 452);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AtmTraLabel
            // 
            AtmTraLabel.AutoSize = true;
            AtmTraLabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            AtmTraLabel.ForeColor = SystemColors.ControlLightLight;
            AtmTraLabel.Location = new Point(235, 41);
            AtmTraLabel.Name = "AtmTraLabel";
            AtmTraLabel.Size = new Size(305, 50);
            AtmTraLabel.TabIndex = 1;
            AtmTraLabel.Text = "ATM | TRANSFER";
            // 
            // InstLabel
            // 
            InstLabel.AutoSize = true;
            InstLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            InstLabel.ForeColor = Color.FromArgb(64, 64, 64);
            InstLabel.Location = new Point(444, 129);
            InstLabel.Name = "InstLabel";
            InstLabel.Size = new Size(148, 23);
            InstLabel.TabIndex = 2;
            InstLabel.Text = "FROM ACCOUNT:";
            // 
            // InstLabel2
            // 
            InstLabel2.AutoSize = true;
            InstLabel2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            InstLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            InstLabel2.Location = new Point(615, 129);
            InstLabel2.Name = "InstLabel2";
            InstLabel2.Size = new Size(120, 23);
            InstLabel2.TabIndex = 3;
            InstLabel2.Text = "TO ACCOUNT:";
            // 
            // HunTraLabel
            // 
            HunTraLabel.AutoSize = true;
            HunTraLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            HunTraLabel.ForeColor = SystemColors.ControlDarkDark;
            HunTraLabel.Location = new Point(92, 165);
            HunTraLabel.Name = "HunTraLabel";
            HunTraLabel.Size = new Size(105, 23);
            HunTraLabel.TabIndex = 4;
            HunTraLabel.Text = "HUNDREDS:";
            // 
            // FromListbox
            // 
            FromListbox.FormattingEnabled = true;
            FromListbox.ItemHeight = 20;
            FromListbox.Location = new Point(444, 165);
            FromListbox.Name = "FromListbox";
            FromListbox.Size = new Size(150, 104);
            FromListbox.TabIndex = 8;
            // 
            // ToListbox
            // 
            ToListbox.FormattingEnabled = true;
            ToListbox.ItemHeight = 20;
            ToListbox.Location = new Point(615, 165);
            ToListbox.Name = "ToListbox";
            ToListbox.Size = new Size(150, 104);
            ToListbox.TabIndex = 9;
            // 
            // ThoTraLabel
            // 
            ThoTraLabel.AutoSize = true;
            ThoTraLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ThoTraLabel.ForeColor = SystemColors.ControlDarkDark;
            ThoTraLabel.Location = new Point(92, 286);
            ThoTraLabel.Name = "ThoTraLabel";
            ThoTraLabel.Size = new Size(115, 23);
            ThoTraLabel.TabIndex = 10;
            ThoTraLabel.Text = "THOUSANDS:";
            // 
            // FivTraLabel
            // 
            FivTraLabel.AutoSize = true;
            FivTraLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FivTraLabel.ForeColor = SystemColors.ControlDarkDark;
            FivTraLabel.Location = new Point(92, 246);
            FivTraLabel.Name = "FivTraLabel";
            FivTraLabel.Size = new Size(139, 23);
            FivTraLabel.TabIndex = 11;
            FivTraLabel.Text = "FIVEHUNDREDS:";
            // 
            // TwoTraLabel
            // 
            TwoTraLabel.AutoSize = true;
            TwoTraLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TwoTraLabel.ForeColor = SystemColors.ControlDarkDark;
            TwoTraLabel.Location = new Point(92, 208);
            TwoTraLabel.Name = "TwoTraLabel";
            TwoTraLabel.Size = new Size(143, 23);
            TwoTraLabel.TabIndex = 12;
            TwoTraLabel.Text = "TWOHUNDREDS:";
            // 
            // HunTraTextbox
            // 
            HunTraTextbox.Location = new Point(216, 164);
            HunTraTextbox.Name = "HunTraTextbox";
            HunTraTextbox.Size = new Size(89, 27);
            HunTraTextbox.TabIndex = 13;
            // 
            // TwoTraTextbox
            // 
            TwoTraTextbox.Location = new Point(250, 207);
            TwoTraTextbox.Name = "TwoTraTextbox";
            TwoTraTextbox.Size = new Size(89, 27);
            TwoTraTextbox.TabIndex = 14;
            // 
            // FivTraTextbox
            // 
            FivTraTextbox.Location = new Point(247, 245);
            FivTraTextbox.Name = "FivTraTextbox";
            FivTraTextbox.Size = new Size(89, 27);
            FivTraTextbox.TabIndex = 15;
            // 
            // ThoTraTextbox
            // 
            ThoTraTextbox.Location = new Point(226, 285);
            ThoTraTextbox.Name = "ThoTraTextbox";
            ThoTraTextbox.Size = new Size(89, 27);
            ThoTraTextbox.TabIndex = 16;
            // 
            // TransferButton
            // 
            TransferButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TransferButton.ForeColor = Color.FromArgb(64, 64, 64);
            TransferButton.Location = new Point(555, 295);
            TransferButton.Name = "TransferButton";
            TransferButton.Size = new Size(105, 29);
            TransferButton.TabIndex = 17;
            TransferButton.Text = "TRANSFER";
            TransferButton.UseVisualStyleBackColor = true;
            TransferButton.Click += TransferButton_Click;
            // 
            // BackTraButton
            // 
            GoBackButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            GoBackButton.ForeColor = Color.FromArgb(64, 64, 64);
            GoBackButton.Location = new Point(36, 388);
            GoBackButton.Name = "BackTraButton";
            GoBackButton.Size = new Size(195, 29);
            GoBackButton.TabIndex = 18;
            GoBackButton.Text = "BACK TO MAIN MENU";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // TransferMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GoBackButton);
            Controls.Add(TransferButton);
            Controls.Add(ThoTraTextbox);
            Controls.Add(FivTraTextbox);
            Controls.Add(TwoTraTextbox);
            Controls.Add(HunTraTextbox);
            Controls.Add(TwoTraLabel);
            Controls.Add(FivTraLabel);
            Controls.Add(ThoTraLabel);
            Controls.Add(ToListbox);
            Controls.Add(FromListbox);
            Controls.Add(HunTraLabel);
            Controls.Add(InstLabel2);
            Controls.Add(InstLabel);
            Controls.Add(AtmTraLabel);
            Controls.Add(pictureBox1);
            Name = "TransferMenu";
            Text = "ATM | TRANSFER";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label AtmTraLabel;
        private Label InstLabel;
        private Label InstLabel2;
        private Label HunTraLabel;
        private ListBox FromListbox;
        private ListBox ToListbox;
        private Label ThoTraLabel;
        private Label FivTraLabel;
        private Label TwoTraLabel;
        private TextBox HunTraTextbox;
        private TextBox TwoTraTextbox;
        private TextBox FivTraTextbox;
        private TextBox ThoTraTextbox;
        private Button TransferButton;
        private Button GoBackButton;
    }
}