using Algorithms.Math.Arithmetic;
using BenchmarkDotNet.Attributes;

namespace Algorithms.Benchmarks.Math.Arithmetic.PrimeNumbers;

[MemoryDiagnoser]
public class PrimeGeneratorsBenchmark
{
    [Params(71L, 1893L, 19283845L, 20283845L)]
    public long Number;


    [Benchmark]
    public List<long> GetPrimesClassic() =>  ArithmeticAlgorithm.GetPrimes(Number);

    [Benchmark]
    public List<long> GetPrimesSieveOfEratosthenes() => ArithmeticAlgorithm.GetPrimesBySieveOfEratosthenes(Number);
}
