using DataStructuresLib.LinkedList;
using DataStructuresLib.LinkedList.SingleLinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp {
    class Program {

        static void Main(string[] args) {
            var linkedlist = new SingleLinkedList<int>();
            linkedlist.AddFirst(1);
            linkedlist.AddFirst(2);
            linkedlist.AddFirst(3);
            // 3 2 1 o(1)

            linkedlist.AddLast(4);
            linkedlist.AddLast(5);
            //3 2 1 4 5 O(n)
            
            linkedlist.AddAfter(linkedlist.Head.Next,32);
            linkedlist.AddAfter(linkedlist.Head.Next.Next,33);
            //3 2 32 33 1 4 5 O(n)

            Console.ReadKey();
        }
    }
}
