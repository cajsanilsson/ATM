using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning3Grafik
{
    internal class Account
    {
        public string accountName;
        public int accountNumber;
        private int accountBalance;

        public Account(string Konto, int Nummer, int Saldo)
        {
            accountName = Konto;
            AccountBalance = Saldo;
            accountNumber = Nummer;
        }
        public int AccountBalance
        {
            get
            {
                return accountBalance;
            }
            set
            {
                accountBalance = value;
            }
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine(accountName + "Saldo: " + accountBalance);
        }

        public virtual void PrintBalanceInfo()
        {
            Console.WriteLine("Beloppet du angett överstiger till saldo med: " + accountBalance + "KR, ange ett lägre belopp.");
        }
        public virtual void WithdrawError()
        {
            int TotaleIns = int.Parse(Console.ReadLine());
            accountBalance = accountBalance - TotaleIns;
            PrintBalanceInfo();
        }
    }
}
