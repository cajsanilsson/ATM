namespace Inlämning3Grafik
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();

            PinLabel.Parent = pictureBox1;
            PinLabel.BackColor = Color.Transparent;

            AtmLabel.Parent = pictureBox1;
            AtmLabel.BackColor = Color.Transparent;
        }

        private void CardButton_Click(object sender, EventArgs e)
        {
            EndButton.Visible = false;
            PinLabel.Visible = true;
            PinTextbox.Visible = true;
            EnterButton.Visible = true;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int pintextbox = int.Parse(PinTextbox.Text);
                if (pintextbox == 1234)
                {
                    Mainmenu mainmenu = new Mainmenu();
                    mainmenu.Show();
                }
                else
                {
                    MessageBox.Show("PIN INCORRECT, TRY AGAIN.");
                }
            }
            catch
            {
                MessageBox.Show("ONLY NUMBERS ALLOWED, TRY AGAIN.");
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}