using System;
using System.Collections.Generic;
using System.Text;


namespace Console_furniture

{
    class Class2
    {
        public class Furniture
        {
            public double Price;
            public string Designation;
            public Furniture()
            {


            }
        }
        public class BookShelf : Furniture
        {
            public BookShelf()
            {
                Price = 80;
                Designation = "plywood shelf\n ";
            }
        }
        public class DiningTable : Furniture
        {
            public DiningTable()
            {
                Price = 100;
                Designation = "wood table\n";
            }
        }
        static void Main(string[] args)
        {
            List<Furniture> f = new List<Furniture>();
            AddToStock(f);
            ShowStockDetails(f);
            Console.ReadKey();
        }


        public static void AddToStock(List<Furniture> f)
        {
            for (int i = 1; i <= 1; i++)
            {
                Console.WriteLine("Choose what furniture you want to stock: \n" +
                                "1.Dinning table \n" +
                                "2.Book Shelf \n" +
                                "3.Finish stock \n");
                Console.WriteLine("Your choice: ");
               int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            f.Add(new DiningTable());
                            break;
                        }
                    case 2:
                        {
                            f.Add(new BookShelf());
                            break;
                        }

                    default: break;
                }
                Console.Clear();
            }

        }
        public static double TotalStockValue(List<Furniture> f)
        {
             double totalStockValue = 0;
            foreach (var furniture in f)
            {
                totalStockValue += furniture.Price;
            }


            return totalStockValue;
        }


        public static void ShowStockDetails(List<Furniture> f)
        {
            Console.WriteLine("Your stock:");
            foreach (Furniture furniture in f)
            {
                Console.WriteLine($"Designation: {furniture.Designation} Price: {furniture.Price}\n");
            }
            Console.WriteLine($"Total stock value: {TotalStockValue(f)}");
        }


    }
}
   