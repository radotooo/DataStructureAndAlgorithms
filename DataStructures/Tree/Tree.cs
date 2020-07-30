using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
namespace DataStructures
{
    public class Tree<T>
    {
        public T Value { get; set; }
        public List<Tree<T>> Childrens { get; private set; } = new List<Tree<T>>();
        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Childrens.AddRange(children);
        }

        public void Print(int indent = 0)
        {
            Console.WriteLine(new string(' ', 2 * indent) + this.Value);
            foreach (var children in this.Childrens)
            {
                children.Print(indent + 1);
            }

        }

        public void Each(Action<T> action)
        {
            action(this.Value);
            foreach (var children in this.Childrens)
            {
                children.Each(action);
            }

        }

        public IEnumerable<T> OrderDFS()
        {
            var result = new List<T>();
            this.DFS(this, result);
            return result;
        }

        private void DFS(Tree<T> tree, List<T> result)
        {
            foreach (var children in tree.Childrens)
            {
                this.DFS(children, result);
            }
            result.Add(tree.Value);
        }

        public IEnumerable<T> OrderBFS()
        {
            var result = new List<T>();
            var queue = new Queue<Tree<T>>();
            queue.Enqueue(this);
            while (queue.Count > 0)
            {
                var cvurrent = queue.Dequeue();
                result.Add(cvurrent.Value);

                foreach (var children in cvurrent.Childrens)
                {
                    queue.Enqueue(children);
                }
            }
            return result;
        }
    }
}