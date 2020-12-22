namespace Rec
{
    public class Rec37
    {

        public int CountReversedOrderPairs(int[] arr)
        {
            Tree t = new Tree();
            for (int i = 0; i < arr.Length; i++)
            {
                t.Add(arr[i]);
            }
            return t.reversedOrderPairs;
        }
    }

    public class Tree
    {
        public int reversedOrderPairs = 0;
        Node<int> Root { get; set; }

        public void Add(int value)
        {
            if (Root != null)
                Add(Root, value);
            else
                Root = new Node<int>(value);
        }

        private void Add(Node<int> node, int value)
        {
            if (value >= node.Value)
            {
                if (node.Right != null)
                    Add(node.Right, value);
                else
                    node.Right = new Node<int>(value);
            }
            else
            {
                reversedOrderPairs++;
                if (node.Left != null)
                {
                    Add(node.Left, value);
                }
                else
                {
                    node.Left = new Node<int>(value);
                }
                if (node.Right != null)
                    Add(node.Right, value);
            }

        }
        
        private class Node<T>
        {
            public Node(T value)
            {
                Value = value;
            }
            public T Value { get; set; }
            public Node<T> Left { get; set; }
            public Node<T> Right { get; set; }
        }
    }

}
