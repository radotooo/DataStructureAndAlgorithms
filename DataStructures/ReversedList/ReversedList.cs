using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// Custom collection that represent reversed List
    /// </summary>
    /// <typeparam name="T">Type of element in the ReversedList</typeparam>

    public class ReversedList<T> : IEnumerable<T>
    {
        private T[] data;
        private int size;
        private int capacity = 2;
        
        public ReversedList()
        {
            this.data = new T[capacity];
        }
        public ReversedList(params T[] data)
        {
            this.data = data;
            this.size = data.Length;
            if (this.capacity < data.Length)
            {
                SetCapacity(data);

            }
        }
        public void Add(T item)
        {
            if(this.size == this.capacity)
            {
                Array.Resize(ref this.data, this.capacity * 2);
                this.capacity *= 2;
            }
           
            this.data[size] = item;
            this.size++;

        }
        public int Capacity()
        {
            return this.capacity;

        }
        public int Count()
        {
            return this.size;
        }

        public T this[int index]
        {
            get
            {
                return this.data[size - index - 1];
            }
            set
            {
                this.data[size - index - 1] = value;
            }
        }
        //{
        //    int count = 0;
        //    var newArr = new T[data.Length];
        //     Array.Copy(data,newArr,data.Length);
        //    for (int i = data.Length - 1; i >= 0; i--)
        //    {
        //        newArr[count] = data[i];
        //        count++;
        //    }
        //    return newArr;
        //}
        private void SetCapacity(T[] data)
        {
            while (this.capacity < data.Length)
            {
                this.capacity *= 2;
            }
        }
        public T RemoveAt(int index)
        {
            var currentElement = data[size-index-1];
            for (int i = this.size-index; i < this.size; i++)
            {
                this.data[i - 1] = this.data[i];
            }
            this.size--;
           
            return currentElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            int count = 0;
            while (count < size)
            {
                yield return this.data[size - count - 1];
                count++;
            }
           
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
