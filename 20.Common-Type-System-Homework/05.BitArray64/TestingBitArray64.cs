//Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
using System;

namespace _05.BitArray64
{
    public class TestingBitArray64
    {
        static void Main()
        {
            BitArray64 obj = new BitArray64(24);
            BitArray64 obj2 = new BitArray64(25);

            foreach (var n in obj)
            {
                Console.Write(n);
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int i = 64 - 1; i >= 0; i--)
            {
                Console.Write(obj[i]);
                if (i % 4 == 0)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine(obj.Equals(obj2));
            Console.WriteLine(obj2.GetHashCode());
            Console.WriteLine("Enter position:");
            Console.WriteLine(obj[int.Parse(Console.ReadLine())]);
            Console.WriteLine(obj == obj2);
            Console.WriteLine(obj != obj2);
        }
    }
}
