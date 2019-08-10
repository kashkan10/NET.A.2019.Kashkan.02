using System;

namespace FindNthRoot
{
    /// <summary>
    /// Class contains the Newton method
    /// </summary>
    public class FindRoot
    {
        /// <summary>
        /// Finding the root of the n-th degree with Newton method
        /// </summary>
        /// <param name="number">Source number</param>
        /// <param name="n">Degree</param>
        /// <param name="eps">Accuracy</param>
        /// <returns>Root of the n-th degree</returns>
        public static double FindNthRoot(double number, int n, double eps)
        {
            if (eps <= 0 || eps >= 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            double x_0 = 1;
            double x_k = x_0 - (Math.Pow(x_0, n) - number) / (n * Math.Pow(x_0, n - 1));
            while (Math.Abs(x_0 - x_k) > eps)
            {
                x_0 = x_k;
                x_k = x_0 - (Math.Pow(x_0, n) - number) / (n * Math.Pow(x_0, n - 1));
            }

            return Math.Round(x_k, 3);
        }
    }
}
