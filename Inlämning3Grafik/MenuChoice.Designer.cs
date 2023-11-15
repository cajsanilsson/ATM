namespace Inlämning3Grafik
{
    partial class MenuChoice
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
            InsCon1 = new InsertControl();
            SuspendLayout();
            // 
            // InsCon1
            // 
            InsCon1.Location = new Point(0, 0);
            InsCon1.Name = "InsCon1";
            InsCon1.Size = new Size(1036, 563);
            InsCon1.TabIndex = 0;
            InsCon1.Visible = false;
            // 
            // MenuChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 556);
            Controls.Add(InsCon1);
            Name = "MenuChoice";
            Text = "MenuChoice";
            ResumeLayout(false);
        }

        #endregion

        private InsertControl InsCon1;
    }
}