using System;
using BenchmarkDotNet.Running;

namespace BenchMarkDotNetComparsion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    var ans = BenchmarkRunner.Run<ForVsForeach>();
                    break;
                case 2:
                     ans = BenchmarkRunner.Run<StringVsStringBuilder>();
                    break;
                case 3:
                    ans = BenchmarkRunner.Run<ArrayVsList>();
                    break;
                case 4:
                    ans = BenchmarkRunner.Run<StructVsClass>();
                    break;
                case 5:
                    ans = BenchmarkRunner.Run<ThreadsvsTask>();
                    break;
                default:
                    Console.WriteLine("Not valid input");
                    break;
            }
            
            Console.ReadKey();

        }
    }

    
}
