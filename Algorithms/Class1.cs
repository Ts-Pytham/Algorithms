using Algorithms.Math.Arithmetic;
using System.Collections.Generic;

namespace Algorithms;

public static class Class1
{
    public static void Main()
    {
        int a = 10;
        int b = 20;
        int gcd = a.GCD(b);
        int lcm = ArithmeticAlgorithm.LCM(a, b);
        ArithmeticAlgorithm.GCD(a, b);
    }


}
