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
    public partial class ManageMenu : Form
    {

        List<Denomination> denominationList;

        List<Account> accountList;

        private Label _accBalLabel;

        public InsertMenu InsertMenu;
        public ManageMenu(Label accBalLabel)
        {
            _accBalLabel = accBalLabel;

            InitializeComponent();

            accountList = new List<Account>();
            accountList.Add(new Account("SAVINGS ACCOUNT", 123 - 456, 1500));
            accountList.Add(new Account("GENERAL ACCOUNT", 456 - 789, 2000));
            foreach (Account account in accountList)
            {
                RemoveListbox.Items.Add(account.accountName);
            }

            AddAccLabel.Parent = pictureBox1;
            AddAccLabel.BackColor = Color.Transparent;

            DelAccLabel.Parent = pictureBox1;
            DelAccLabel.BackColor = Color.Transparent;

            ManageMenuLabel.Parent = pictureBox1;
            ManageMenuLabel.BackColor = Color.Transparent;

            AccNamLabel.Parent = pictureBox1;
            AccNamLabel.BackColor = Color.Transparent;

            AccNumLabel.Parent = pictureBox1;
            AccNumLabel.BackColor = Color.Transparent;

        }


        private void AddAccButton_Click(object sender, EventArgs e)
        {
            string newAccName = AccNamTextbox.Text;
            try
            {
                int newAccNum = (int.Parse(AccNumTextbox.Text));
                int newAccBal = 0;
                if (newAccName != null && newAccNum != 0)
                {

                    accountList.Add(new Account(newAccName, newAccNum, newAccBal));

                    UpdateRemListBox();
                    UpdateAccBalLabel();
                   
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
        private void RemAccButton_Click(object sender, EventArgs e)
        {
            if (accountList != null && RemoveListbox.SelectedItem != null)
            {
                string selectedAccountName = RemoveListbox.SelectedItem as string;
               
                if (selectedAccountName != null)
                {
                    Account selectedAccount = accountList.Find(account => account.accountName == selectedAccountName);
                   
                    if (selectedAccount != null)
                    {

                        accountList.Remove(selectedAccount);

                        UpdateRemListBox(); 

                        UpdateAccBalLabel();

                        MessageBox.Show($"{selectedAccountName} IS NOW REMOVED.");
                    }
                    else
                    {
                        MessageBox.Show("ACCOUNT WAS NOT FOUND.");
                    }
                }
            }
            else
            {
                MessageBox.Show("NO ACCOUNT TO REMOVE. CHOOSE AN ACCOUNT BEFORE MAKING AN ACTION.");
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
        public void UpdateRemListBox()
        {
            RemoveListbox.Items.Clear();

            foreach (Account account in accountList)
            {
                RemoveListbox.Items.Add($"{account.accountName}: {account.AccountBalance.ToString()}");

            }
        }
    }
}
