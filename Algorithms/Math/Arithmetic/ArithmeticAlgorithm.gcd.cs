using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Math.Arithmetic;
/// <summary>
/// Arithmetic Algorithms. This class provides the implementation of the most common arithmetic algorithms.
/// </summary>
public static partial class ArithmeticAlgorithm
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
    /// Calculates the Greatest Common Divisor (GCD) of two long values.
    /// The GCD can be calculated using either the Euclidean algorithm or the binary algorithm, depending on the value of the 'euclidean' parameter.
    /// </summary>
    /// <param name="a">The first long value.</param>
    /// <param name="b">The second long value.</param>
    /// <param name="euclidean">A boolean flag to determine which algorithm to use:
    /// <c>true</c> for the Euclidean algorithm (default), 
    /// <c>false</c> for the binary algorithm.</param>
    /// <returns>
    /// Returns the greatest common divisor (GCD) of the two long values <paramref name="a"/> and <paramref name="b"/>.
    /// </returns>
    /// <remarks>
    /// The Euclidean algorithm repeatedly subtracts the smaller number from the larger one (or uses modulus) until the numbers become equal.
    /// The binary algorithm is based on binary operations and is generally faster for large numbers.
    /// </remarks>
    public static long GCD(this long a, long b, bool euclidean = true)
    {
        return euclidean ? GCDEuclidean(a, b) : GCDBinary(a, b);
    }

    public static ulong GCD(this ulong a, ulong b, bool euclidean = true)
        => euclidean ? GCDEuclidean(a, b) : GCDBinary(a, b);

    public static uint GCD(this uint a, uint b, bool euclidean = true)
        => euclidean ? GCDEuclidean(a, b) : GCDBinary(a, b);

    public static short GCD(this short a, short b, bool euclidean = true)
        => euclidean ? GCDEuclidean(a, b) : GCDBinary(a, b);

    public static ushort GCD(this ushort a, ushort b, bool euclidean = true)
        => euclidean ? GCDEuclidean(a, b) : GCDBinary(a, b);

    public static byte GCD(this byte a, byte b, bool euclidean = true)
        => euclidean ? GCDEuclidean(a, b) : GCDBinary(a, b);

    public static sbyte GCD(this sbyte a, sbyte b, bool euclidean = true)
        => euclidean ? GCDEuclidean(a, b) : GCDBinary(a, b);

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
    /// Calculates the Greatest Common Divisor (GCD) of a sequence of long integers.
    /// Iterates over the collection and applies the GCD function cumulatively.
    /// </summary>
    /// <param name="numbers">A collection of long integers to calculate the GCD.</param>
    /// <param name="euclidean"> A boolean flag to determine the algorithm used:
    /// <c>true</c> for the Euclidean algorithm (default),
    /// <c>false</c> for the binary algorithm.
    /// </param>
    /// <returns>The greatest common divisor (GCD) of all numbers in the collection.</returns>
    public static long GCD(this IEnumerable<long> numbers, bool euclidean = true)
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
    /// Calculates the Greatest Common Divisor (GCD) of a sequence of long integers.
    /// Iterates over the collection and applies the GCD function cumulatively.
    /// </summary>
    /// <param name="numbers">A list of long integers to calculate the GCD.</param>
    /// <param name="euclidean"> A boolean flag to determine the algorithm used:
    /// <c>true</c> for the Euclidean algorithm (default),
    /// <c>false</c> for the binary algorithm.
    /// </param>
    /// <returns>The greatest common divisor (GCD) of all numbers in the collection.</returns>
    public static long GCD(this List<long> numbers, bool euclidean = true)
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

    /// <summary>
    /// Calculates the Greatest Common Divisor (GCD) of an array of long integers.
    /// Iterates through the array to compute the GCD of all elements.
    /// </summary>
    /// <param name="numbers">An array of long integers to calculate the GCD.</param>
    /// <param name="euclidean"> A boolean flag to determine the algorithm used:
    /// <c>true</c> for the Euclidean algorithm (default),
    /// <c>false</c> for the binary algorithm.
    /// </param>
    /// <returns>The greatest common divisor (GCD) of all numbers in the array.</returns>
    public static long GCD(this long[] numbers, bool euclidean = true)
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

    #region GCD euclidean
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

    private static long GCDEuclidean(long a, long b)
    {
        while (b != 0)
        {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private static ulong GCDEuclidean(ulong a, ulong b)
        => (ulong)GCDEuclidean((long)a, (long)b);

    private static uint GCDEuclidean(uint a, uint b)
        => (uint)GCDEuclidean((int)a, (int)b);

    private static short GCDEuclidean(short a, short b)
    => (short)GCDEuclidean((int)a, (int)b);

    private static ushort GCDEuclidean(ushort a, ushort b)
        => (ushort)GCDEuclidean((int)a, (int)b);

    private static byte GCDEuclidean(byte a, byte b)
        => (byte)GCDEuclidean((int)a, (int)b);

    private static sbyte GCDEuclidean(sbyte a, sbyte b)
        => (sbyte)GCDEuclidean((int)a, (int)b);
    #endregion

    #region GCD binary
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
    
    private static uint GCDBinary(uint a, uint b)
        => (uint)GCDBinary((int)a, (int)b);

    private static short GCDBinary(short a, short b)
        => (short)GCDBinary((int)a, (int)b);

    private static ushort GCDBinary(ushort a, ushort b)
        => (ushort)GCDBinary((int)a, (int)b);

    private static byte GCDBinary(byte a, byte b)
        => (byte)GCDBinary((int)a, (int)b);

    private static sbyte GCDBinary(sbyte a, sbyte b)
        => (sbyte)GCDBinary((int)a, (int)b);

    private static long GCDBinary(long a, long b)
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

    private static ulong GCDBinary(ulong a, ulong b)
        => (ulong)GCDBinary((long)a, (long)b);
    #endregion
}
