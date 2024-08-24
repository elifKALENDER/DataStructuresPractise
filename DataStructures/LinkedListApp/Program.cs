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
            
            Console.ReadKey();
        }
        private static void SingleLinkedListApp001() {

            var linkedlist = new SingleLinkedList<int>();
            linkedlist.AddFirst(1);
            linkedlist.AddFirst(2);
            linkedlist.AddFirst(3);
            // 3 2 1 o(1)

            linkedlist.AddLast(4);
            linkedlist.AddLast(5);
            //3 2 1 4 5 O(n)

            linkedlist.AddAfter(linkedlist.Head.Next, 32);
            linkedlist.AddAfter(linkedlist.Head.Next.Next, 33);
            //3 2 32 33 1 4 5 O(n)



            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }

            //var list=new LinkedList<int>();//Csharptan geliyor LinkedList özelliği// tersten yazıyor
            //list.AddFirst(1);
            //list.AddFirst(2);
            //list.AddFirst(3);

            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }
        private static void SingleLinkedListApp002() {
            var arr = new char[] { 'a', 'b', 'c' };
            var arrList = new ArrayList(arr);
            var list = new List<char>(arr);
            var clinkedlist = new LinkedList<char>(arr);
            var linkedlist = new SingleLinkedList<char>(arr);

            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
