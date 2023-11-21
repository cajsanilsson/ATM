using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning3Grafik
{
    internal class Denomination
    {
        public string BillName;
        public int BillValue;

        public Denomination(string Name, int Value)
        {
            BillName = Name;
            BillValue = Value;
        }

        public virtual int InsertDenomination(TextBox textBox)
        {
            int inputValue;
            if (int.TryParse(textBox.Text, out inputValue))
            {
                return inputValue * BillValue;
            }
            else
            {
                return inputValue;
            }
        }




    }
    
}
