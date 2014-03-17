using System;
using System.Text;

namespace _01.StringBuilderSubstring
{
    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            if (index < 0 || index >= sb.Length)
            {
                throw new IndexOutOfRangeException("Index cannot be negative or bigger than StringBuilder length!");
            }
            if (length + index > sb.Length)
            {
                throw new IndexOutOfRangeException("Length must be less than StringBuilder length!");
            }
            StringBuilder sbNew = new StringBuilder();
            for (int i = index; i < length + index; i++)
            {
                sbNew.Append(sb[i]);
            }
            return sbNew;
        }
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("TelerikAcademy");
            sb = sb.Substring(7, 7);
            Console.WriteLine(sb.ToString());
        }
    }
}
