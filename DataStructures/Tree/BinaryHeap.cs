using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class BinaryHeap<T> where T : IComparable<T>
    {
        private List<T> heap;

        public BinaryHeap()
        {
            this.heap = new List<T>();
        }

        public int Count
        {
            get
            {
                return this.heap.Count;
            }
        }

        public void Insert(T item)
        {
            this.heap.Add(item);

            var index = this.heap.Count - 1;


            this.HeapifyUp(index);
        }

        private void HeapifyUp(int index)
        {
            int getParent(int i) => (i - 1) / 2;

            while (IsGreater(index, getParent(index)))
            {

                Swap(index, getParent(index));
                index = getParent(index);
            }


        }

        private bool IsGreater(int index, int parent)
        {
            return heap[index].CompareTo(this.heap[parent]) > 0;
        }

        private void Swap(int index, int parent)
        {
            T temp = this.heap[index];
            this.heap[index] = this.heap[parent];
            this.heap[parent] = temp;
        }

        public T Peek()
        {
            if (this.heap[0] == null)
            {
                throw new NullReferenceException();
            }

            return this.heap[0];
        }

        public T Pull()
        {
            if (this.heap.Count <= 0)
            {
                throw new InvalidOperationException();
            }
            var firstElement = this.heap[0];
            Swap(0, this.heap.Count - 1);
            this.heap.RemoveAt(this.Count - 1);
            HeapifyDwon(0);
            return firstElement;

        }

        private void HeapifyDwon(int index)
        {
            //Left(i) = 2 * I + 1;
            //Right(i) = 2 * i + 2
            while (index < this.Count / 2)
            {
                int leftChild = 2 * index + 1;
                if (leftChild + 1 < this.Count && IsGreater(leftChild + 1, leftChild))
                {
                    leftChild++;

                }
                if (IsGreater(index, leftChild))
                {
                    break;
                }
                Swap(index, leftChild);
                
            }

        }
    }
}