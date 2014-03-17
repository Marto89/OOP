using System;
using System.Text;
using System.Linq;

namespace _05_07.GenericListT
{
	class GenericList<T>
		where T : IComparable
	{
		private T[] array;
		private int counter = 0;

		public GenericList(int capacity)
		{
			this.array = new T[capacity];
		}
		public void AddElement(T element)
		{
			if (counter == this.array.Length)
			{
				AutoGrowFunc();
			}
			this.array[counter] = element;
			counter++;
		}
		public T AccessElement(int index)
		{
			if (index < 0 || index > this.array.Length - 1)
			{
				throw new IndexOutOfRangeException("Index should be positive number and less then capacity!");
			}
			return array[index];
		}
		public void RemoveElementAt(int index)
		{
			if (index < 0 || index > this.array.Length - 1)
			{
				throw new IndexOutOfRangeException("Index should be positive number and less then capacity!");
			}
			for (int i = index; i < array.Length - 1; i++)
			{
				this.array[i] = this.array[i + 1];
			}
			T[] newArray = new T[this.array.Length];
			this.array.CopyTo(newArray, 0);
			this.array = new T[newArray.Length - 1];
			for (int i = 0; i < newArray.Length - 1; i++)
			{
				this.array[i] = newArray[i];
			}
			counter--;
		}
		public void InsertAtPosition(T element, int index)
		{
			counter++;
			if (index < 0 || index > this.array.Length)
			{
				throw new IndexOutOfRangeException("Index should be positive number and less then capacity!");
			}
			T[] newArray = new T[this.array.Length];
			this.array.CopyTo(newArray, 0);
			this.array = new T[this.array.Length + 1];
			for (int i = 0; i < index; i++)
			{
				this.array[i] = newArray[i];
			}
			array[index] = element;
			for (int i = index; i < newArray.Length; i++)
			{
				this.array[i + 1] = newArray[i];
			}
		}
		public void ClearList()
		{
			counter = 0;
			this.array = new T[this.array.Length];
		}
		public int FindingElementByValue(T value)
		{
			int index = 0;
			foreach (var n in this.array)
			{
				if (n.Equals(value))
				{
					return index;
				}
				index++;
			}
			return -1;
		}
		private void AutoGrowFunc()
		{
			T[] newArray = new T[this.array.Length * 2];
			Array.Copy(this.array, newArray, this.array.Length);
			this.array = newArray;
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			int index = 1;
			for (int i = 0; i < counter; i++)
			{
				sb.AppendFormat("{0} element---> {1}\n", index, this.array[i]);
				index++;
			}
			return sb.ToString();
		}
		public T Min()
		{
			T minElement = array[0];
			for (int i = 1; i < counter; i++)
			{
				if (minElement.CompareTo(array[i]) > 0)
				{
					minElement = array[i];
				}
			}
			return minElement;
		}
        public T Max()
        {
            T maxElement = array[0];
            for (int i = 1; i < counter; i++)
            {
                if (maxElement.CompareTo(array[i]) < 0)
                {
                    maxElement = array[i];
                }
            }
            return maxElement;
        }
	}
}
