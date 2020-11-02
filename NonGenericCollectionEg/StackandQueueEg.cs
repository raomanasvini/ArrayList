using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollectionEg
{
    class StackandQueueEg
    {
        static void Main()
        {
            Stack s = new System.Collections.Generic.Stack();
            s.push("java");
            s.push(10);
            s.push("dbms");
            s.push(30.89);

            foreach (object item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Popped: {0}", s.Pop());
            

            foreach (object item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(".........Queue.........");

            Queue q = new System.Collections.Generic.Queue();
            q.Enqueue("hari");
            q.Enqueue("jai");
            q.Enqueue("arjun");

            foreach (object item in q)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Top  element in queue: {0}", q.peek());
            Console.WriteLine("Remove the Element: {0}", q.Dequeue());

            foreach (object item in q)

            {
                Console.WriteLine(item);
            }

            Console.Read();

            




















        }

    }
}
