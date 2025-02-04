using System;
using System.Collections.Generic;

namespace Algorithms.Math.Arithmetic;

public static partial class ArithmeticAlgorithm
{
    /// <summary>
    /// Determines whether a given number is prime.
    /// </summary>
    /// <remarks>
    /// The method uses the trial division algorithm to determine whether a given number is prime.
    /// The algorithm divides the number by all integers from 2 to the square root of the number.
    /// If the number is divisible by any of these integers, it is not prime.
    /// </remarks>
    /// <param name="number">The number to be checked for primality.</param>
    /// <returns>
    /// Returns <c>true</c> if the number is prime; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsPrime(this long number)
    { 
        if (number < 2 || number % 2 == 0)
        {
            return false;
        }
        else if (number < 4)
        {
            return true;
        }
        var limit = System.Math.Sqrt(number);

        for (int i = 3; i <= limit; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Finds all prime numbers up to a given limit using a basic iterative approach.
    /// </summary>
    /// <param name="limit">The maximum number to check for primality.</param>
    /// <returns>A list of prime numbers up to the specified limit.</returns>
    /// <remarks>
    /// This method iterates through all numbers from 2 to the limit and checks
    /// each one using the <c>IsPrime()</c> method. It has a time complexity of O(n√n).
    /// </remarks>
    public static List<long> GetPrimes(long limit)
    {
        var primes = new List<long>();
        for (long i = 2; i <= limit; i++)
        {
            if (i.IsPrime())
            {
                primes.Add(i);
            }
        }
        return primes;
    }

    /// <summary>
    /// Finds all prime numbers up to a given limit using the Sieve of Eratosthenes algorithm.
    /// </summary>
    /// <param name="limit">The maximum number to check for primality.</param>
    /// <returns>A list of prime numbers up to the specified limit.</returns>
    /// <remarks>
    /// The Sieve of Eratosthenes is an efficient algorithm with a time complexity of O(n log log n).
    /// It marks multiples of each prime number starting from 2, significantly reducing redundant checks.
    /// </remarks>
    public static List<long> GetPrimesBySieveOfEratosthenes(long limit)
    {
        var primes = new List<long>();
        var sieve = new bool[limit + 1];
        for (long i = 2; i <= limit; i++)
        {
            if (!sieve[i])
            {
                primes.Add(i);
                for (long j = i * i; j <= limit; j += i)
                {
                    sieve[j] = true;
                }
            }
        }
        return primes;
    }

    /// <summary>
    /// Finds all prime numbers up to a given limit using the Sieve of Atkin algorithm.
    /// </summary>
    /// <param name="limit">The maximum number to check for primality.</param>
    /// <returns>A list of prime numbers up to the specified limit.</returns>
    /// <remarks>
    /// The Sieve of Atkin is a modern algorithm that improves on the Sieve of Eratosthenes
    /// and has a time complexity of O(n / log log n). It uses quadratic equations to
    /// identify potential prime numbers more efficiently before filtering non-primes.
    /// </remarks>
    public static List<long> GetPrimesBySieveOfAtkin(long limit)
    {
        var primes = new List<long>();
        var sieve = new bool[limit + 1];
        var sqrtLimit = System.Math.Sqrt(limit);

        for (long x = 1; x <= sqrtLimit; x++)
        {
            for (long y = 1; y <= sqrtLimit; y++)
            {
                long n = (4 * x * x) + (y * y);
                if (n <= limit && (n % 12 == 1 || n % 12 == 5))
                {
                    sieve[n] ^= true;
                }
                n = (3 * x * x) + (y * y);
                if (n <= limit && n % 12 == 7)
                {
                    sieve[n] ^= true;
                }
                n = (3 * x * x) - (y * y);
                if (x > y && n <= limit && n % 12 == 11)
                {
                    sieve[n] ^= true;
                }
            }
        }
        for (long r = 5; r <= sqrtLimit; r++)
        {
            if (sieve[r])
            {
                for (long i = r * r; i <= limit; i += r * r)
                {
                    sieve[i] = false;
                }
            }
        }
        primes.Add(2);
        primes.Add(3);
        for (long a = 5; a <= limit; a++)
        {
            if (sieve[a])
            {
                primes.Add(a);
            }
        }
        return primes;
    }
}