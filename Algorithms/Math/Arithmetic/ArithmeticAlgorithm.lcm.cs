namespace Algorithms.Math.Arithmetic;

/// <summary>
/// Arithmetic Algorithms. This class provides the implementation of the most common arithmetic algorithms.
/// </summary>
public static partial class ArithmeticAlgorithm
{
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
        return a * b / a.GCD(b, euclidean);
    }

    /// <summary>
    /// Calculates the Least Common Multiple (LCM) of two long values.
    /// </summary>
    /// <remarks>
    /// The Least Common Multiple is calculated using the relationship between LCM and GCD:
    /// <c>LCM(a, b) = (a * b) / GCD(a, b)</c>. The method uses the previously defined GCD function
    /// to determine the greatest common divisor, and based on that value, computes the LCM.
    /// </remarks>
    /// <param name="a">The first long value.</param>
    /// <param name="b">The second long value.</param>
    /// <param name="euclidean">A boolean flag to determine which algorithm to use for calculating GCD:
    /// <c>true</c> for the Euclidean algorithm (default),
    /// <c>false</c> for the binary algorithm.</param>
    /// <returns>
    /// Returns the least common multiple (LCM) of the two long values <paramref name="a"/> and <paramref name="b"/>.
    /// </returns>
    public static long LCM(this long a, long b, bool euclidean = true)
    {
        return a * b / a.GCD(b, euclidean);
    }

    public static ulong LCM(this ulong a, ulong b, bool euclidean = true)
    {
        return a * b / a.GCD(b, euclidean);
    }

    public static uint LCM(this uint a, uint b, bool euclidean = true)
    {
        return a * b / a.GCD(b, euclidean);
    }

    public static short LCM(this short a, short b, bool euclidean = true)
    {
        return (short)(a * b / a.GCD(b, euclidean));
    }

    public static ushort LCM(this ushort a, ushort b, bool euclidean = true)
    {
        return (ushort)(a * b / a.GCD(b, euclidean));
    }

    public static byte LCM(this byte a, byte b, bool euclidean = true)
    {
        return (byte)(a * b / a.GCD(b, euclidean));
    }

    public static sbyte LCM(this sbyte a, sbyte b, bool euclidean = true)
    {
        return (sbyte)(a * b / a.GCD(b, euclidean));
    }
}
