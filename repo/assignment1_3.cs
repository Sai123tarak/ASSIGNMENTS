using System;

namespace assignment1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            float f;
            Console.WriteLine("enter temperatue in celsius:");
            c = Convert.ToInt16(Console.ReadLine());
            f=(c * 9) / 5+ 32 ;
            Console.WriteLine("temperature in farhenheit is:{0}", f);

        }
    }
}
