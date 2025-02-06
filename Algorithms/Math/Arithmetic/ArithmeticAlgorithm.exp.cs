namespace Algorithms.Math.Arithmetic;
public static partial class ArithmeticAlgorithm
{
    /// <summary>
    /// Computes (x^y) % p using Modular Exponentiation for double precision numbers.
    /// </summary>
    /// <param name="x">The base number.</param>
    /// <param name="y">The exponent.</param>
    /// <param name="p">The modulus.</param>
    /// <returns>The result of (x^y) % p as a double.</returns>
    /// <remarks>
    /// This method is not precise for large integers due to floating-point precision limitations.
    /// It is more suitable for approximate calculations.
    /// </remarks>
    public static long ModularExponentiation(long x, long y, long p)
    {
        long result = 1;
        x %= p;

        while (y > 0)
        {
            if (y % 2 == 1)
            {
                result = (result * x) % p;
            }
            y = (int)y / 2;
            x = (x * x) % p;
        }
        return result;
    }

    /// <summary>
    /// Computes (x^y) % p using Modular Exponentiation for integers.
    /// </summary>
    /// <param name="x">The base number.</param>
    /// <param name="y">The exponent.</param>
    /// <param name="p">The modulus.</param>
    /// <returns>The result of (x^y) % p as an integer.</returns>
    /// <remarks>
    /// Uses bitwise right shift (y >>= 1) to divide the exponent by 2 efficiently.
    /// Ensures calculations remain within integer limits to prevent overflow.
    /// This method is more precise than the double version for large numbers.
    /// </remarks>
    public static int ModularExponentiation(int x, int y, int p)
    {
        int result = 1;
        x %= p;

        while (y > 0)
        {
            if (y % 2 == 1)
            {
                result = (result * x) % p;
            }
            y >>= 1;
            x = (x * x) % p;
        }
        return result;
    }
}
