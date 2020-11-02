using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollectionEg
{
    class StackandQueueEg
    {
        static void Main()
        {
            Stack s = new Stack();
            s.Push("java");
            s.Push(10);
            s.Push("dbms");
            s.Push(30.89);

            foreach (object item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Popped: {0}", s.Pop());
            Console.WriteLine("peek: {0}", s. Peek());

            foreach (object item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(".........Queue.........");

            Queue q = new Queue();
            q.Enqueue("jai");
            q.Enqueue("arjun");

            foreach (object item in q)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Top  element in queue: {0}", q.Peek());
            Console.WriteLine("Remove the Element: {0}", q.Dequeue());

            foreach (object item in q)

            {
                Console.WriteLine(item);
            }

            Console.Read();

            




















        }

    }
}
