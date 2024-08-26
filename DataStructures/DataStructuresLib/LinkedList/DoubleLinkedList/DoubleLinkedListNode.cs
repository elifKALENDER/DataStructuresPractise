using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresLib.LinkedList.DoubleLinkedList {
    public class DoubleLinkedListNode<T> 
    {
        public DoubleLinkedListNode<T> Prev { get; set; }
        public DoubleLinkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public DoubleLinkedListNode(T value) {

            Value=value;
        }

        public override string ToString() =>  Value.ToString();
    }
}
