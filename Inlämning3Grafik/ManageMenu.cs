using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.DataFormats;

namespace Inlämning3Grafik
{
    public partial class ManageMenu : Form
    {
        public List<Account> accountList;

        private Label _accBalLabel;

        string path = "account.json";

        private JsonFileManager jsonFileManager;
        public ManageMenu(Label accBalLabel, List<Account> myaccounts)
        {
            jsonFileManager = new JsonFileManager("account.json");

            _accBalLabel = accBalLabel;

            accountList = myaccounts;

            FileInfo file = new FileInfo(path);
            
            accountList = jsonFileManager.LoadAll<Account>();
                
            InitializeComponent();

            foreach (Account account in accountList)
            {
                RemoveListbox.Items.Add(account.accountName);
            }

            AddAccountLabel.Parent = pictureBox1;
            AddAccountLabel.BackColor = Color.Transparent;

            DeleteAccountLabel.Parent = pictureBox1;
            DeleteAccountLabel.BackColor = Color.Transparent;

            ManageMenuLabel.Parent = pictureBox1;
            ManageMenuLabel.BackColor = Color.Transparent;

            AccountNameLabel.Parent = pictureBox1;
            AccountNameLabel.BackColor = Color.Transparent;

            AccountNumberLabel.Parent = pictureBox1;
            AccountNumberLabel.BackColor = Color.Transparent;
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            string newAccName = AccountNameTextbox.Text;
            try
            {
                int newAccNum = (int.Parse(AccountNumberTextbox.Text));
                int newAccBal = 0;
                if (newAccName != null && newAccNum != 0)
                {
                    
                    accountList.Add(new Account(newAccName, newAccNum, newAccBal));

                    UpdateRemoveListBox();
                    jsonFileManager.SaveToJson(accountList);
                    MessageBox.Show("ACCOUNT ADDED.");
                }
                else
                {
                    MessageBox.Show("INFORMATION MISSING. FILL IN ALL TEXTBOXES.");
                }
            }
            catch
            {
                MessageBox.Show("ONLY NUMBERS ALLOWED IN ACCOUNT NUMBER TEXTBOX.");
            }
        }

        private void RemoveAccountButton_Click(object sender, EventArgs e)
        {
            if (accountList == null || RemoveListbox.SelectedItem == null)
            {
                MessageBox.Show("NO ACCOUNT TO REMOVE. CHOOSE AN ACCOUNT BEFORE MAKING AN ACTION.");
                return;
            }

            string selectedAccountName = RemoveListbox.SelectedItem as string;

            if (selectedAccountName == null)
            {
                MessageBox.Show("INVALID SELECTED ACCOUNT.");
                return;
            }

            Account selectedAccount = accountList.Find(account => account.accountName == selectedAccountName);

            if (selectedAccount == null)
            {
                MessageBox.Show("ACCOUNT WAS NOT FOUND.");
                return;
            }

            accountList.Remove(selectedAccount);
            UpdateRemoveListBox();
            UpdateAccountBalanceLabel();
            jsonFileManager.SaveToJson(accountList);
            MessageBox.Show($"{selectedAccountName} IS NOW REMOVED.");
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

        public void UpdateRemoveListBox()
        {
            RemoveListbox.Items.Clear();

            foreach (Account account in accountList)
            {
                RemoveListbox.Items.Add($"{account.accountName}");

            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
