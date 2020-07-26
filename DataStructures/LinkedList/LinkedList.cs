using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DataStructures
{

    public class LinkedList<T> : IEnumerable<T>
    {

        public LinkedListNode<T> Head { get; set; }
        public LinkedListNode<T> Tail { get; set; }

        public int Count { get; private set; }


        public void AddFirst(T item)
        {
            var oldHead = this.Head;
            this.Head = new LinkedListNode<T>(item);
            this.Head.Next = oldHead;

            if (IsEmpty())
            {
                this.Tail = this.Head;
            }
            this.Count++;

        }


        public void AddLast(T item)
        {
            var oldTail = this.Tail;
            this.Tail = new LinkedListNode<T>(item);

            if (IsEmpty())
            {
                this.Head = this.Tail;
            }
            else
            {
                oldTail.Next = this.Tail;

            }
            this.Count++;
        }

        public T RemoveFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("No such element!");
            }

            var elementToRemove = this.Head;
            this.Head = elementToRemove.Next;
            if (this.Head == null)
            {
                this.Head = this.Tail = null;
            }

            this.Count--;
            return elementToRemove.Value;

        }

        public T RemoveLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("No such element!");
            }

            var currentTail = this.Tail;

            if (this.Count == 1)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                LinkedListNode<T> newTail = GetSecondToLast();
                this.Tail = newTail;
                newTail.Next = null;
            }
            this.Count--;
            return currentTail.Value;
        }


        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T> tempNode = this.Head;
            while (tempNode != null)
            {
                yield return tempNode.Value;
                tempNode = tempNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private bool IsEmpty()
        {
            return this.Count == 0;
        }
        private LinkedListNode<T> GetSecondToLast()
        {
            LinkedListNode<T> tempNode = this.Head;

            //This will get the second to last element !
            while (tempNode.Next.Next != null)
            {
                tempNode = tempNode.Next;
            }
            return tempNode;
        }

    }
}