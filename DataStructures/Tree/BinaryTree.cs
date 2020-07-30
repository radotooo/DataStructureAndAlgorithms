using System;
using System.Runtime.InteropServices;
namespace DataStructures
{
    public class BinaryTree<T>
    {
        public T Value { get; private set; }
        public BinaryTree<T> LeftNode { get; set; }
        public BinaryTree<T> RightNode { get; set; }

        public BinaryTree(T value, BinaryTree<T> leftChild = null, BinaryTree<T> rightChild = null)
        {
            this.Value = value;
            this.LeftNode = leftChild;
            this.RightNode = rightChild;

        }

        /// <param name="indent">Spacing from the beginning</param>
        public void PrintIndentedPreOrder(int indent = 0)
        {

            var root = this;
            PrintElements(indent, root);

        }

        private void PrintElements(int indent, BinaryTree<T> node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                Console.WriteLine($"{new string(' ', indent * 2)}{node.Value}");
                PrintElements(indent + 1, node.LeftNode);
                PrintElements(indent + 1, node.RightNode);
            }

        }

        public void EachInOrder(Action<T> action)
        {

            var tree = this;

            InOrderAction(action, tree);
        }

        private void InOrderAction(Action<T> action, BinaryTree<T> tree)
        {
            if (tree == null)
            {
                return;
            }
            else
            {
                InOrderAction(action, tree.LeftNode);
                action(tree.Value);
                InOrderAction(action, tree.RightNode);
            }
        }

        public void EachPostOrder(Action<T> action)
        {
            var tree = this;

            PosrtOrderAction(action, tree);
        }

        private void PosrtOrderAction(Action<T> action, BinaryTree<T> tree)
        {
            if (tree == null)
            {
                return;
            }
            else
            {
                PosrtOrderAction(action, tree.LeftNode);
                PosrtOrderAction(action, tree.RightNode);
                action(tree.Value);
            }
        }
    }
}