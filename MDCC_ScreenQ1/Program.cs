using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDCC_ScreenQ1
{
    public class Program
    {
        // MakeChange method as described in screening doc.
        public static int MakeChange(int amount)
        {
            // Negative arg is invalid. Cash amounts are always assumed positive.
            if (amount < 0)
            {
                throw new System.ArgumentException("Parameter cannot be negative", "amount");
            }

            // While amount is not 0, we pick the highest possible bill, add that to the bills
            // and subtract the appropriate number from amount.
            int bills = 0;
            while (amount != 0)
            {
                if (amount >= 100)
                {
                    amount -= 100;
                    bills++;
                }
                else if (amount >= 50)
                {
                    amount -= 50;
                    bills++;
                }
                else if (amount >= 20)
                {
                    amount -= 20;
                    bills++;
                }
                else if (amount >= 10)
                {
                    amount -= 10;
                    bills++;
                }
                else if (amount >= 5)
                {
                    amount -= 5;
                    bills++;
                }
                else if (amount >= 1)
                {
                    amount -= 1;
                    bills++;
                }
            }
            return bills;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
