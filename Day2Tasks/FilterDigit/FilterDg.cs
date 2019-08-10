using System;
using System.Collections.Generic;

namespace FilterDigit
{
    /// <summary>
    /// Class contains method to filter the sequense
    /// </summary>
    public class FilterDg
    {
        /// <summary>
        /// Returns numbers, that contains the given digit
        /// </summary>
        /// <param name="list">Source list</param>
        /// <param name="digit"></param>
        /// <returns>Sorted list</returns>
        public static List<int> FilterDigit(List<int> list, int digit)
        {
            if (list == null)
            {
                throw new ArgumentNullException();
            }

            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException();
            }

            List<int> result = new List<int>();
            int[] array = list.ToArray();
            int num;
            for (int i = 0; i < array.Length; i++)
            {
                num = array[i];
                while (num > 0)
                {
                    if (num % 10 == digit)
                    {
                        result.Add(array[i]);
                        break;
                    }
                    else
                    {
                        num /= 10;
                    }
                }
            }

            return result;
        }
    }
}
