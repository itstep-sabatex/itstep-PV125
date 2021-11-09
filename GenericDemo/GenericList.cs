using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    interface IGG<T> { }


    internal class GenericList<T> where T : notnull
    {
        private class Node
        {
            private Node next;
            public Node Next { get => next; set => next = value; }
            private T data;
            public T Data { get => data; set => data = value; }
            public Node(T t)
            {
                next = null;
                data = t;
            }

        }

        private Node head;
        public GenericList()
        {
            head = null;
        }
        public void AddHead(T t)
        {
            Node node = new Node(t);
            node.Next = head;
            head = node;
        }


        public Tresult GetCount<Tresult>() where Tresult : new()
        {
            return new Tresult();

        }




        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }


    }
}
