using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LinkedList;

public class Node<T>
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }
    public T Data { get; internal set; }

    public Node(T value, Node<T> next)
    {
        this.Value = value;
        this.Next = next;
    }
}