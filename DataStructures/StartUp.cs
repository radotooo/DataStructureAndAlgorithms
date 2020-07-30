
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


            var tree = new Tree<int>(5, new Tree<int>(6),
                                        new Tree<int>(7),
                                        new Tree<int>(9, new Tree<int>(90),
                                                         new Tree<int>(100)),
                                       new Tree<int>(10)
                                       );
            Console.WriteLine(string.Join(" ", tree.OrderBFS()));
            Console.WriteLine(string.Join(" ", tree.OrderDFS()));












            // Console.WriteLine(string.Join(",", listR));
        }

    }
}
