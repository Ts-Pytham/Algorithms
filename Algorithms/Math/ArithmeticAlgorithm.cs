using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Math;
/// <summary>
/// Arithmetic Algorithms. This class provides the implementation of the most common arithmetic algorithms.
/// </summary>
public static class ArithmeticAlgorithm
{

    /// <summary>
    /// Calculates the Greatest Common Divisor (GCD) of two integers.
    /// The GCD can be calculated using either the Euclidean algorithm or the binary algorithm, depending on the value of the 'euclidean' parameter.
    /// </summary>
    /// <param name="a">The first integer value.</param>
    /// <param name="b">The second integer value.</param>
    /// <param name="euclidean">A boolean flag to determine which algorithm to use:
    /// <c>true</c> for the Euclidean algorithm (default), 
    /// <c>false</c> for the binary algorithm.</param>
    /// <returns>
    /// Returns the greatest common divisor (GCD) of the two integers <paramref name="a"/> and <paramref name="b"/>.
    /// </returns>
    /// <remarks>
    /// The Euclidean algorithm repeatedly subtracts the smaller number from the larger one (or uses modulus) until the numbers become equal.
    /// The binary algorithm is based on binary operations and is generally faster for large numbers.
    /// </remarks>
    public static int GCD(this int a, int b, bool euclidean = true)
    {
        return euclidean ? GCDEuclidean(a, b) : GCDBinary(a, b);
    }

    /// <summary>
    /// Calculates the Greatest Common Divisor (GCD) of a sequence of integers.
    /// Iterates over the collection and applies the GCD function cumulatively.
    /// </summary>
    /// <param name="numbers">A collection of integers to calculate the GCD.</param>
    /// <param name="euclidean">
    /// A boolean flag to determine the algorithm used:
    /// <c>true</c> for the Euclidean algorithm (default), 
    /// <c>false</c> for the binary algorithm.
    /// </param>
    /// <returns>The greatest common divisor (GCD) of all numbers in the collection.</returns>
    public static int GCD(this IEnumerable<int> numbers, bool euclidean = true)
    {
        var gcd = numbers.First();

        foreach (var number in numbers.Skip(1))
        {
            gcd = gcd.GCD(number, euclidean);
            if (gcd == 1)
                break;
        }
        return gcd;
    }

    /// <summary>
    /// Calculates the Greatest Common Divisor (GCD) of a list of integers.
    /// Uses an iterative approach to compute the GCD of all elements.
    /// </summary>
    /// <param name="numbers">A list of integers to calculate the GCD.</param>
    /// <param name="euclidean">
    /// A boolean flag to determine the algorithm used:
    /// <c>true</c> for the Euclidean algorithm (default), 
    /// <c>false</c> for the binary algorithm.
    /// </param>
    /// <returns>The greatest common divisor (GCD) of all numbers in the list.</returns>
    public static int GCD(this List<int> numbers, bool euclidean = true)
    {
        var gcd = numbers[0];
        int len = numbers.Count;

        for (int i = 1; i < len; i++)
        {
            gcd = gcd.GCD(numbers[i], euclidean);
            if (gcd == 1)
                break;
        }
        return gcd;
    }

    /// <summary>
    /// Calculates the Greatest Common Divisor (GCD) of an array of integers.
    /// Iterates through the array to compute the GCD of all elements.
    /// </summary>
    /// <param name="numbers">An array of integers to calculate the GCD.</param>
    /// <param name="euclidean">
    /// A boolean flag to determine the algorithm used:
    /// <c>true</c> for the Euclidean algorithm (default), 
    /// <c>false</c> for the binary algorithm.
    /// </param>
    /// <returns>The greatest common divisor (GCD) of all numbers in the array.</returns>
    public static int GCD(this int[] numbers, bool euclidean = true)
    {
        var gcd = numbers[0];
        int len = numbers.Length;

        for (int i = 1; i < len; i++)
        {
            gcd = gcd.GCD(numbers[i], euclidean);
            if (gcd == 1)
                break;
        }
        return gcd;
    }

    #region GCD overloads
    private static int GCDEuclidean(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private static int GCDBinary(int a, int b)
    {
        if (a == 0)
            return b;
        if (b == 0)
            return a;
        if (a == b)
            return a;
        if (a == 1 || b == 1)
            return 1;
        
        int shift = 0;
        while (((a | b) & 1) == 0)
        {
            a >>= 1;
            b >>= 1;
            shift++;
        }

        while ((a & 1) == 0)
            a >>= 1;

        while (b != 0)
        {
            while ((b & 1) == 0)
                b >>= 1;
            if (a > b)
            {
                (a, b) = (b, a);
            }
            b -= a;
        }

        return a << shift;
    }
    #endregion


    /// <summary>
    /// Calculates the Least Common Multiple (LCM) of two integers.
    /// </summary>
    /// <remarks>
    /// The Least Common Multiple is calculated using the relationship between LCM and GCD: 
    /// <c>LCM(a, b) = (a * b) / GCD(a, b)</c>. The method uses the previously defined GCD function
    /// to determine the greatest common divisor, and based on that value, computes the LCM.
    /// </remarks>
    /// <param name="a">The first integer value.</param>
    /// <param name="b">The second integer value.</param>
    /// <param name="euclidean">A boolean flag to determine which algorithm to use for calculating GCD:
    /// <c>true</c> for the Euclidean algorithm (default), 
    /// <c>false</c> for the binary algorithm.</param>
    /// <returns>
    /// Returns the least common multiple (LCM) of the two integers <paramref name="a"/> and <paramref name="b"/>.
    /// </returns>
    public static int LCM(this int a, int b, bool euclidean = true)
    {
        return a * b / GCD(a, b, euclidean);
    }

}
