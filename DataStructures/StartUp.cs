
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace DataStructures
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var btsTree = new BinarySearchTree<int>();
            btsTree.Insert(10);
            btsTree.Insert(15);
            btsTree.Insert(7);
            btsTree.Insert(4);
            btsTree.Insert(30);
            btsTree.Insert(16);
            btsTree.Insert(17);
            btsTree.Insert(14);


            btsTree.Insert(18);

            btsTree.Insert(22);
            btsTree.Insert(28);
            btsTree.Insert(12);
            btsTree.Insert(35);
            btsTree.Insert(45);



            // btsTree.EachInOrder(x=> Console.WriteLine(x));
           // btsTree.PrintIndentedPreOrder();

            //var tree = new Tree<int>(5, new Tree<int>(6),
            //                            new Tree<int>(7),
            //                            new Tree<int>(9, new Tree<int>(90),
            //                                             new Tree<int>(100)),
            //                           new Tree<int>(10)
            //                           );

            //tree.Print();
            //Console.WriteLine(string.Join(" ", tree.OrderBFS()));
            //Console.WriteLine(string.Join(" ", tree.OrderDFS()));












            // Console.WriteLine(string.Join(",", listR));
        }

    }
}
