
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


            var stack = new ArrayStack<int>();

            var queue = new CircularQueue<string>();
           

            Console.WriteLine(string.Join(" ", stack.ToArray()));








            // Console.WriteLine(string.Join(",", listR));
        }

    }
}
