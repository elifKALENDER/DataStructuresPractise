using DataStructuresLib.LinkedList;
using DataStructuresLib.LinkedList.SingleLinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListApp {
    class Program {

        static void Main(string[] args) {
            var list = new SingleLinkedList<int>(new int[] { 15, 24, 33, 45, });
            list.Remove(24);
            list.Remove(45);
            list.Remove(33);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
        private static void SingleLinkedListApp01() {

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
        private static void SingleLinkedListApp02() {
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
        private static void SingleLinkedListApp03() {

            var rnd = new Random();
            var initial = Enumerable.Range(1, 10).OrderBy(x => rnd.Next()).ToList();
            var linkedlist = new SingleLinkedList<int>(initial);



            var q = from item in linkedlist // from LINQ içim bir sorgu yazılacağı anlamına gelir
                    where item % 2 == 1 //tek sayıları ver
                    select item;

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            linkedlist.Where(x => x > 5)
                .ToList()
                .ForEach(x => Console.Write(x + " "));
        }
        private static void SingleLinkedListApp04() {

            var rnd = new Random();
            var initial = Enumerable.Range(1, 5).OrderBy(x => rnd.Next()).ToList();
            var list = new SingleLinkedList<int>(initial);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.RemoveFirst();
            list.RemoveFirst();

            Console.WriteLine($"{list.RemoveLast()} has been removed");

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
