using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV01.Question_4
{
    internal class FixedSizeList<T>
    {
        private T[] items;
        private int count;
        private int capacity;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than 0");

            this.capacity = capacity;
            this.items = new T[capacity];
            this.count = 0;
        }

        public int Count => count;

        public int Capacity => capacity;

        public void Add(T item)
        {
            if (count >= capacity)
                throw new InvalidOperationException("List is full, Cannot add more elements");

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Invalid index");

            return items[index];
        }
    }
}
