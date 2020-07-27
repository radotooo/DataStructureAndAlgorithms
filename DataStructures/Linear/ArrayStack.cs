using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DataStructures
{
    public class ArrayStack<T>
    {
        private const int defaultCapacity = 4;
        public T[] elements { get; private set; }
        public int Count { get; private set; }

        public ArrayStack(int capacity = defaultCapacity)
        {
            this.elements = new T[capacity];
        }

        public void Push(T element)
        {

            if (this.Count == this.elements.Length)
            {
                Resize();
            }

            this.elements[this.Count++] = element;
        }
        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            var element = this.elements[--Count];
            this.elements[Count] = default; // default value of T (if int -> 0 etc...)

            return element;

        }
        public T[] ToArray()
        {

            var arr = new T[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                arr[i] = this.elements[this.Count-i-1];
            }

            return arr;
        }

        private void Resize()
        {
            var newArr = new T[this.elements.Length * 2];
            Array.Copy(this.elements, 0, newArr, 0, this.Count);
            this.elements = newArr;
        }

    }

}