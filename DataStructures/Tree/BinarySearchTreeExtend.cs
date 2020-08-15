using System;
using System.Collections.Generic;
using System.Linq;


namespace DataStructures
{
    public class BinarySearchTreeExtend<T> where T : IComparable
    {

        private class Node
        {
            public Node(T value)
            {
                this.Value = value;
                this.Count = 0;
            }

            public T Value { get; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Count { get; set; }
        }

        private Node root;
        private BinarySearchTreeExtend(Node node)
        {
            this.PreOrderCopy(node);
        }

        public BinarySearchTreeExtend()
        {

        }

        private Node FindElement(T element)
        {
            Node current = this.root;

            while (current != null)
            {
                if (current.Value.CompareTo(element) > 0)
                {
                    current = current.Left;
                }
                else if (current.Value.CompareTo(element) < 0)
                {
                    current = current.Right;
                }
                else
                {
                    break;
                }
            }

            return current;
        }

        private void PreOrderCopy(Node node)
        {
            if (node == null)
            {
                return;
            }

            this.Insert(node.Value);
            this.PreOrderCopy(node.Left);
            this.PreOrderCopy(node.Right);
        }

        private Node Insert(T element, Node node)
        {
            if (node == null)
            {
                node = new Node(element);

            }
            else if (element.CompareTo(node.Value) < 0)
            {
                node.Left = this.Insert(element, node.Left);
                node.Count++;
            }
            else if (element.CompareTo(node.Value) > 0)
            {
                node.Right = this.Insert(element, node.Right);
                node.Count++;

            }

            return node;
        }

        private void Range(Node node, Queue<T> queue, T startRange, T endRange)
        {
            if (node == null)
            {
                return;
            }

            int nodeInLowerRange = startRange.CompareTo(node.Value);
            int nodeInHigherRange = endRange.CompareTo(node.Value);

            if (nodeInLowerRange < 0)
            {
                this.Range(node.Left, queue, startRange, endRange);
            }
            if (nodeInLowerRange <= 0 && nodeInHigherRange >= 0)
            {
                queue.Enqueue(node.Value);
            }
            if (nodeInHigherRange > 0)
            {
                this.Range(node.Right, queue, startRange, endRange);
            }
        }

        private void EachInOrder(Node node, Action<T> action)
        {
            if (node == null)
            {
                return;
            }

            this.EachInOrder(node.Left, action);
            action(node.Value);
            this.EachInOrder(node.Right, action);
        }


        public void Insert(T element)
        {
            this.root = this.Insert(element, this.root);

        }

        public bool Contains(T element)
        {
            Node current = this.FindElement(element);

            return current != null;
        }

        public void EachInOrder(Action<T> action)
        {
            this.EachInOrder(this.root, action);
        }

        public BinarySearchTreeExtend<T> Search(T element)
        {
            Node current = this.FindElement(element);

            return new BinarySearchTreeExtend<T>(current);
        }

        public void DeleteMin()
        {
            if (this.root == null)
            {
                return;
            }

            Node current = this.root;
            Node parent = null;
            while (current.Left != null)
            {
                parent = current;
                current = current.Left;
            }

            if (parent == null)
            {
                this.root = this.root.Right;
            }
            else
            {
                parent.Left = current.Right;
            }


        }

        public IEnumerable<T> Range(T startRange, T endRange)
        {
            Queue<T> queue = new Queue<T>();

            this.Range(this.root, queue, startRange, endRange);

            return queue;
        }

