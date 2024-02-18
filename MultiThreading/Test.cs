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
        Thread thread = new(() =>
        {
            var res = data.Sum(x => (long)x);

        });
        thread.Start();
    }
    public static long SimpleSumPlinq(int[] data)
    {
        return data.AsParallel().Sum(x => (long)x);
    }
    public static void MeasureExecutionTime(string method, Action action)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        action?.Invoke();
        stopwatch.Stop();
        Console.WriteLine($"{method}| {stopwatch.ElapsedMilliseconds}ms");
    }
}
