
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DataStructures
{


    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }

        public void AddFirst(T element)
        {

            if (this.Count == 0)
            {
                this.Head = this.Tail = new ListNode<T>(element);
            }
            else
            {
                var newHead = new ListNode<T>(element);
                newHead.Next = this.Head;
                this.Head.Previous = newHead;
                this.Head = newHead;

            }
            this.Count++;
        }

        public void AddLast(T element)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new ListNode<T>(element);
            }
            else
            {
                var newHead = new ListNode<T>(element);
                newHead.Previous = this.Tail;
                this.Tail.Next = newHead;
                this.Tail = newHead;

            }
            this.Count++;

        }

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List empty");
            }

            var currentHead = this.Head.Value;
            this.Head = this.Head.Next;

            if (this.Head != null)
            {
                this.Head.Previous = null;
            }
            else
            {
                this.Tail = null;
            }
            this.Count--;
            return currentHead;

        }


        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List empty");
            }
            var currentTail = this.Tail.Value;

            //get current tail pravious element and make it the new tail
            this.Tail = this.Tail.Previous;



            if (this.Tail != null)
            {
                //if tail exist make next element null since it is las element in the collection
                this.Tail.Next = null;
            }
            else
            {
                //if not this mean that collection is empty 
                //so head must be asign null since the head is old Tail  element

                this.Head = null;
            }
            this.Count--;
            return currentTail;
        }

        public void ForEach(Action<T> action)
        {
            var currentNode = this.Head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;

            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentElement = this.Head;

            while (currentElement != null)
            {
                yield return currentElement.Value;
                currentElement = currentElement.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T[] ToArray()
        {

            var result = new T[this.Count];
            var currentElement = this.Head;
            var count = 0;
            while (currentElement != null)
            {
                result[count] = currentElement.Value;
                currentElement = currentElement.Next;
                count++;
            }
            return result;
        }
    }

}
