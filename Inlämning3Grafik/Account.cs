using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning3Grafik
{
    public class Account
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
        
    }
}
