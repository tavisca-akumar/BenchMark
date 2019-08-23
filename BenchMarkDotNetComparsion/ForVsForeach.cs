using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace BenchMarkDotNetComparsion
{
    public class ForVsForeach
    {
        static int N = 51000;
        int[] myInterger = new int[N];
        List<int> forBench = new List<int>();
        List<int> foreachBench = new List<int>();
        public ForVsForeach()
        {
            for(int i = 0; i < N; i++)
            {
                myInterger[i] = i;
            }
        }
        

        [Benchmark]      
       public void For()
        {
            
            for(int i = 0; i < N; i++)
            {
                forBench.Add(myInterger[i]);
            }
        }

        [Benchmark]

        public void Foreach()
        {
           
            foreach(int elem in myInterger)
            {
                foreachBench.Add(elem);
            }
        }
       
    }
}
