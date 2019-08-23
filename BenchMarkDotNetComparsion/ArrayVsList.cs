using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace BenchMarkDotNetComparsion
{
    public class ArrayVsList
    {

        int N = 1000;
        [Benchmark]

        public void Array()

        {
            
            var array = new int[N];

            for (int i = 0; i < N; i++)

            {

                array[i] = i;

            }

        }



        [Benchmark]

        public void Lists()

        {

            var list = new List<int>(N);

            for (int i = 0; i < N; i++)

            {

                list.Add(i);

            }

        }

    }

    
}
