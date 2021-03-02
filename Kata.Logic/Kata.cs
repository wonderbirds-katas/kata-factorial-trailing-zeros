using System;

namespace Kata.Logic
{
public static class Kata
{
    public static int TrailingZeros(int n)
    {
        var log5 = (int)Math.Log(n, 5);

        var result = 0;
        for (var i = 1; i <= log5; i++)
        {
            result += n / (int)Math.Pow(5, i);
        }

        return result;
    }
}
}