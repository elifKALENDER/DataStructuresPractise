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
            Console.ReadKey();
        }
    }
}
