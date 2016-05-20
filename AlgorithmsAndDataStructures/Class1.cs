using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    public class Node<T>
    {
        public T Value { get; }

        public Node(T value)
        {
            Value = value;
        }

        public Node<T> Parent { get; set; }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }
    }

    public class BinaryTreeBuilder
    {
        public Node<int> Build(int[] array)
        {
            var head = new Node<int>(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                Build(head, array[i]);
            }

            return head;
        }

        private void Build(Node<int> head, int next)
        {
            var current = head;
            var parent = head;

            while (current != null)
            {
                parent = current;

                current = next >= current.Value ? current.Right : current.Left;
            }

            if (next >= parent.Value)
                parent.Right = new Node<int>(next);
            else
                parent.Left = new Node<int>(next);            
        }
    }
    public class BubbleSort
    {
        public void Sort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        var t = input[i];
                        input[i] = input[j];
                        input[j] = t;
                    }
                }
            }
        }
    }
}
