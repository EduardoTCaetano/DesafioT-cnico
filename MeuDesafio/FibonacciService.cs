using System;

public class FibonacciService
{
    public static bool PertenceFibonacci(int num)
    {
        int a = 0, b = 1, temp;
        while (a <= num)
        {
            if (a == num) return true;
            temp = a + b;
            a = b;
            b = temp;
        }
        return false;
    }
}
    