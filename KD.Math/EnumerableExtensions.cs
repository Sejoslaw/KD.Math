using KD.Math.Matrices;
using System.Collections.Generic;
using System.Linq;

namespace KD.Math
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Returns element at index 0.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T GetX<T>(this IEnumerable<T> source)
        {
            return source.ElementAt(0);
        }

        /// <summary>
        /// Returns element at index 1.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T GetY<T>(this IEnumerable<T> source)
        {
            return source.ElementAt(1);
        }

        /// <summary>
        /// Returns element at index 2.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T GetZ<T>(this IEnumerable<T> source)
        {
            return source.ElementAt(2);
        }

        /// <summary>
        /// Multiplies current Vector by specified Matrix and returns new Vector.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static IEnumerable<T> Multiply<T>(this IEnumerable<T> source, IMatrix<T> matrix)
        {
        }
    }
}