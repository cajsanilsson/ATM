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
    public partial class InsertControl : UserControl
    {
        public InsertControl()
        {
            InitializeComponent();

            List<Account> accountList = new List<Account>();
            accountList.Add(new Account("SPARKONTO", 1500));
            accountList.Add(new Account("ALLKONTO", 2000));
            foreach (Account account in accountList)
            {
                AccountListBox.Items.Add(account.accountName);
            }

            HunInsLabel.Parent = pictureBox2;
            HunInsLabel.BackColor = Color.Transparent;

            TwoInsLabel.Parent = pictureBox2;
            TwoInsLabel.BackColor = Color.Transparent;

            FivInsLabel.Parent = pictureBox2;
            FivInsLabel.BackColor = Color.Transparent;

            ThoInsLabel.Parent = pictureBox2;
            ThoInsLabel.BackColor = Color.Transparent;

            InsInsLabel.Parent = pictureBox2;
            InsInsLabel.BackColor = Color.Transparent;
        }
    }
}
