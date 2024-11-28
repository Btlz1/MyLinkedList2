using ConsoleApp1.LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        private int count;

        public MyLinkedList()
        {
            this.head = null;
            this.count = 0;
        }
        public bool Empty
        {
            get { return this.count == 0; }
        }
        public int Count
        {
            get { return this.count; }
        }
        public void Add(int index, T value)
        {
            if (index < 0 || index > count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            Node<T> newNode = new Node<T>(value, null);

            if (index == 0)
            {
                newNode.Next = this.head;
                this.head = newNode;
            }
            else
            {
                Node<T> current = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next; 
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            count++; 
        }
        public void AddLast(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Node<T> newNode = new Node<T>(value, null);

            if (head == null) 
            {
                head = newNode; 
            }
            else
            {
                Node<T> current = head; 
                while (current.Next != null) 
                {
                    current = current.Next;
                }
                current.Next = newNode; 
            }
            count++; 
        }
        public void AddFirst(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Node<T> newNode = new Node<T>(value, null);
            newNode.Next = head;
            head = newNode;

            count++;
        }
        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            Node<T> current = this.head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next; 
            }
            return current.Value; 
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                Node<T> current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next; 
                }
                    current.Next = current.Next.Next;
            }
            count--; 
        }

        public void PrintList()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
    