        public void Delete(T element)
        {
            if (this.Count() == 1 && this.root.Value.CompareTo(element) == 0)
            {
                this.root = null;
                return;
            }
            if (!this.Contains(element))
            {
                throw new InvalidOperationException();
            }

            Delete(this.root, element);

        }
        private void Delete(Node node, T element)
        {
            Node parent = node;
            while (true)
            {

                if (node.Value.CompareTo(element) < 0)
                {
                    parent = node;

                    node = node.Right;

                    continue;

                }
                else if (node.Value.CompareTo(element) > 0)
                {
                    parent = node;

                    node = node.Left;
                    continue;
                }
                else if (node.Value.CompareTo(element) == 0)
                {
                    if (parent.Value.CompareTo(node.Value) < 0)
                    {
                        parent.Right = node.Right;
                        if (node.Left != null)
                        {
                            parent.Right = node.Left;
                            parent.Right.Right = node.Right;
                        }
                        else
                        {
                            parent.Right = node.Right;
                        }
                        return;
                    }
                    if (parent.Value.CompareTo(node.Value) == 0)
                    {
                        if (node.Right != null)
                        {
                            if (node.Right.Left != null)
                            {
                                var newRoot = node.Right.Left;
                                while (newRoot != null)
                                {
                                    newRoot = newRoot.Left;
                                }
                                this.root = newRoot;
                                newRoot.Right = node.Right;
                                return;
                            }
                            this.root = node.Right;
                            return;
                        }
                    }
                    if (parent.Value.CompareTo(node.Value) > 0)
                    {
                        parent.Left = node.Left;
                        if (node.Right != null)
                        {
                            parent.Left = node.Right;
                            parent.Left.Left = node.Left;
                        }
                        else
                        {
                            parent.Left = node.Left;
                        }
                        return;
                    }
                }

            }

            throw new InvalidOperationException();

        }
        public void DeleteMax()
        {
            if (this.root == null)
            {
                throw new InvalidOperationException();

            }

            Node current = this.root;
            Node parent = null;
            while (current.Right != null)
            {
                parent = current;
                current = current.Right;
            }

            if (parent == null)
            {
                this.root = this.root.Left;
            }
            else
            {
                parent.Right = current.Left;
            }

        }

        public int Count()
        {
            return this.Count(this.root);

        }

        private int Count(Node node, int sum = 1)
        {
            if (node != null)
            {
                sum += this.Count(node.Left, sum) + this.Count(node.Right, sum);
                return sum;
            }
            else
            {
                return 0;
            }
        }

        public int Rank(T element)
        {
            if (this.root == null)
            {
                return 0;
            }
            var result = new List<T>();
            Rank(result, element, this.root);

            return result.Count;
        }

        private void Rank(List<T> result, T element, Node node)
        {
            if (node == null)
            {
                return;
            }
            if (node.Value.CompareTo(element) < 0)
            {
                result.Add(node.Value);
            }
            Rank(result, element, node.Left);
            Rank(result, element, node.Right);


        }

        public T Select(int rank)
        {
            if (this.root == null || this.root.Count < rank || rank < 0)
            {
                throw new InvalidOperationException();
            }
            var result = new List<T>();
            GetData(result, this.root, rank);


            //Console.WriteLine(string.Join(",", result));
            return result.First();
        }

        private void GetData(List<T> result, Node node, int rank)
        {

            if (node == null)
            {
                return;
            }

            int currentRank = this.Rank(node.Value);

            if (currentRank == rank)
            {
                result.Add(node.Value);
            }

            GetData(result, node.Left, rank);
            GetData(result, node.Right, rank);

        }

        public T Ceiling(T element)
        {
            var node = Ceiling(this.root, element);

            if (node == null)
            {
                throw new InvalidOperationException();
            }

            return node.Value;
        }

        private static Node Ceiling(Node node, T element)
        {
            while (true)
            {
                if (node == null)
                {
                    return null;
                }

                if (node.Value.CompareTo(element) <= 0)
                {
                    node = node.Right;
                    continue;
                }

                if (node.Left == null || node.Left.Value.CompareTo(element) <= 0)
                {
                    return node;
                }


                node = node.Left;
            }
        }

        public T Floor(T element)
        {
            var node = Floor(this.root, element);

            if (node == null)
            {
                throw new InvalidOperationException();
            }

            return node.Value;
        }

        private Node Floor(Node node, T element)
        {
            while (true)
            {
                if (node == null)
                {
                    return null;
                }

                if (node.Value.CompareTo(element) >= 0)
                {
                    node = node.Left;
                    continue;
                }

                if (node.Right == null || node.Right.Value.CompareTo(element) >= 0)
                {
                    return node;
                }


                node = node.Right;
            }
        }

    }
        
}