using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace _05.BitArray64
{
    public class BitArray64 : IEnumerable<int>
    {
        private readonly ulong value;
        private int[] bits;

        public BitArray64(ulong number)
        {
            this.value = number;
            this.bits = new int[64];
        }

        private int[] ConvertToBits()
        {
            ulong number = this.value;
            int indexator = 0;
            while (number != 0)
            {
                bits[indexator] = (int)number % 2;
                number /= 2;
                indexator++;
            }
            return bits;
        }
        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = ConvertToBits();
            for (int i = bits.Length - 1; i >= 0; i --)
            {
                yield return bits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public override bool Equals(object obj)
        {
            BitArray64 obj2 = obj as BitArray64;
            if((object)obj2==null)
            {
                throw new ArgumentException("You must entered the same object!");
            }
            return this.value.Equals(obj2.value);
        }
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
        public int this[int indexer]
        {
            get
            {
                if(indexer<0 || indexer>63 )
                {
                    throw new IndexOutOfRangeException("You must enter correct index!");
                }
                int [] bits=this.ConvertToBits();
                return bits[indexer];
            }
        }
        public static bool operator == (BitArray64 bit1,BitArray64 bit2)
        {
            return bit1.Equals(bit2);
        }
        public static bool operator !=(BitArray64 bit1,BitArray64 bit2)
        {
            return !(bit1.Equals(bit2));
        }
    }
}
