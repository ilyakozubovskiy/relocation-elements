using System;

namespace RelocationElementsTask
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Moves all of the elements with set value to the end, preserving the order of the other elements.
        /// </summary>
        /// <param name="source"> Source array. </param>
        /// <param name="value">Source value.</param>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static void MoveToTail(int[] source, int value)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("source cannot be empty.");
            }

            int count = 0;
            int[] result = new int[source.Length];
           
            for (int i = 0, j = 0; i < source.Length; i++)
            {
                if (source[i] != value)
                {
                    result[j] = source[i];
                    j++;
                }
                else 
                {
                    count++;
                }
            }

            for (int i = 1; i <= count; i++)
            {
                result[result.Length - i] = value;
            }

            result.CopyTo(source, 0);
        }
    }
}
