using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec45
    {
        public string PrintBackwardsList(int[] arr)
        {
            var linkedList = new LinkedList<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                linkedList.Add(arr[i]);
            }
            linkedList.PrintBackwards();
            return linkedList.ToString();
        }


        public class LinkedList<T>
        {
            public Node<T> Root { get; set; }

            public void Add(T value)
            {
                if (Root == null)
                    Root = new Node<T>(value);
                else if (Root.Next == null)
                    Root.Next = new Node<T>(value);
                else
                    Add(Root.Next, value);
            }

            private void Add(Node<T> node, T value)
            {
                if (node.Next == null)
                    node.Next = new Node<T>(value);
                else
                    Add(node.Next, value);
            }

            public void PrintBackwards()
            {
                PrintBackwards(Root.Next);
                Console.Write($"{Root.Value} ");
            }

            private void PrintBackwards(Node<T> node)
            {
                if (node.Next != null)
                    PrintBackwards(node.Next);
                Console.Write($"{node.Value} ");
            }


            public class Node<T>
            {
                public T Value { get; set; }
                public Node<T> Next { get; set; }

                public Node(T value)
                {
                    Value = value;
                }
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                var node = Root;
                while (node != null)
                {
                    sb.Append($"{node.Value} ");
                    node = node.Next;
                }
                return sb.ToString();
            }
        }

    }
}
