using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämning3Grafik
{
    public partial class TransferMenu : Form
    {
        List<Denomination> denominationList;

        List<Account> accountList;

        private Label _accBalLabel;
        public TransferMenu(Label accBalLabel, List<Account> myaccounts)
        {
            InitializeComponent();

            _accBalLabel = accBalLabel;

            accountList = myaccounts;

            foreach (Account account in accountList)
            {
                FromListbox.Items.Add(account.accountName);
                ToListbox.Items.Add(account.accountName);
            }

            denominationList = new List<Denomination>();
            Denomination Hundralappar = new Denomination("Hundreds", 100);
            Denomination Tvåhundralappar = new Denomination("Twohundreds", 200);
            Denomination Femhundralappar = new Denomination("Fivehundreds", 500);
            Denomination Tusenlappar = new Denomination("Thousands", 1000);

            denominationList.Add(Hundralappar);
            denominationList.Add(Tvåhundralappar);
            denominationList.Add(Femhundralappar);
            denominationList.Add(Tusenlappar);

            AtmTraLabel.Parent = pictureBox1;
            AtmTraLabel.BackColor = Color.Transparent;

            HunTraLabel.Parent = pictureBox1;
            HunTraLabel.BackColor = Color.Transparent;

            TwoTraLabel.Parent = pictureBox1;
            TwoTraLabel.BackColor = Color.Transparent;

            FivTraLabel.Parent = pictureBox1;
            FivTraLabel.BackColor = Color.Transparent;

            ThoTraLabel.Parent = pictureBox1;
            ThoTraLabel.BackColor = Color.Transparent;

            InstLabel.Parent = pictureBox1;
            InstLabel.BackColor = Color.Transparent;

            InstLabel2.Parent = pictureBox1;
            InstLabel2.BackColor = Color.Transparent;

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (accountList != null && FromListbox.SelectedItem != null && ToListbox.SelectedItem !=null)
                {
                    string selectedAccountName = ToListbox.SelectedItem as string;
                    string selectedAccountName2 = FromListbox.SelectedItem as string;

                    if (selectedAccountName != null && selectedAccountName2 !=null)
                    {
                        Account selectedAccount = accountList.Find(account => account.accountName == selectedAccountName);
                        Account selectedAccount2 = accountList.Find(account => account.accountName == selectedAccountName2);
                        if (selectedAccount != null)
                        {
                            int totalValue = 0;

                            foreach (Denomination denomination in denominationList)
                            {
                                int value = denomination.InsertDenomination(GetTextBoxForDenomination(denomination));
                                totalValue += value;
                            }

                            selectedAccount.AccountBalance += totalValue;
                            selectedAccount2.AccountBalance -= totalValue;

                            UpdateAccountBalanceLabel();

                            MessageBox.Show($"{totalValue}KR IS NOW TRANSFERED FROM: {selectedAccountName2} TO: {selectedAccountName}");
                        }
                        else
                        {
                            MessageBox.Show("ACCOUNT WAS NOT FOUND.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("NO ACCOUNT TO WITHDRAW OR/AND INSERT FROM/TO. CHOOSE AN ACCOUNT BEFORE MAKING AN ACTION.");
                }
            }
            catch
            {
                MessageBox.Show("ONLY NUMBERS ALLOWED,TRY AGAIN.");
            }
        }

        private TextBox GetTextBoxForDenomination(Denomination denomination)
        {
            switch (denomination.BillName)
            {
                case "Hundreds":
                    return HunTraTextbox;
                case "Twohundreds":
                    return TwoTraTextbox;
                case "Fivehundreds":
                    return FivTraTextbox;
                case "Thousands":
                    return ThoTraTextbox;
                default:
                    throw new ArgumentException("Unknown denomination");
            }
        }

        private void UpdateAccountBalanceLabel()
        {
            string labelText = "";
            foreach (Account account in accountList)
            {
                labelText += $"{account.accountName}: {account.AccountBalance.ToString()}\n";
            }


            _accBalLabel.Text = labelText;
        }
    }
}
