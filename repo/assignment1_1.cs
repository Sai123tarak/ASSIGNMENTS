using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1

{
    class program
    {
        static void Main(string[] args)
        {
            int year;
            double pramt = 23000;
           double rate = 12.75;
            Console.WriteLine("enter no of years:");
            year = Convert.ToInt16(Console.ReadLine());
            double si = (pramt * year * rate) / 100;
            double amount = pramt + si;
            Console.WriteLine("the simple interst is{0}and the total amount is{1}", si, amount);


        }
    }
}
