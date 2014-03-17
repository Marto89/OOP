using System;

namespace _03.InvalidRangeException
{
    public class InvalidRangeException<T> : ApplicationException
        where T : IComparable<T>
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end, Exception e)
            : base(message, e)
        {
            this.Start = start;
            this.End = end;
        }
        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null) { }
        public InvalidRangeException(T start, T end)
            : this(null, start, end, null) { }
        public T Start
        {
            get { return this.start; }
            private set { this.start = value; }
        }
        public T End
        {
            get { return this.end; }
            private set
            {
                if (value.CompareTo(this.Start) < 0)
                {
                    throw new ArgumentException("End cannot be less then start!");
                }
                this.end = value;
            }
        }
    }
}
