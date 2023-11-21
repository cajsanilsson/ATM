namespace Inlämning3Grafik
{
    public partial class Start : Form
    {
        List<Account> accountList;

        
        public Start()
        {
            InitializeComponent();

            

            accountList = new List<Account>();
            accountList.Add(new Account("SAVINGS ACCOUNT", 123-456, 1500));
            accountList.Add(new Account("GENERAL ACCOUNT", 456-789,  2000));

            string labelText = "";
            foreach (Account account in accountList)
            {
                labelText += $"{account.accountName}: {account.AccountBalance.ToString()}\n";
            }

            AccBalLabel.Text = labelText;

            

            PinLabel.Parent = pictureBox1;
            PinLabel.BackColor = Color.Transparent;

            AtmLabel.Parent = pictureBox1;
            AtmLabel.BackColor = Color.Transparent;

            MainmenuLabel.Parent = pictureBox1;
            MainmenuLabel.BackColor = Color.Transparent;

            BalanceLabel.Parent = pictureBox1;
            BalanceLabel.BackColor = Color.Transparent;

            InsertLabel.Parent = pictureBox1;
            InsertLabel.BackColor = Color.Transparent;

            WithdrawLabel.Parent = pictureBox1;
            WithdrawLabel.BackColor = Color.Transparent;

            TransferLabel.Parent = pictureBox1;
            TransferLabel.BackColor = Color.Transparent;

            EndLabel.Parent = pictureBox1;
            EndLabel.BackColor = Color.Transparent;

            AccBalLabel.Parent = pictureBox1;
            AccBalLabel.BackColor = Color.Transparent;

            ManageLabel.Parent = pictureBox1;
            ManageLabel.BackColor = Color.Transparent;

            MainmenuLabel.Visible = false;
            BalanceLabel.Visible = false;
            InsertLabel.Visible = false;
            WithdrawLabel.Visible = false;
            TransferLabel.Visible = false;
            EndLabel.Visible = false;
            pictureBox1.Visible = true;

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
                    PinTextbox.Visible = false;
                    PinLabel.Visible = false;
                    EnterButton.Visible = false;
                    AtmLabel.Visible = false;
                    CardButton.Visible = false;
                    EndButton.Visible = false;
                    MainmenuLabel.Visible = true;
                    BalanceLabel.Visible = true;
                    InsertLabel.Visible = true;
                    WithdrawLabel.Visible = true;
                    TransferLabel.Visible = true;
                    EndLabel.Visible = true;
                    AccBalLabel.Visible = true;
                    ManageLabel.Visible = true;
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

        private void EndLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InsertLabel_Click(object sender, EventArgs e)
        {
            InsertMenu insertMenu = new InsertMenu(AccBalLabel); 
            insertMenu.Show();
        }

        private void WithdrawLabel_Click(object sender, EventArgs e)
        {
            WithdrawMenu withdrawMenu = new WithdrawMenu(AccBalLabel);
            withdrawMenu.Show();
        }

        private void TransferLabel_Click(object sender, EventArgs e)
        {
            TransferMenu transferMenu = new TransferMenu(AccBalLabel);
            transferMenu.Show();
        }

        private void ManageLabel_Click(object sender, EventArgs e)
        {
            ManageMenu manageMenu = new ManageMenu(AccBalLabel);
            manageMenu.Show();
        }
    }
}