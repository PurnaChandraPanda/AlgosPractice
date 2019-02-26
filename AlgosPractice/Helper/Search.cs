using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosPractice.Helper
{
    class Search
    {
        /// <summary>
        /// Get the missing number in ordered sequence
        /// </summary>
        /// <param name="array">input array</param>
        /// <param name="l">lower index</param>
        /// <param name="r">higher index</param>
        /// <returns></returns>
        public static int GetMissingNumberInSequenceWithRecusion(int[] array, int l, int r)
        {
            if (l <= r)
            {
                int m = (l + r) / 2;

                if (array[m] - array[m - 1] != 1)
                {
                    return array[m] - 1;
                }

                if (array[m] == m + 2)
                {
                    return GetMissingNumberInSequenceWithRecusion(array, l, m - 1);
                }
                else if (array[m] == m + 1)
                {
                    return GetMissingNumberInSequenceWithRecusion(array, m + 1, r);
                }
            }

            // if not found
            return -1;
        }

        /// <summary>
        /// If input array is ordered sequence, this logic would help finish the job in O(logn). 
        /// Else, follow one by one comparison in the whole array, which would take O(n) time.
        /// </summary>
        /// <param name="array">input array</param>
        /// <param name="l">lower index</param>
        /// <param name="r">higher index</param>
        /// <returns></returns>
        public static int GetMissingNumberInSequence(int[] array, int l, int r)
        {
            int m = 0; 

            while (l <= r)
            {
                // calculate middle value
                m = (l + r) / 2;

                // if in seqence, difference to previous number must be 1
                if (array[m] - array[m - 1] != 1)
                {
                    return array[m] - 1;
                }

                // update indices if to navigate lower or upper side
                if (array[m] == m + 2)
                {
                    r = m - 1;
                }
                else if (array[m] == m + 1)
                {
                    l = m + 1;
                }
            }

            // if not found
            return -1;
        }
    }
}
