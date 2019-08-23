using BenchmarkDotNet.Attributes;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BenchMarkDotNetComparsion
{
    public class ThreadsvsTask
    {
        [Benchmark]
        public void ManageThreadPool()
        {
            Task.Run(async () =>
            {
                await SaveDataOpForThreadPool();
                await PrintDataOpForThreadPool();
            }).GetAwaiter().GetResult();
        }
        public async static Task SaveDataOpForThreadPool()
        {
            await Task.Delay(4000);
        }



        public async static Task PrintDataOpForThreadPool()
        {
            await Task.Delay(3000);
            Console.WriteLine("Hello");

        }



        [Benchmark]
        public void ManageManualThread()
        {
            var t1 = new Thread(SaveDataOpForManualThread);
            var t2 = new Thread(PrintDataOpForManualThread);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }
        public static void SaveDataOpForManualThread()
        {
            Thread.Sleep(4000);
        }



        public static void PrintDataOpForManualThread()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hello");
        }



    }
}
