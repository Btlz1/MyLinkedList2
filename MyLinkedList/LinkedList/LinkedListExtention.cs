using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace MyLinkedListExtensions
{
        public static class MyLinkedListExtensions
        {
            public static void Print<T>(this MyLinkedList<T> list)
            {
                if (list == null)
                {
                    throw new ArgumentNullException(nameof(list));
                }

                foreach (var t in list)
                {
                    Console.Write(t + " ");
                }
            }
        } 
}