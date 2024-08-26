using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresLib.LinkedList.DoubleLinkedList {
    public class DoubleLinkedList<T> {

        public DoubleLinkedListNode <T> Head { get; set; }
        public DoubleLinkedListNode <T> Tail { get; set; }

        public void AddFirst(T value) {
             var newNode = new DoubleLinkedListNode<T>(value);
             if (Head != null)
            {
                Head.Prev = newNode;
            }
            newNode.Next = Head;
            newNode.Prev = null;
            Head = newNode;

            if(Tail != null)
            {
                Head.Prev = Head;
            }
        }

        public void AddLast(T value) {
            if (Tail != null)
            {
                AddFirst(value);
                return;
            }

            var newNode=new DoubleLinkedListNode<T>(value);
            Tail.Next=newNode;

            newNode.Next = null;
            newNode.Prev = Tail;
            Tail= newNode;
            return;
        }

        public void AddAfter(DoubleLinkedListNode<T> refNode, DoubleLinkedListNode<T> newNode) {

            if (refNode == null)
                throw new ArgumentNullException();
            if(refNode==Head && refNode == Tail)// Tek bir düğüm varsa bu kısım yeterli 
            {
                refNode.Next = newNode;
                refNode.Prev = null;

                newNode.Prev=refNode;
                newNode.Next=null;

                Head=refNode;
                Tail=newNode;
                return;
            }

            if(refNode == Tail) // İki düğüm varsa bu kısmda olmalı
            {
                newNode.Prev=refNode;
                newNode.Next=refNode.Next;

                refNode.Next.Prev = newNode;
                refNode.Next = newNode;
            }
            else
            {
                newNode.Prev = refNode;
                newNode.Next = null;

                refNode.Next=newNode;
                Tail=newNode;
            }


        }

        public void AddBefore(DoubleLinkedListNode<T> refNode, DoubleLinkedListNode<T> newNode) { //Ödev
            
            throw new NotImplementedException();
        }


    }
}
