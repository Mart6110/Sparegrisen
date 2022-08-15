using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparegrisen
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money;
            decimal interest;
            int years;
            int year = 1;

            Console.WriteLine("Beløb:");
            money = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Rente(%):");
            interest = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Antal år:");
            years = Convert.ToInt32(Console.ReadLine());

            // We use a for loop to display each years intrest.
            for(int i = 0; i < years; i++)
            {
                decimal interest2 = interest / 100;
                decimal earned = money * (1 + interest2);

                Console.Write(year + " år = ");
                Console.Write(money + "*" + "(1 + " + interest2 + ") = " + earned);
                Console.WriteLine();

                money = earned; // We set our the money eqaul to the earned so next time it loops through it uses the newest value in our account.

                year++; // we make year count up be one each time we loop through.
            }

            Console.ReadLine();
        }
    }
}
