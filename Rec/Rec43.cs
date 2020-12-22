using System;
using System.Collections.Generic;
using System.Text;

namespace Rec
{
    class Rec43
    {
        public string UpdateCharList(char[] arr)
        {
            var linkedList = new LinkedList<char>();
            for (int i = 0; i < arr.Length; i++)
            {
                linkedList.Add(arr[i]);
            }
            linkedList.MakeShortestSequenceAsLongAsLongest();
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

            public void MakeShortestSequenceAsLongAsLongest()
            {
                int maxSequence = 0;
                int minSequence = int.MaxValue;
                int counter = 1;
                Node<T> minSequenceNode = null;

                var node = Root;

                while (node != null)
                {
                    if (node.Next != null && node.Value.Equals(node.Next.Value))
                        counter++;
                    else
                    {
                        if (counter > maxSequence)
                        {
                            maxSequence = counter;
                        }
                        if (counter < minSequence)
                        {
                            minSequence = counter;
                            minSequenceNode = node;
                        }
                        counter = 1;
                    }
                    node = node.Next;
                }

                var currentNode = minSequenceNode;
                var tempNode = minSequenceNode.Next;

                for (int i = 0; i < maxSequence - minSequence; i++)
                {
                    currentNode.Next = new Node<T>(currentNode.Value);
                    currentNode = currentNode.Next;
                }
                currentNode.Next = tempNode;
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
