using Algorithms.Math.Arithmetic;

long a = 200;
var primes = ArithmeticAlgorithm.GetPrimesBySieveOfEratosthenes(a);
var primes2 = ArithmeticAlgorithm.GetPrimesBySieveOfAtkin(a);

Console.WriteLine("Erat  |   Atkin");

foreach (var (prime, prime2) in primes.Zip(primes2))
{
    Console.WriteLine($"{prime} | {prime2}");
}

