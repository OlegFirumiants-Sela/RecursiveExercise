using System.Collections.Generic;
using System.Text;

namespace Rec
{
    public class Rec41
    {
        public string UpdateCharList(char[] arr)
        {
            var linkedList = new LinkedList<char>();
            for (int i = 0; i < arr.Length; i++)
            {
                if ('a' <= arr[i] && arr[i] <= 'z')
                {
                    linkedList.Add(arr[i]);
                }
            }
            linkedList.RemoveDoubles();
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

            public void RemoveDoubles()
            {
                Node<T> prev = null;
                var node = Root;
                var next = node.Next;
                var dict = new Dictionary<T, bool>();
                while (node != null)
                {
                    if (dict.ContainsKey(node.Value))
                    {
                        prev.Next = node.Next;
                        node = node.Next;
                        next = node.Next;
                    }
                    else
                    {
                        dict[node.Value] = true;
                        prev = node;
                        node = next;
                        if (node != null && node.Next != null)
                            next = node.Next;
                    }
                }

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
