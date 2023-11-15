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
                // Return the calculated result
                return inputValue * BillValue;
            }
            else
            {
                // Return an error value (e.g., -1) or handle the error in some way
                return -1;
            }
            //int inputValue;
            //if (int.TryParse(textBox.Text, out inputValue))
            //{
            //   int result = inputValue * BillValue;

            //
            //}


            //int sum = int.Parse();
            //BillValue = sum * BillValue;



        }
    }
}
