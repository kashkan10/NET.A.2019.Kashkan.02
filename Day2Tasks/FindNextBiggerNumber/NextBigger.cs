using System;
using System.Diagnostics;

namespace FindNextBiggerNumber
{
    /// <summary>
    /// Class contains method to work with integer numbers
    /// </summary>
    public class NextBigger
    {
        /// <summary>
        /// Finding of next larger number with the same digits
        /// </summary>
        /// <param name="a">Source number</param>
        /// <returns>Next larger number</returns>
        public static int FindNextBiggerNumber(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException();
            }

            Stopwatch sw = Stopwatch.StartNew();
            if (a < 11)
            {
                sw.Stop();
                Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);
                return -1;
            }

            string number = a.ToString();
            int[] array = new int[number.Length];
            bool isExist = false;
            int swapIndex = 0;
            int swap = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = a % 10;
                a /= 10;
            }

            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i - 1] < array[i])
                {
                    swapIndex = i;
                    for (int j = array.Length - 1; j > i - 1; j--)
                    {
                        if (array[j] > array[i - 1] && array[j] < array[swapIndex])
                            swapIndex = j;
                    }

                    swap = array[swapIndex];
                    array[swapIndex] = array[i - 1];
                    array[i - 1] = swap;
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                sw.Stop();
                Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);
                return -1;
            }

            for (int i = swapIndex; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }
            }

            number = string.Empty;

            foreach (int k in array)
            {
                number += k.ToString();
            }

            sw.Stop();
            Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);
            return int.Parse(number);
        }
    }
}
