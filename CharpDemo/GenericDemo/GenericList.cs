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


        public static void Do()
        {
            var t = new List<string>();
            t.Add("wrwrew");
            t.Add("24432");
            t.Add("122313");
            t.Sort();
            //t[4] = "45";
            if (t.Contains("er")) { }
            Console.WriteLine(t.Count);
            Dictionary<string, string> englishdic = new Dictionary<string, string>();
            englishdic.Add("one", "Один");
            englishdic.Add("two", "Два");

            var a = englishdic.GetValueOrDefault("two", "...");

            Stack<string> stack = new Stack<string>();
            stack.Push("wwww");
            var s = stack.Pop();


            Queue<string> queue = new Queue<string>();

            DateTime dt = DateTime.Now;
            DateTime beinOfDay = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
            var bD = dt.BeginOfDay();


            var bw = dt.BeginOfWeek();






            var list = new GenericList<int>();
            for (int i = 0; i < 10; i++) list.AddHead(i);

            foreach (int i in list) Console.Write(i + " ");

        }

    }
}
