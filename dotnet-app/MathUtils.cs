using System;
<<<<<<< HEAD
=======

>>>>>>> 06064c3327cff46cc3fbf834eaf0c4146eab7838
public static class MathUtils
{
    public static int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("n must be non-negative");

        return (n == 0 || n == 1) ? 1 : n * Factorial(n - 1);
    }
}
