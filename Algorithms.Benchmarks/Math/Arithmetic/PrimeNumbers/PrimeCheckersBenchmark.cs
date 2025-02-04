using Algorithms.Math.Arithmetic;
using BenchmarkDotNet.Attributes;

namespace Algorithms.Benchmarks.Math.Arithmetic.PrimeNumbers;

[MemoryDiagnoser]

public class PrimeCheckersBenchmark
{
    [Params(71L, 1893L, 73737L, 874634L, 19283845L, 968172638L, 1234567890L, 888938716263747283L, 9211111111111111111L)]
    public long Number;

    [Benchmark]
    public bool IsPrime() => Number.IsPrime();
}
