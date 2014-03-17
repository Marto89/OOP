using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02.ExtensionMethodsForInterface
{
    public static class ExtensionMethodsForInterface
    {
        public static T Sum<T>(this IEnumerable<T> sum)
        {
            T type=default(T);
            foreach (T n in sum)
            {
                type +=(dynamic)n;
            }

            return type;
        }
        public static decimal Product<T>(this IEnumerable<T> product)
        {
            decimal type = 1;
            try
            {
                foreach (T n in product)
                {
                    type *= Convert.ToDecimal(n);
                }
            }
            catch (FormatException formEx)
            {
                throw new ArgumentException("Collection cannot be modifed with the default transformer!", formEx);
            }
            catch (InvalidCastException invEx)
            {
                throw new ArgumentException("Collection cannot be modifed with the default transformer!", invEx);
            }
            return type;
        }
        public static T Min<T>(this IEnumerable<T> min) 
            where T : IComparable
        {
            T type = min.First();
            foreach (T n in min)
            {
                if(type.CompareTo(n)>0)
                {
                    type = n;
                }
            }
            return type;
        }
        public static T Max<T>(this IEnumerable<T> max)
            where T : IComparable
        {
            T type = max.First();
            foreach (T n in max)
            {
                if (type.CompareTo(n) < 0)
                {
                    type = n;
                }
            }
            return type;
        }
        public static decimal Average<T>(this IEnumerable<T> average)
        {
            decimal result = default(decimal);
            try
            {
                foreach (T n in average)
                {
                    result += Convert.ToDecimal(n);
                }
                result /= average.Count();
            }
            catch (FormatException formEx)
            {
                throw new ArgumentException("Collection cannot be modifed with the default transformer!", formEx);
            }
            catch (InvalidCastException invEx)
            {
                throw new ArgumentException("Collection cannot be modifed with the default transformer!", invEx);
            }
            return result;
        }
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3 );
            list.Add(4);
            list.Add(5);
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());      
            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Average());
            Console.WriteLine(list.Product());
        }
    }
}
