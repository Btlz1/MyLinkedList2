
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;
using MyLinkedListExtensions;


class Program
{
    static void Main()
    {
       MyLinkedList<int> list = new MyLinkedList<int>();
        
       list.Add(0, 1);
       list.Add(1, 2);
       list.Add(2, 3);
       list.Add(3, 4);
       list.Add(4, 5);
       list.Add(5, 6);
       list.Add(6, 7);
       list.Add(7, 8);
       list.Add(8, 9);
       list.Add(9, 10);
       list.PrintList();
       
       list.Add(5, 42);
       list.PrintList();
       
       list.Remove(9);
       list.Add(9, -1);
       list.PrintList();
       
       list.Remove(2);
       Console.WriteLine($"Длинна списка: {list.Count}");
       list.Print();
       
       
        
        
        
        
        
        Console.ReadKey();


    }

    
}
