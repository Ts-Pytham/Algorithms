using Algorithms.Benchmarks.Math.Arithmetic.PrimeNumbers;
using BenchmarkDotNet.Running;

namespace Algorithms.Benchmarks;

internal class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<PrimeGeneratorsBenchmark>();
    }
}
