using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{

    public class DoublyListNode<T>
    {
        public DoublyListNode<T> Next { get; set; }
        public DoublyListNode<T> Previous { get; set; }
        public T Value { get; private set; }
        public DoublyListNode(T value)
        {
            this.Value = value;
        }
    }

}
