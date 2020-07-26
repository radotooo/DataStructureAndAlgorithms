using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace DataStructures
{
    class StartUp
    {
        static void Main(string[] args)
        {



            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddFirst(1);
            linkedList.AddFirst(1);
            Console.WriteLine(string.Join(",", linkedList));





            // Console.WriteLine(string.Join(",", listR));
        }

    }
}
