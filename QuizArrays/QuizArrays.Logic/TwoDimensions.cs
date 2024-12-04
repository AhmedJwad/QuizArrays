using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizArrays.Logic
{
    public class TwoDimensions
    {
        private int[,] _array;

        public TwoDimensions(int m , int n)
        {
            M= m;
            N= n;
            _array = new int[M, N];
        }

        public int N { get; }
        public int M { get; }


        public override string ToString()
        {
           var output=string.Empty;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += $"{_array[i, j]}";
                }
                output += "\n";
            }
            return output;
        }
        public OneDimension ToOneDimension()
        {
            var oneDimension = new OneDimension(M*N);
            for (int i = 0;i < M; i++)
            {
                for(int j = 0;j < N; j++)
                {
                    oneDimension.Add(_array[i,j]);  
                }
            }
            return oneDimension;
        }
        public void Fill()
        {
            var randon=new Random();
            for (int i = 0; i < M; i++)
            {
                for ( int j = 0;  j < N;  j++)
                {
                    _array[i, j] = randon.Next(1, 100);
                }
            }
        }
    }
    
    
}
