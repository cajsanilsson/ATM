namespace Inlämning3Grafik
{
    partial class Mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainmenu));
            pictureBox1 = new PictureBox();
            AtmMainLabel = new Label();
            BalanceLabel = new Label();
            EndLabel = new Label();
            TransferLabel = new Label();
            WithdrawLabel = new Label();
            InsertLabel = new Label();
            Balancefpanel = new Panel();
            TransferfPanel = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label4 = new Label();
            label2 = new Label();
            WithdrawfPanel = new Panel();
            label9 = new Label();
            label5 = new Label();
            label3 = new Label();
            label7 = new Label();
            InsertfPanel = new Panel();
            label8 = new Label();
            label6 = new Label();
            label1 = new Label();
            InfoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TransferfPanel.SuspendLayout();
            WithdrawfPanel.SuspendLayout();
            InsertfPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(913, 556);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AtmMainLabel
            // 
            AtmMainLabel.AutoSize = true;
            AtmMainLabel.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            AtmMainLabel.ForeColor = SystemColors.ControlLightLight;
            AtmMainLabel.Location = new Point(275, 61);
            AtmMainLabel.Name = "AtmMainLabel";
            AtmMainLabel.Size = new Size(333, 50);
            AtmMainLabel.TabIndex = 1;
            AtmMainLabel.Text = "ATM | MAINMENU";
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BalanceLabel.ForeColor = SystemColors.ControlDarkDark;
            BalanceLabel.Location = new Point(89, 158);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(142, 23);
            BalanceLabel.TabIndex = 2;
            BalanceLabel.Text = "CHECK BALANCE";
            BalanceLabel.MouseLeave += BalanceLabel_MouseLeave;
            BalanceLabel.MouseHover += BalanceLabel_MouseHover;
            // 
            // EndLabel
            // 
            EndLabel.AutoSize = true;
            EndLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            EndLabel.ForeColor = SystemColors.ControlDarkDark;
            EndLabel.Location = new Point(781, 158);
            EndLabel.Name = "EndLabel";
            EndLabel.Size = new Size(44, 23);
            EndLabel.TabIndex = 3;
            EndLabel.Text = "END";
            EndLabel.Click += EndLabel_Click;
            // 
            // TransferLabel
            // 
            TransferLabel.AutoSize = true;
            TransferLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            TransferLabel.ForeColor = SystemColors.ControlDarkDark;
            TransferLabel.Location = new Point(644, 158);
            TransferLabel.Name = "TransferLabel";
            TransferLabel.Size = new Size(92, 23);
            TransferLabel.TabIndex = 4;
            TransferLabel.Text = "TRANSFER";
            TransferLabel.Click += TransferLabel_Click;
            TransferLabel.MouseLeave += TransferLabel_MouseLeave;
            TransferLabel.MouseHover += TransferLabel_MouseHover;
            // 
            // WithdrawLabel
            // 
            WithdrawLabel.AutoSize = true;
            WithdrawLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            WithdrawLabel.ForeColor = SystemColors.ControlDarkDark;
            WithdrawLabel.Location = new Point(443, 158);
            WithdrawLabel.Name = "WithdrawLabel";
            WithdrawLabel.Size = new Size(168, 23);
            WithdrawLabel.TabIndex = 5;
            WithdrawLabel.Text = "WITHDRAW MONEY";
            WithdrawLabel.Click += WithdrawLabel_Click;
            WithdrawLabel.MouseLeave += WithdrawLabel_MouseLeave;
            WithdrawLabel.MouseHover += WithdrawLabel_MouseHover;
            // 
            // InsertLabel
            // 
            InsertLabel.AutoSize = true;
            InsertLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            InsertLabel.ForeColor = SystemColors.ControlDarkDark;
            InsertLabel.Location = new Point(275, 158);
            InsertLabel.Name = "InsertLabel";
            InsertLabel.Size = new Size(132, 23);
            InsertLabel.TabIndex = 6;
            InsertLabel.Text = "INSERT MONEY";
            InsertLabel.Click += InsertLabel_Click;
            InsertLabel.MouseLeave += InsertLabel_MouseLeave;
            InsertLabel.MouseHover += InsertLabel_MouseHover;
            // 
            // Balancefpanel
            // 
            Balancefpanel.Location = new Point(89, 179);
            Balancefpanel.Name = "Balancefpanel";
            Balancefpanel.Size = new Size(142, 130);
            Balancefpanel.TabIndex = 7;
            Balancefpanel.Visible = false;
            // 
            // TransferfPanel
            // 
            TransferfPanel.Controls.Add(label12);
            TransferfPanel.Controls.Add(label11);
            TransferfPanel.Controls.Add(label10);
            TransferfPanel.Controls.Add(label4);
            TransferfPanel.Controls.Add(label2);
            TransferfPanel.Location = new Point(644, 179);
            TransferfPanel.Name = "TransferfPanel";
            TransferfPanel.Size = new Size(92, 130);
            TransferfPanel.TabIndex = 8;
            TransferfPanel.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(8, 95);
            label12.Name = "label12";
            label12.Size = new Size(82, 20);
            label12.TabIndex = 16;
            label12.Text = "ACCOUNT.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(8, 75);
            label11.Name = "label11";
            label11.Size = new Size(55, 20);
            label11.TabIndex = 15;
            label11.Text = "OTHER";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(6, 55);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 14;
            label10.Text = "MONEY TO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(8, 13);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 13;
            label4.Text = "PRESS TO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(8, 33);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 11;
            label2.Text = "TRANSFER";
            // 
            // WithdrawfPanel
            // 
            WithdrawfPanel.Controls.Add(label9);
            WithdrawfPanel.Controls.Add(label5);
            WithdrawfPanel.Controls.Add(label3);
            WithdrawfPanel.Controls.Add(label7);
            WithdrawfPanel.Location = new Point(443, 179);
            WithdrawfPanel.Name = "WithdrawfPanel";
            WithdrawfPanel.Size = new Size(168, 130);
            WithdrawfPanel.TabIndex = 8;
            WithdrawfPanel.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(18, 33);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 18;
            label9.Text = "DRAW MONEY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(18, 73);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 14;
            label5.Text = "OF CHOICE.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(18, 13);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 12;
            label3.Text = "PRESS TO WITH-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(18, 53);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 16;
            label7.Text = "FROM ACCOUNT";
            // 
            // InsertfPanel
            // 
            InsertfPanel.Controls.Add(label8);
            InsertfPanel.Controls.Add(label6);
            InsertfPanel.Controls.Add(label1);
            InsertfPanel.Controls.Add(InfoLabel);
            InsertfPanel.Location = new Point(275, 179);
            InsertfPanel.Name = "InsertfPanel";
            InsertfPanel.Size = new Size(132, 130);
            InsertfPanel.TabIndex = 8;
            InsertfPanel.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(10, 73);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 17;
            label8.Text = "CHOICE.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(10, 53);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 15;
            label6.Text = "ACCOUNT OF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(10, 33);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 10;
            label1.Text = "ERT MONEY TO";
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            InfoLabel.ForeColor = SystemColors.ControlDarkDark;
            InfoLabel.Location = new Point(10, 13);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(107, 20);
            InfoLabel.TabIndex = 9;
            InfoLabel.Text = "PRESS TO INS-";
            // 
            // Mainmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 556);
            Controls.Add(TransferfPanel);
            Controls.Add(WithdrawfPanel);
            Controls.Add(InsertfPanel);
            Controls.Add(Balancefpanel);
            Controls.Add(InsertLabel);
            Controls.Add(WithdrawLabel);
            Controls.Add(TransferLabel);
            Controls.Add(EndLabel);
            Controls.Add(BalanceLabel);
            Controls.Add(AtmMainLabel);
            Controls.Add(pictureBox1);
            Name = "Mainmenu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TransferfPanel.ResumeLayout(false);
            TransferfPanel.PerformLayout();
            WithdrawfPanel.ResumeLayout(false);
            WithdrawfPanel.PerformLayout();
            InsertfPanel.ResumeLayout(false);
            InsertfPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label AtmMainLabel;
        private Label BalanceLabel;
        private Label EndLabel;
        private Label TransferLabel;
        private Label WithdrawLabel;
        private Label InsertLabel;
        private Panel Balancefpanel;
        private Panel TransferfPanel;
        private Panel WithdrawfPanel;
        private Panel InsertfPanel;
        private Label label4;
        private Label label2;
        private Label label9;
        private Label label5;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label1;
        private Label InfoLabel;
        private Label label12;
        private Label label11;
        private Label label10;
    }
}