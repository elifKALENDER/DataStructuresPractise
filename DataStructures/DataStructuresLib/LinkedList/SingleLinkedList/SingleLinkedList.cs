using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresLib.LinkedList.SingleLinkedList
{
    public class SingleLinkedList<T>: IEnumerable<T> //Liste başına ekleme yapılır
    {
        public SingleLinkedList() { }
        public SingleLinkedList(IEnumerable<T> collection) {
            
            foreach(var item in collection)
                this.AddFirst(item);
        }

        public SingleLinkedListNode<T> Head { get; set; }
        private bool isHeadNull => Head == null;//? true:false; bu kısmı istersek ekleyebiliriz ama ternaty ifade de buna gerek yok 
        public void AddFirst(T value)
        {

            var newMode = new SingleLinkedListNode<T>(value);
            newMode.Next = Head;
            Head = newMode;

        }

        public void AddLast(T value) {

            var newNode = new SingleLinkedListNode<T>(value);

            if (isHeadNull)
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
        public void AddAfter(SingleLinkedListNode<T> node,T value) {

            if(node == null)
            {
                throw new ArgumentNullException();
            }
            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }
            var newNode= new SingleLinkedListNode<T>(value);
            var current = Head;
            while(current !=null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    return;
                }
                current = current.Next;
            }
            throw new ArgumentNullException("The reference node  is not in this list.");
        }

        public void AddAfter(SingleLinkedListNode<T> refNode, //HomeWork
            SingleLinkedListNode<T> newNode) {

            throw new NotImplementedException();
        }

        public void AfterBefore(SingleLinkedListNode<T> node, T value)  //HomeWork
            => throw new NotImplementedException();

        public void AddBefore(SingleLinkedListNode<T> refNode,
            SingleLinkedListNode<T> newNode) => throw new NotImplementedException(); //HomeWork

        public IEnumerator<T> GetEnumerator() {
            return new SingleLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}
