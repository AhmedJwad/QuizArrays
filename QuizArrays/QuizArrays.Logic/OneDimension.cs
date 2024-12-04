using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizArrays.Logic
{
    public class OneDimension
    {
        private int[] _array;
        private int _top;

        public OneDimension(int n)
        {
            N = n;
            _array = new int[N];
        }

         public int N { get; }
         private bool IsEmpty => N == 0;
        private bool IsFull => N == _top;

        public override string ToString()
        {
           var output=string.Empty;
            for (var i = 0; i <_top; i++)
            {
                output += $"{_array[i]}\n";
            }
            return output;
        }

        public void Add(int value)
        {
            if(IsFull)
            {
                throw new Exception("The array is full.");
            }
            _array[_top] = value;
            _top++;
        }

    }
}
