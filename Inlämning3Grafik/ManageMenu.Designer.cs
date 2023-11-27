namespace Inlämning3Grafik
{
    partial class ManageMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMenu));
            pictureBox1 = new PictureBox();
            AddAccountLabel = new Label();
            DeleteAccountLabel = new Label();
            ManageMenuLabel = new Label();
            RemoveListbox = new ListBox();
            AccountNameLabel = new Label();
            AccountNumberTextbox = new TextBox();
            AccountNumberLabel = new Label();
            AccountNameTextbox = new TextBox();
            AddAccountButton = new Button();
            RemoveAccountButton = new Button();
            GoBackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(913, 558);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AddAccountLabel
            // 
            AddAccountLabel.AutoSize = true;
            AddAccountLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            AddAccountLabel.ForeColor = Color.FromArgb(64, 64, 64);
            AddAccountLabel.Location = new Point(124, 182);
            AddAccountLabel.Name = "AddAccountLabel";
            AddAccountLabel.Size = new Size(130, 23);
            AddAccountLabel.TabIndex = 1;
            AddAccountLabel.Text = "ADD ACCOUNT";
            // 
            // DeleteAccountLabel
            // 
            DeleteAccountLabel.AutoSize = true;
            DeleteAccountLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteAccountLabel.ForeColor = Color.FromArgb(64, 64, 64);
            DeleteAccountLabel.Location = new Point(548, 182);
            DeleteAccountLabel.Name = "DeleteAccountLabel";
            DeleteAccountLabel.Size = new Size(164, 23);
            DeleteAccountLabel.TabIndex = 2;
            DeleteAccountLabel.Text = "REMOVE ACCOUNT";
            // 
            // ManageMenuLabel
            // 
            ManageMenuLabel.AutoSize = true;
            ManageMenuLabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            ManageMenuLabel.ForeColor = SystemColors.ControlLightLight;
            ManageMenuLabel.Location = new Point(191, 72);
            ManageMenuLabel.Name = "ManageMenuLabel";
            ManageMenuLabel.Size = new Size(486, 50);
            ManageMenuLabel.TabIndex = 3;
            ManageMenuLabel.Text = "ATM | MANAGE ACCOUNTS";
            // 
            // RemoveListbox
            // 
            RemoveListbox.FormattingEnabled = true;
            RemoveListbox.ItemHeight = 20;
            RemoveListbox.Location = new Point(548, 224);
            RemoveListbox.Name = "RemoveListbox";
            RemoveListbox.Size = new Size(230, 104);
            RemoveListbox.TabIndex = 5;
            // 
            // AccountNameLabel
            // 
            AccountNameLabel.AutoSize = true;
            AccountNameLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AccountNameLabel.ForeColor = SystemColors.ControlDarkDark;
            AccountNameLabel.Location = new Point(124, 225);
            AccountNameLabel.Name = "AccountNameLabel";
            AccountNameLabel.Size = new Size(148, 23);
            AccountNameLabel.TabIndex = 6;
            AccountNameLabel.Text = "ACCOUNT NAME:";
            // 
            // AccountNumberTextbox
            // 
            AccountNumberTextbox.Location = new Point(309, 263);
            AccountNumberTextbox.Name = "AccountNumberTextbox";
            AccountNumberTextbox.Size = new Size(125, 27);
            AccountNumberTextbox.TabIndex = 7;
            // 
            // AccountNumberLabel
            // 
            AccountNumberLabel.AutoSize = true;
            AccountNumberLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AccountNumberLabel.ForeColor = SystemColors.ControlDarkDark;
            AccountNumberLabel.Location = new Point(124, 264);
            AccountNumberLabel.Name = "AccountNumberLabel";
            AccountNumberLabel.Size = new Size(170, 23);
            AccountNumberLabel.TabIndex = 8;
            AccountNumberLabel.Text = "ACCOUNT NUMBER:";
            // 
            // AccountNameTextbox
            // 
            AccountNameTextbox.Location = new Point(287, 224);
            AccountNameTextbox.Name = "AccountNameTextbox";
            AccountNameTextbox.Size = new Size(125, 27);
            AccountNameTextbox.TabIndex = 9;
            // 
            // AddAccountButton
            // 
            AddAccountButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddAccountButton.ForeColor = SystemColors.ControlDarkDark;
            AddAccountButton.Location = new Point(124, 306);
            AddAccountButton.Name = "AddAccountButton";
            AddAccountButton.Size = new Size(94, 29);
            AddAccountButton.TabIndex = 10;
            AddAccountButton.Text = "ADD";
            AddAccountButton.UseVisualStyleBackColor = true;
            AddAccountButton.Click += AddAccountButton_Click;
            // 
            // RemoveAccountButton
            // 
            RemoveAccountButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveAccountButton.ForeColor = SystemColors.ControlDarkDark;
            RemoveAccountButton.Location = new Point(548, 346);
            RemoveAccountButton.Name = "RemoveAccountButton";
            RemoveAccountButton.Size = new Size(94, 29);
            RemoveAccountButton.TabIndex = 11;
            RemoveAccountButton.Text = "REMOVE";
            RemoveAccountButton.UseVisualStyleBackColor = true;
            RemoveAccountButton.Click += RemoveAccountButton_Click;
            // 
            // GoBackButton
            // 
            GoBackButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            GoBackButton.ForeColor = SystemColors.ControlDarkDark;
            GoBackButton.Location = new Point(25, 500);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(187, 29);
            GoBackButton.TabIndex = 12;
            GoBackButton.Text = "BACK TO MAINMENU";
            GoBackButton.UseVisualStyleBackColor = true;
            // 
            // ManageMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 556);
            Controls.Add(GoBackButton);
            Controls.Add(RemoveAccountButton);
            Controls.Add(AddAccountButton);
            Controls.Add(AccountNameTextbox);
            Controls.Add(AccountNumberLabel);
            Controls.Add(AccountNumberTextbox);
            Controls.Add(AccountNameLabel);
            Controls.Add(RemoveListbox);
            Controls.Add(ManageMenuLabel);
            Controls.Add(DeleteAccountLabel);
            Controls.Add(AddAccountLabel);
            Controls.Add(pictureBox1);
            Name = "ManageMenu";
            Text = "ATM | MANAGE ACCOUNTS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label AddAccountLabel;
        private Label DeleteAccountLabel;
        private Label ManageMenuLabel;
        private ListBox RemoveListbox;
        private Label AccountNameLabel;
        private TextBox AccountNumberTextbox;
        private Label AccountNumberLabel;
        private TextBox AccountNameTextbox;
        private Button AddAccountButton;
        private Button RemoveAccountButton;
        private Button GoBackButton;
    }
}