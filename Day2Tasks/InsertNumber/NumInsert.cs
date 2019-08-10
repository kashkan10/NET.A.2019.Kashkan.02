using System;

namespace InsertNumber
{
    /// <summary>
    /// Class contains method with bit operations
    /// </summary>
    public class NumInsert
    {
        /// <summary>
        /// Insert bits of one number into another from i to j
        /// </summary>
        /// <param name="numberSource">Source number</param>
        /// <param name="numberIn">Number to insert</param>
        /// <param name="i">Start bit index</param>
        /// <param name="j">Final bit index</param>
        /// <returns>Result of bit-operation</returns>
        public static int InsertNumber(int numberSource, int numberIn, int i, int j)
        {
            if (i > j)
            {
                throw new ArgumentException();
            }

            int tail = numberSource;
            int result = 0;
            int lenA = GetLength(numberSource);
            int lenB = GetLength(numberIn);

            if (j - i + 1 <= lenB)
            {
                numberIn = numberIn >> (lenB - 1 - j + i) << i;
            }
            else if (j - i + 1 > lenB)
            {
                numberIn = numberIn << i;
            }
            if (i < lenA)
            {
                tail = tail >> i << i;
                tail = numberSource - tail;
                if (j < lenA + 1)
                {
                    numberSource = numberSource >> j + 1 << j + 1;
                    result = numberSource | numberIn | tail;
                }
                else
                {
                    result = numberIn | tail;
                }
            }
            else
            {
                result = numberSource | numberIn;
            }

            return result;
        }

        /// <summary>
        /// Counts bit length of number
        /// </summary>
        /// <param name="number">Source number</param>
        /// <returns>Length of number in bits</returns>
        private static int GetLength(int number)
        {
            int length = 0;
            while (number > 0)
            {
                number = number / 2;
                length++;
            }

            return length;
        }
    }
}
