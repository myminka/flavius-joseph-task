using System;
using System.Collections.Generic;

namespace FlaviusJosephTask
{
    /// <summary>
    /// Represent class FlaviousJoseph.
    /// </summary>
    public static class FlaviousJoseph
    {
        /// <summary>
        /// Find warrior, which will alive this round.
        /// </summary>
        /// <param name="wariors">Array of warriors of Joseph.</param>
        /// <param name="k">Which warrior should die.</param>
        /// <returns>Alived warior.</returns>
        /// <exception cref="ArgumentException">, when k or count less than 1.</exception>
        public static IEnumerable<int> GetAlives(int count, int k)
        {
            if (count < 1)
            {
                throw new ArgumentException(nameof(count));
            }

            if (k < 1)
            {
                throw new ArgumentException(nameof(k));
            }

            Queue<int> queue = new Queue<int>(count);

            for (int i = 1; i <= count; i++)
            {
                queue.Enqueue(i);
            }

            return GetAlive(queue, k);

            static IEnumerable<int> GetAlive(Queue<int> queue, int k)
            {
                while (queue.Count != 0)
                {
                    for (int i = 1; i <= k; i++)
                    {
                        int temp = queue.Dequeue();
                        if (i == k)
                        {
                            yield return temp;
                            break;
                        }

                        queue.Enqueue(temp);
                    }
                }
            }
        }
    }
}
