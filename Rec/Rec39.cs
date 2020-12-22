using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec39
    {
        public void Foo(int[] arr)
        {
            var roundLists = new RoundList<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                roundLists.Add(arr[i]);
            }

        }



        public class RoundList<T>
        {
            public Node<T> Root { get; set; }

            public void Add(T value)
            {
                if (Root == null)
                {
                    Root = new Node<T>(value, 1);
                    Root.Next = Root;
                }
                else
                    Add(Root.Next, value);
            }

            private void Add(Node<T> node, T value)
            {
                if (node.Next == Root)
                {
                    node.Next = new Node<T>(value, node.Index++);
                    node.Next.Next = Root;
                }
                else
                    Add(node.Next, value);
            }

            public void Remove(Node<T> node, int num)
            {
                var originalNum = num;
                while (true)
                {

                }            
            }

            public class Node<T>
            {
                public int Index { get; set; }
                public T Value { get; set; }
                public Node<T> Next { get; set; }
                public Node(T value, int index)
                {
                    Value = value;
                    Index = index;
                }
            }
        }
    }
}
