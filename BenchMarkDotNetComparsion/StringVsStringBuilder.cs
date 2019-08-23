using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchMarkDotNetComparsion
{
    public class StringVsStringBuilder
    {
        int N = 1000;
        [Benchmark]

        public void String()
        {
            string str = "ABC";
            for(int i = 0; i < N; i++)
            {
                str += "ABC";
            }
        }
        [Benchmark]
        public void StringBuilder()
        {
            StringBuilder str = new StringBuilder("ABC");

            for(int i = 0; i < N; i++)
            {
                str.Append("ABC");
            }

        }
    }

    
}
