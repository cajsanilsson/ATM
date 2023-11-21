using Inlämning3Grafik;
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
    public partial class InsertMenu : Form
    {
        List<Denomination> denominationList;

        List<Account> accountList;

        private Label _accBalLabel;

        public InsertMenu(Label accBalLabel)
        {
            InitializeComponent();

            _accBalLabel = accBalLabel;

            accountList = new List<Account>();
            accountList.Add(new Account("SAVINGS ACCOUNT", 123-456,  1500));
            accountList.Add(new Account("GENERAL ACCOUNT", 456-789, 2000));
            foreach (Account account in accountList)
            {
                AccountListBox.Items.Add(account.accountName); 
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

            InsInsLabel.Parent = pictureBox1;
            InsInsLabel.BackColor = Color.Transparent;

            HunInsLabel.Parent = pictureBox1;
            HunInsLabel.BackColor = Color.Transparent;

            TwoInsLabel.Parent = pictureBox1;
            TwoInsLabel.BackColor = Color.Transparent;

            FivInsLabel.Parent = pictureBox1;
            FivInsLabel.BackColor = Color.Transparent;

            ThoInsLabel.Parent = pictureBox1;
            ThoInsLabel.BackColor = Color.Transparent;

            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

        }

        private void BackInsButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void InsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (accountList != null && AccountListBox.SelectedItem != null)
                {
                    string selectedAccountName = AccountListBox.SelectedItem as string;

                    if (selectedAccountName != null)
                    {
                        Account selectedAccount = accountList.Find(account => account.accountName == selectedAccountName);

                        if (selectedAccount != null)
                        {
                            int totalValue = 0;

                            foreach (Denomination denomination in denominationList)
                            {
                                int value = denomination.InsertDenomination(GetTextBoxForDenomination(denomination));
                                totalValue += value;
                            }

                            selectedAccount.AccountBalance += totalValue;

                            UpdateAccBalLabel();

                            MessageBox.Show($"{totalValue}KR IS NOW INSERTED TO: {selectedAccountName}.");
                        }
                        else
                        {
                            MessageBox.Show("ACCOUNT WAS NOT FOUND.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("NO ACCOUNT TO INSERT TO. CHOOSE AN ACCOUNT BEFORE MAKING AN ACTION.");
                }
            }
            catch 
            {
                MessageBox.Show("ONLY NUMBERS ALLOWED. TRY AGAIN");
            }
        }

        private TextBox GetTextBoxForDenomination(Denomination denomination)
        {
            switch (denomination.BillName)
            {
                case "Hundreds":
                    return HunInsTextbox;
                case "Twohundreds":
                    return TwoInsTextbox;
                case "Fivehundreds":
                    return FivInsTextbox;
                case "Thousands":
                    return ThoInsTextbox;
                default:
                    throw new ArgumentException("Unknown denomination");
            }
        }



        private void UpdateAccBalLabel()
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






