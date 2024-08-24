using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresLib.LinkedList.SingleLinkedList
{
    public class SingleLinkedList<T>//Liste başına ekleme yapılır
    {

        public SingleLinkedListNode<T> Head { get; set; }

        public void AddFirst(T value)
        {

            var newMode = new SingleLinkedListNode<T>(value);
            newMode.Next = Head;
            Head = newMode;

        }

        public void AddLast(T value) {

            var newNode = new SingleLinkedListNode<T>(value);

            if (Head != null)
            {
                Head = newNode;
            }
            var current=Head;
            while(current.Next !=null)
            {
                current=current.Next;
            }
            current.Next = newNode;
        }
    }
}
