using System;

namespace assignment1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float l, b, per;
            Console.WriteLine("enter the length and breadth of the rectangle");
            l = Convert.ToSingle(Console.ReadLine());
            b= Convert.ToSingle(Console.ReadLine());
            per = 2 * (l + b);
            Console.WriteLine("the perimeter of the rectangle is{0}", per);

        }
    }
}
