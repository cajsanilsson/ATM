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
            MainmenuLabel = new Label();
            BalanceLabel = new Label();
            InsertLabel = new Label();
            WithdrawLabel = new Label();
            TransferLabel = new Label();
            EndLabel = new Label();
            AccBalLabel = new Label();
            ManageLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(913, 558);
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
            CardButton.Size = new Size(125, 29);
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
            // MainmenuLabel
            // 
            MainmenuLabel.AutoSize = true;
            MainmenuLabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            MainmenuLabel.ForeColor = SystemColors.ControlLightLight;
            MainmenuLabel.Location = new Point(267, 59);
            MainmenuLabel.Name = "MainmenuLabel";
            MainmenuLabel.Size = new Size(333, 50);
            MainmenuLabel.TabIndex = 8;
            MainmenuLabel.Text = "ATM | MAINMENU";
            MainmenuLabel.Visible = false;
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BalanceLabel.ForeColor = SystemColors.ControlDarkDark;
            BalanceLabel.Location = new Point(403, 287);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(83, 23);
            BalanceLabel.TabIndex = 9;
            BalanceLabel.Text = "BALANCE";
            BalanceLabel.Visible = false;
            // 
            // InsertLabel
            // 
            InsertLabel.AutoSize = true;
            InsertLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            InsertLabel.ForeColor = SystemColors.ControlDarkDark;
            InsertLabel.Location = new Point(256, 149);
            InsertLabel.Name = "InsertLabel";
            InsertLabel.Size = new Size(132, 23);
            InsertLabel.TabIndex = 10;
            InsertLabel.Text = "INSERT MONEY";
            InsertLabel.Visible = false;
            InsertLabel.Click += InsertLabel_Click;
            // 
            // WithdrawLabel
            // 
            WithdrawLabel.AutoSize = true;
            WithdrawLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            WithdrawLabel.ForeColor = SystemColors.ControlDarkDark;
            WithdrawLabel.Location = new Point(441, 149);
            WithdrawLabel.Name = "WithdrawLabel";
            WithdrawLabel.Size = new Size(168, 23);
            WithdrawLabel.TabIndex = 11;
            WithdrawLabel.Text = "WITHDRAW MONEY";
            WithdrawLabel.Visible = false;
            WithdrawLabel.Click += WithdrawLabel_Click;
            // 
            // TransferLabel
            // 
            TransferLabel.AutoSize = true;
            TransferLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TransferLabel.ForeColor = SystemColors.ControlDarkDark;
            TransferLabel.Location = new Point(659, 149);
            TransferLabel.Name = "TransferLabel";
            TransferLabel.Size = new Size(92, 23);
            TransferLabel.TabIndex = 12;
            TransferLabel.Text = "TRANSFER";
            TransferLabel.Visible = false;
            TransferLabel.Click += TransferLabel_Click;
            // 
            // EndLabel
            // 
            EndLabel.AutoSize = true;
            EndLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EndLabel.ForeColor = SystemColors.ControlDarkDark;
            EndLabel.Location = new Point(797, 149);
            EndLabel.Name = "EndLabel";
            EndLabel.Size = new Size(44, 23);
            EndLabel.TabIndex = 13;
            EndLabel.Text = "END";
            EndLabel.Visible = false;
            EndLabel.Click += EndLabel_Click;
            // 
            // AccBalLabel
            // 
            AccBalLabel.AutoSize = true;
            AccBalLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AccBalLabel.ForeColor = Color.FromArgb(64, 64, 64);
            AccBalLabel.Location = new Point(335, 330);
            AccBalLabel.Name = "AccBalLabel";
            AccBalLabel.Size = new Size(53, 23);
            AccBalLabel.TabIndex = 14;
            AccBalLabel.Text = "label1";
            AccBalLabel.Visible = false;
            // 
            // ManageLabel
            // 
            ManageLabel.AutoEllipsis = true;
            ManageLabel.AutoSize = true;
            ManageLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ManageLabel.ForeColor = SystemColors.ControlDarkDark;
            ManageLabel.Location = new Point(45, 149);
            ManageLabel.Name = "ManageLabel";
            ManageLabel.Size = new Size(167, 23);
            ManageLabel.TabIndex = 15;
            ManageLabel.Text = "MANAGE ACCOUNT";
            ManageLabel.Visible = false;
            ManageLabel.Click += ManageLabel_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 556);
            Controls.Add(ManageLabel);
            Controls.Add(AccBalLabel);
            Controls.Add(EndLabel);
            Controls.Add(TransferLabel);
            Controls.Add(WithdrawLabel);
            Controls.Add(InsertLabel);
            Controls.Add(BalanceLabel);
            Controls.Add(MainmenuLabel);
            Controls.Add(EnterButton);
            Controls.Add(PinLabel);
            Controls.Add(PinTextbox);
            Controls.Add(EndButton);
            Controls.Add(CardButton);
            Controls.Add(AtmLabel);
            Controls.Add(pictureBox1);
            Name = "Start";
            Text = "ATM";
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
        private Label MainmenuLabel;
        private Label BalanceLabel;
        private Label InsertLabel;
        private Label WithdrawLabel;
        private Label TransferLabel;
        private Label EndLabel;
        private Label AccBalLabel;
        private Label ManageLabel;
    }
}