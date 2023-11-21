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
            AddAccLabel = new Label();
            DelAccLabel = new Label();
            ManageMenuLabel = new Label();
            RemoveListbox = new ListBox();
            AccNamLabel = new Label();
            AccNumTextbox = new TextBox();
            AccNumLabel = new Label();
            AccNamTextbox = new TextBox();
            AddAccButton = new Button();
            RemAccButton = new Button();
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
            // AddAccLabel
            // 
            AddAccLabel.AutoSize = true;
            AddAccLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            AddAccLabel.ForeColor = Color.FromArgb(64, 64, 64);
            AddAccLabel.Location = new Point(160, 182);
            AddAccLabel.Name = "AddAccLabel";
            AddAccLabel.Size = new Size(130, 23);
            AddAccLabel.TabIndex = 1;
            AddAccLabel.Text = "ADD ACCOUNT";
            // 
            // DelAccLabel
            // 
            DelAccLabel.AutoSize = true;
            DelAccLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            DelAccLabel.ForeColor = Color.FromArgb(64, 64, 64);
            DelAccLabel.Location = new Point(583, 182);
            DelAccLabel.Name = "DelAccLabel";
            DelAccLabel.Size = new Size(164, 23);
            DelAccLabel.TabIndex = 2;
            DelAccLabel.Text = "REMOVE ACCOUNT";
            // 
            // ManageMenuLabel
            // 
            ManageMenuLabel.AutoSize = true;
            ManageMenuLabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            ManageMenuLabel.ForeColor = SystemColors.ControlLightLight;
            ManageMenuLabel.Location = new Point(220, 74);
            ManageMenuLabel.Name = "ManageMenuLabel";
            ManageMenuLabel.Size = new Size(486, 50);
            ManageMenuLabel.TabIndex = 3;
            ManageMenuLabel.Text = "ATM | MANAGE ACCOUNTS";
            // 
            // RemoveListbox
            // 
            RemoveListbox.FormattingEnabled = true;
            RemoveListbox.ItemHeight = 20;
            RemoveListbox.Location = new Point(583, 221);
            RemoveListbox.Name = "RemoveListbox";
            RemoveListbox.Size = new Size(230, 104);
            RemoveListbox.TabIndex = 5;
            // 
            // AccNamLabel
            // 
            AccNamLabel.AutoSize = true;
            AccNamLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AccNamLabel.ForeColor = SystemColors.ControlDarkDark;
            AccNamLabel.Location = new Point(160, 222);
            AccNamLabel.Name = "AccNamLabel";
            AccNamLabel.Size = new Size(148, 23);
            AccNamLabel.TabIndex = 6;
            AccNamLabel.Text = "ACCOUNT NAME:";
            // 
            // AccNumTextbox
            // 
            AccNumTextbox.Location = new Point(336, 260);
            AccNumTextbox.Name = "AccNumTextbox";
            AccNumTextbox.Size = new Size(125, 27);
            AccNumTextbox.TabIndex = 7;
            // 
            // AccNumLabel
            // 
            AccNumLabel.AutoSize = true;
            AccNumLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AccNumLabel.ForeColor = SystemColors.ControlDarkDark;
            AccNumLabel.Location = new Point(160, 261);
            AccNumLabel.Name = "AccNumLabel";
            AccNumLabel.Size = new Size(170, 23);
            AccNumLabel.TabIndex = 8;
            AccNumLabel.Text = "ACCOUNT NUMBER:";
            // 
            // AccNamTextbox
            // 
            AccNamTextbox.Location = new Point(314, 221);
            AccNamTextbox.Name = "AccNamTextbox";
            AccNamTextbox.Size = new Size(125, 27);
            AccNamTextbox.TabIndex = 9;
            // 
            // AddAccButton
            // 
            AddAccButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddAccButton.ForeColor = SystemColors.ControlDarkDark;
            AddAccButton.Location = new Point(160, 307);
            AddAccButton.Name = "AddAccButton";
            AddAccButton.Size = new Size(94, 29);
            AddAccButton.TabIndex = 10;
            AddAccButton.Text = "ADD";
            AddAccButton.UseVisualStyleBackColor = true;
            AddAccButton.Click += AddAccButton_Click;
            // 
            // RemAccButton
            // 
            RemAccButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            RemAccButton.ForeColor = SystemColors.ControlDarkDark;
            RemAccButton.Location = new Point(583, 348);
            RemAccButton.Name = "RemAccButton";
            RemAccButton.Size = new Size(94, 29);
            RemAccButton.TabIndex = 11;
            RemAccButton.Text = "REMOVE";
            RemAccButton.UseVisualStyleBackColor = true;
            RemAccButton.Click += RemAccButton_Click;
            // 
            // ManageMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 556);
            Controls.Add(RemAccButton);
            Controls.Add(AddAccButton);
            Controls.Add(AccNamTextbox);
            Controls.Add(AccNumLabel);
            Controls.Add(AccNumTextbox);
            Controls.Add(AccNamLabel);
            Controls.Add(RemoveListbox);
            Controls.Add(ManageMenuLabel);
            Controls.Add(DelAccLabel);
            Controls.Add(AddAccLabel);
            Controls.Add(pictureBox1);
            Name = "ManageMenu";
            Text = "ATM | MANAGE ACCOUNTS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label AddAccLabel;
        private Label DelAccLabel;
        private Label ManageMenuLabel;
        private ListBox RemoveListbox;
        private Label AccNamLabel;
        private TextBox AccNumTextbox;
        private Label AccNumLabel;
        private TextBox AccNamTextbox;
        private Button AddAccButton;
        private Button RemAccButton;
    }
}