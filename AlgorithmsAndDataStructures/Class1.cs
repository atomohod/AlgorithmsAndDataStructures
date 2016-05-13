using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
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
