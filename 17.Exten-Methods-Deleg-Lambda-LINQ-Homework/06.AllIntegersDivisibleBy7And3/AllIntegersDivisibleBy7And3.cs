using System;
using System.Linq;

namespace _06.AllIntegersDivisibleBy7And3
{
    class AllIntegersDivisibleBy7And3
    {
        static void Main()
        {
            Console.WriteLine("Enter array length:");
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nWith Lambda expresions:\n");
            var seekingNumbers = array.Where(integer => integer % 3 == 0 && integer % 7 == 0);
            foreach (var n in seekingNumbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nWith LINQ\n");

            var seekingNumbers2 =
                from n in array
                where n % 3 == 0 && n % 7 == 0
                select n;
            foreach (var n in seekingNumbers2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
