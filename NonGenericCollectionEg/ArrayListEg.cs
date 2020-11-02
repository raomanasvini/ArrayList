using System;
using System.Collections;
using System.Collections.Generic;


namespace NonGenericCollectionEg
{
    class ArrayListEg
    {
        static void Main()
        {
            int[] arr = { 90, 60, 89, 10, 34 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
            Console.WriteLine("After Sorting");
            Array.Sort(arr);
            //for(int i= 0;i<arr.Length;i++)
            //foreach(element in iterable -item)
            //var :implicit typed variable
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(".........ArrayList.........");
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(80.98);
            al.Add("Kalai");
            al.Add(90);
            al.Add("Kalai");
            foreach (var item in al)
            {
                Console.WriteLine("ArrayList: {0}", item);
            }
            Console.WriteLine("Count: {0}", al.Count);
            Console.WriteLine("Capacity: {0}", al.Capacity);
            Console.WriteLine("Contains: {0}", al.Contains("Lalitha"));
            al.Remove(80.98);
            foreach (var item in al)
            {
                Console.WriteLine("ArrayList: {0}", item);

            }
            Console.WriteLine("Changes Made by Collaborator");
            Console.ReadLine();









        }
    }
}
