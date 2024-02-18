using System.Diagnostics;
using System;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Machine Name: " + Environment.MachineName);
            Console.WriteLine("OS Version: " + Environment.OSVersion);
            Console.WriteLine("Processor Count: " + Environment.ProcessorCount);
            Console.WriteLine(".NET Version: " + Environment.Version);
            Console.WriteLine();

            int[] dataSizes = { 100_000, 1_000_000, 10_000_000 };
            foreach (var dataSize in dataSizes)
            {
                int[] data = Enumerable.Range(0, dataSize).ToArray();
                Test.MeasureExecutionTime("Simple Sum",  () => Test.SimpleSum(data));
                Test.MeasureExecutionTime("Sum Parallel", () => Test.SimpleSumParallel(data));
            }
        }
    }
}
