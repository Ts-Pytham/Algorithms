using System;

namespace Algorithms.Math.Arithmetic;

public static partial class ArithmeticAlgorithm
{
    public static bool FermatTestPrimality(long number, long iterations = 5)
    {
        if (number < 2)
        {
            return false;
        }
        else if (number < 4)
        {
            return true;
        }
        else if (number % 2 == 0)
        {
            return false;
        }
        var random = new Random();

        for (long i = 0; i < iterations; i++)
        {
            int range = (int)number - 4;
            int randomValue = random.Next();
            long a = 2 + (randomValue % range);

            if (GCD(a, number) != 1)
            {
                return false;
            }
            if (ModularExponentiation(a, number - 1, number) != 1)
            {
                return false;
            }
        }
        return true;
    }
}