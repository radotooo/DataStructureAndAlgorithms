using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace DataStructures
{

    public class BinarySearchTree<T> where T : IComparable<T> // T inherit IComparable
    {
        private class Node
        {
            public T Value { get; set; }
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }

            public Node(T value, Node leftNode = null, Node rightNode = null)
            {
                this.Value = value;
                this.LeftNode = leftNode;
                this.RightNode = rightNode;
            }
        }

        private Node Root { get; set; }
        public BinarySearchTree()
        {

        }
        private BinarySearchTree(Node root)
        {
            this.TreeCopy(root);
        }

        public void Insert(T value)
        {
            Node current = this.Root;
            if (current == null)
            {
                this.Root = new Node(value);
                return;
            }
            while (current != null)
            {
                if (current.Value.CompareTo(value) == -1)
                {
                    if (current.RightNode == null)
                    {
                        current.RightNode = new Node(value);
                    }
                    else
                    {

                        current = current.RightNode;
                    }

                }
                else if (current.Value.CompareTo(value) == 1)
                {
                    if (current.LeftNode == null)
                    {
                        current.LeftNode = new Node(value);
                    }
                    else
                    {

                        current = current.LeftNode;
                    }
                }
                else if (current.Value.CompareTo(value) == 0)
                {
                    break;
                }

            }
        }



        public bool Contains(T value)
        {
            var current = this.Root;

            while (current != null)
            {
                if (current.Value.CompareTo(value) == 0)
                {
                    return true;
                }
                else if (current.Value.CompareTo(value) == -1)
                {
                    current = current.RightNode;
                }
                else if (current.Value.CompareTo(value) == 1)
                {
                    current = current.LeftNode;
                }
            }
            return false;

        }

        public void DeleteMin()
        {
            //TODO FIX
            var current = this.Root;
            Node parrent = null;
            if (current == null)
            {
                return;
            }

            if (current.LeftNode == null)
            {
                this.Root = this.Root.RightNode;
                return;
            }

            while (current.LeftNode != null)
            {
                parrent = current;
                current = current.LeftNode;
            }

            parrent.LeftNode = current.RightNode;

        }

        public BinarySearchTree<T> Search(T item)
        {
            var current = this.Root;
            while (current != null)
            {
                if (current.Value.CompareTo(item) > 0)
                {
                    current = current.LeftNode;

                }
                else if (current.Value.CompareTo(item) < 0)
                {
                    current = current.RightNode;
                }
                else
                {
                    break;
                }
            }

            if (current == null)
            {
                return new BinarySearchTree<T>();
            }
            else
            {
                return new BinarySearchTree<T>(current);
            }

        }
        public void PrintIndentedPreOrder(int indent = 0)
        {

            Console.WriteLine(this.Root.Value);
            PrintElements(indent, this.Root);

        }

        private void PrintElements(int indent, Node node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                Console.WriteLine($"{new string(' ', indent )}{node.Value}");
                PrintElements(indent +1, node.LeftNode);
                PrintElements(indent +1, node.RightNode);
            }

        }
        private void TreeCopy(Node current)
        {
            if (current == null)
            {
                return;
            }
            this.Insert(current.Value);
            this.TreeCopy(current.LeftNode);
            this.TreeCopy(current.RightNode);


        }

        public IEnumerable<T> Range(T startRange, T endRange)
        {
            var queue = new Queue<T>();
            this.Range(this.Root, queue, startRange, endRange);
            return queue;
        }

        private void Range(Node node, Queue<T> queue, T startRange, T endRange)
        {
            if (node == null)
            {
                return;
            }
            this.Range(node.LeftNode, queue, startRange, endRange);

            if (node.Value.CompareTo(startRange) >= 0 && node.Value.CompareTo(endRange) <= 0)
            {
                queue.Enqueue(node.Value);
            }
            this.Range(node.RightNode, queue, startRange, endRange);
        }

        public void EachInOrder(Action<T> action)
        {
            var root = this.Root;
            TraverseBst(action, root);
        }

        private void TraverseBst(Action<T> action, BinarySearchTree<T>.Node node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                TraverseBst(action, node.LeftNode);
                action(node.Value);
                TraverseBst(action, node.RightNode);

            }
        }
    }
}