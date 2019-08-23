using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.Text;

namespace BenchMarkDotNetComparsion
{
    struct StructBenchMark
    {
        public int roll;
        public string name;

    }

    public class ClassBenchMark
    {
        public int roll { get; set; }
        public string name { get; set; }

    }

    public class StructVsClass
    {
        int N = 1000;
        [Benchmark]

        public void ClassBenchMark()
        {
            var data = new ClassBenchMark[N];
            for(int i = 0; i < N; i++)
            {
                data[i] = new ClassBenchMark() { roll = 43, name = "naina" };
            }
        }

        [Benchmark]

        public void StructBenchMark()
        {
            var data = new StructBenchMark[N];

            for(int i = 0; i < N; i++)
            {
                data[i] = new StructBenchMark() { roll = 43, name = "naina" };
            }
        }
    }
}
