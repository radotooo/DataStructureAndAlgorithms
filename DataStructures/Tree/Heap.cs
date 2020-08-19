using System;

namespace DataStructures
{
    public static class Heap<T> where T : IComparable<T>
    {
        public static void Sort(T[] arr)
        {

            //constructing a heap where every parrent is bigger than his childs
            // first element will be the biggest in array
            for (int i = arr.Length / 2; i >= 0; i--)
            {
                HeapifyDwon(i, arr, arr.Length);
            }
            Console.WriteLine(string.Join(",", arr));
            //make first element last 
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Swap(0, i, arr);
                HeapifyDwon(0, arr, i);
            }

        }
        private static void HeapifyDwon(int index, T[] arr, int length)
        {
            //Left(i) = 2 * I + 1;
            //Right(i) = 2 * i + 2
            while (index < length / 2)
            {
                int child = 2 * index + 1;
                //checking if right child exist and is bigger 
                if (child + 1 < length && IsGreater(child + 1, child, arr))
                {
                    child++;

                }
                //checking if current element is bigger than his child
                if (IsGreater(index, child, arr))
                {
                    break;
                }

                Swap(index, child, arr);
                index = child;
            }

        }
        private static void Swap(int index, int parent, T[] arr)
        {
            T temp = arr[index];
            arr[index] = arr[parent];
            arr[parent] = temp;
        }
        private static bool IsGreater(int index, int parent, T[] arr)
        {
            return arr[index].CompareTo(arr[parent]) > 0;
        }
    }
}