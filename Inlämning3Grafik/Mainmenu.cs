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
    public partial class Mainmenu : Form
    {

        public Mainmenu()
        {
            InitializeComponent();

            

            AtmMainLabel.Parent = pictureBox1;
            AtmMainLabel.BackColor = Color.Transparent;

            InsertLabel.Parent = pictureBox1;
            InsertLabel.BackColor = Color.Transparent;

            WithdrawLabel.Parent = pictureBox1;
            WithdrawLabel.BackColor = Color.Transparent;

            BalanceLabel.Parent = pictureBox1;
            BalanceLabel.BackColor = Color.Transparent;

            TransferLabel.Parent = pictureBox1;
            TransferLabel.BackColor = Color.Transparent;

            EndLabel.Parent = pictureBox1;
            EndLabel.BackColor = Color.Transparent;
        }

        private void BalanceLabel_MouseHover(object sender, EventArgs e)
        {
            Balancefpanel.Visible = true;
        }

        private void BalanceLabel_MouseLeave(object sender, EventArgs e)
        {
            Balancefpanel.Visible = false;
        }

        private void InsertLabel_MouseHover(object sender, EventArgs e)
        {
            InsertfPanel.Visible = true;
        }

        private void InsertLabel_MouseLeave(object sender, EventArgs e)
        {
            InsertfPanel.Visible = false;
        }

        private void WithdrawLabel_MouseHover(object sender, EventArgs e)
        {
            WithdrawfPanel.Visible = true;
        }

        private void WithdrawLabel_MouseLeave(object sender, EventArgs e)
        {
            WithdrawfPanel.Visible = false;
        }

        private void TransferLabel_MouseHover(object sender, EventArgs e)
        {
            TransferfPanel.Visible = true;
        }

        private void TransferLabel_MouseLeave(object sender, EventArgs e)
        {
            TransferfPanel.Visible = false;
        }

        private void EndLabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InsertLabel_Click(object sender, EventArgs e)
        {
            
            MenuChoice menuChoice = new MenuChoice();
            menuChoice.Show();

            InsertControl insCon1 = menuChoice.GetInsCon1();
            if (insCon1 != null)
            {
                insCon1.Visible = true;
            }
            Hide();

        }

        private void WithdrawLabel_Click(object sender, EventArgs e)
        {
            MenuChoice menuChoice = new MenuChoice();
            menuChoice.Show();
            Hide();
        }

        private void TransferLabel_Click(object sender, EventArgs e)
        {
            MenuChoice menuChoice = new MenuChoice();
            menuChoice.Show();
            Hide();
        }
    }
}
