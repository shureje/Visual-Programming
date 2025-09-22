using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4
{
    internal class GenericsDescSortedList<T> where T : IComparable<T>
    {
        private class Node
        {
            private T data;
            public T Data
            { 
                get { return data; }
                set { data = value; }
            }
            private Node? prev;
            public Node? Prev 
            { 
                get { return prev; }
                set { prev = value; }
            }
            private Node? next;
            public Node? Next
            {
                get { return next; }
                set { next = value; }
            }
            public Node(T data) 
            {
                this.data = data;
                prev = null;
                next = null;
            }
        }
        private Node? head;
        private int count;
        public int Count 
        { 
            get { return count; } 
        }
        public GenericsDescSortedList()
        {
            head = null;
            count = 0;
        }

        public void Add(T item)
        {
            Node newNode = new Node(item);

            if (head == null || item.CompareTo(head.Data) > 0)
            {
                newNode.Next = head;
                if (head != null) head.Prev = newNode;
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null && item.CompareTo(current.Next.Data) <= 0)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                newNode.Prev = current;
                if (current.Next != null)
                {
                    current.Next.Prev = newNode;
                }
                current.Next = newNode;

            }
            count++;
        }
        public T Max()
        {
            if (head == null) throw new InvalidOperationException("Список пуст");
            return head.Data;
        }

        public T Min()
        {
            if (head == null) throw new InvalidOperationException("Список пуст");
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count) throw new IndexOutOfRangeException();
            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node? current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            if (head == null) return "{}";

            var result = new StringBuilder("{");
            foreach (var item in this)
            {
                result.Append(item).Append(", ");
            }
            result.Length -= 2;
            result.Append("}");
            return result.ToString();
        }
    }
}
