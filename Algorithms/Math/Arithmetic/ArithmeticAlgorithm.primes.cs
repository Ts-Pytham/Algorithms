using System;

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
}