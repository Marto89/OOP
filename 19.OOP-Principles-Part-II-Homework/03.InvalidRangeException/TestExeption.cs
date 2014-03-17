//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

using System;
using System.Globalization;

namespace _03.InvalidRangeException
{
    class TestExeption
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            int pointInOurRange;

            Console.WriteLine("Enter point in the range [1..100]!");

            try
            {
                pointInOurRange = int.Parse(Console.ReadLine());
                if ((pointInOurRange < start) || (pointInOurRange > end))
                {
                    throw new InvalidRangeException<int>("Please consider the range!", start, end);
                }
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine("Range should be [{0}..{1}]!",e.Start,e.End);
                Console.WriteLine(e.Message);
            }

            DateTime startDate = new DateTime(1980,1,1);
            DateTime endDate = DateTime.Now;

            DateTime dateTime;
            Console.WriteLine("Enter one date in format(2013.1.15) in range[1, 1, 1980...Now]!");
            Console.OutputEncoding = System.Text.Encoding.GetEncoding("Cyrillic"); ;
            try
            {
                dateTime = DateTime.Parse(Console.ReadLine());
                if ((dateTime < startDate) || (dateTime > endDate))
                {
                    throw new InvalidRangeException<DateTime>("Please consider the range!", startDate, endDate);
                }
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine("Range should be [{0}...{1}]!", e.Start, e.End);
                Console.WriteLine(e.Message);
            }
        }
    }
}
