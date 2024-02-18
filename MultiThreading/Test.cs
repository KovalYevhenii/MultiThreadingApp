using System.Diagnostics;

namespace MultiThreading;
internal class Test
{
    public static long SimpleSum(int[] data)
    {
        return data.Sum(x => (long)x);


    }
    public static void SimpleSumParallel(int[] data)
    {
        Thread thread = new Thread(() =>
        {
            var res = data.Sum(x => (long)x);
        });
        thread.Start();
    }
    public void SimpleSumPlinq(int[] ints)
    {

    }
    public static void MeasureExecutionTime(string method, Action action)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        action?.Invoke();
        stopwatch.Stop();
        Console.WriteLine($"{method}| {stopwatch.ElapsedMilliseconds}ms");
    }
}
