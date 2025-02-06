using Algorithms.Math.Arithmetic;

long a = 200;
var primes = ArithmeticAlgorithm.GetPrimesBySieveOfEratosthenes(a);
var primes2 = ArithmeticAlgorithm.GetPrimesBySieveOfAtkin(a);

Console.WriteLine("Erat  |   Atkin");

foreach (var (prime, prime2) in primes.Zip(primes2))
{
    Console.WriteLine($"{prime} | {prime2}");
}


// fermat test


long number = 2_305_843_009_213_693_951;

Console.WriteLine($"Is {number} prime? {ArithmeticAlgorithm.FermatTestPrimality(number, iterations: 9999999)}");
Console.WriteLine($"Normal method: {number.IsPrime()}");
