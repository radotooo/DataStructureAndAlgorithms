using System;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;

namespace DataStructures
{
    public class CircularQueue<T>
    {
        private const int DefaultCapacity = 16;
        private T[] Elements { get; set; }
        public int Count { get; private set; }
        private int startIndex;
        private int endIndex;


        public CircularQueue(int capacity = DefaultCapacity)
        {
            Elements = new T[capacity];
        }

        public void Enqueue(T element)
        {
            if (this.Count == this.Elements.Length)
            {
                this.Resize();
            }
            this.Elements[endIndex] = element;
            //find end index
            this.endIndex = (this.endIndex + 1) % this.Elements.Length;
            this.Count++;
        }

        private void Resize()
        {
            var newData = new T[this.Elements.Length * 2];

            CopyAllElements(newData);

        }

        private void CopyAllElements(T[] newArray)
        {
            var count = 0;
            int sourceIndex = this.startIndex;
            for (int i = 0; i < this.Count; i++)
            {
                newArray[count] = this.Elements[sourceIndex];
                //find start Index
                sourceIndex = (sourceIndex + 1) % this.Elements.Length;
                count++;
            }
            this.Elements = newArray;
            this.startIndex = 0;
            this.endIndex = this.Count;

        }

        // Should throw InvalidOperationException if the queue is empty
        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }
            var element = this.Elements[startIndex];
            this.startIndex = (this.startIndex + 1) % this.Elements.Length;
            this.Count--;
            return element;
        }

        public T[] ToArray()
        {

            var result = new T[this.Count];
            var count = 0;
            int sourceIndex = this.startIndex;
            for (int i = 0; i < this.Count; i++)
            {
                result[count] = this.Elements[sourceIndex];
                //find start Index
                sourceIndex = (sourceIndex + 1) % this.Elements.Length;
                count++;
            }
            return result;
        }
    }
}


