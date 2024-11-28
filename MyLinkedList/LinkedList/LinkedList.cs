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
                // Вставка в начало списка
                newNode.Next = this.head;
                this.head = newNode;
            }
            else
            {
                Node<T> current = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next; // Перейти к узлу перед индексом
                }
                // Вставка нового узла
                newNode.Next = current.Next;
                current.Next = newNode;
            }

            count++; // Увеличиваем размер списка
        }
        public void AddLast(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Node<T> newNode = new Node<T>(value, null); // Создаем новый узел с переданным значением

            if (head == null) // Если список пуст
            {
                head = newNode; // Новый узел становится головой списка
            }
            else
            {
                Node<T> current = head; // Начинаем с головы списка
                while (current.Next != null) // Идем до последнего узла
                {
                    current = current.Next;
                }
                current.Next = newNode; // Присоединяем новый узел к концу списка
            }

            count++; // Увеличиваем размер списка
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
                current = current.Next; // Перейти к нужному узлу
            }
            return current.Value; // Возвращаем значение узла
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
    




