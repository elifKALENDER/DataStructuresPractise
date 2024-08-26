using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresLib.LinkedList.DoubleLinkedList {
    public class DoubleLinkedList<T> :IEnumerable{

        public DoubleLinkedListNode <T> Head { get; set; }
        public DoubleLinkedListNode <T> Tail { get; set; }
        private bool isHeadNull => Head == null;
        private bool isTailNull => Head == null;

        public DoubleLinkedList() 
        {

        }
        public DoubleLinkedList(IEnumerable<T> collection) {

            foreach (var item in collection)
            {
                AddLast(item);
            }
        }
        public void AddFirst(T value) {
             var newNode = new DoubleLinkedListNode<T>(value);
             if (Head != null)
            {
                Head.Prev = newNode;
            }
            newNode.Next = Head;
            newNode.Prev = null;
            Head = newNode;

            if(Tail == null)
            {
                Tail = Head;
            }

        }

        public void AddLast(T value) {
            if (Tail == null)
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

            if(refNode != Tail) // İki düğüm varsa bu kısmda olmalı
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
        private List<DoubleLinkedListNode<T>> GetAllNodes() {

            var list = new List<DoubleLinkedListNode<T>>();
            var current = Head;
            while(current != null)
            {
                list.Add(current);
                current = current.Next;

            }
            return list;
        }

        public IEnumerator GetEnumerator() {
            return GetAllNodes().GetEnumerator();
        }

        public T RemoveFirst () {

            if (isHeadNull)
                throw new Exception("");

            var temp = Head.Value;
            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }

            return temp;
        }

        public T RemoveLast() {
            if (isTailNull)
                throw new Exception("Empty List.");
            var temp = Tail.Value;

            if (Tail == Head)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Prev.Next = null;
                Tail=Tail.Prev;
            }
            return temp;
        }

        public void Delete(T value) {
            if (isHeadNull)
                throw new Exception("");

            //Tek eleman
            if (Head == Tail)
            {
                if (Head.Value.Equals(value))
                {
                    RemoveFirst();
                }
                return;
            }

            //en az iki eleman.
            var current = Head;

            while(current != null)
            {
                //current -> ilk eleman
                if(current.Prev == null)
                {
                    current.Next.Prev = null;
                    Head = current.Next;
                }
                //current -> son eleman
                else if (current.Next == null)
                {
                    current.Prev.Next = null;
                    Tail=current.Prev;
                }
                //current -> arada bir pozisyonda
                else
                {
                    current.Prev.Next=current.Next;
                    current.Next.Prev = current.Prev;
                }
                break;
            }
            current = current.Next;
        }
    }
}
