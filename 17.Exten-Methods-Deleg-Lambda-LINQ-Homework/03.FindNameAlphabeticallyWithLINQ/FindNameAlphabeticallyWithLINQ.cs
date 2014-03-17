using System;
using System.Linq;
using System.Text;

namespace _03.FindNameAlphabeticallyWithLINQ
{
    class FindNameAlphabeticallyWithLINQ
    {
        public static StringBuilder FindName(string[] array)
        {
            var seekingName =
                from name in array
                where name.Substring(0, (name.Length - name.IndexOf(' '))).CompareTo(name.Substring(name.IndexOf(' ') + 1)) == -1
                select name;
            StringBuilder sb = new StringBuilder();
            foreach (var n in seekingName)
            {
                sb.AppendLine(n);
            }

            return sb;
        }
        static void Main()
        {
            string[] array = new string[4];
            array[0] = "Georgi Georgiev";
            array[1] = "Ivan Ivanov";
            array[2] = "Grigor Dimitrov";
            array[3] = "Marin Krustev";
            Console.WriteLine(FindName(array));
        }
    }
}
