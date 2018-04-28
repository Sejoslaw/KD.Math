using System.Collections.Generic;
using System.Linq;

namespace KD.Math.Vectors
{
    /// <summary>
    /// Extensions methods for <see cref="IVector{T}"/>.
    /// </summary>
    public static class VectorExtensions
    {
        public static T GetX<T>(this IEnumerable<T> source)
        {
            return source.ElementAt(0);
        }

        public static T GetY<T>(this IEnumerable<T> source)
        {
            return source.ElementAt(1);
        }

        public static T GetZ<T>(this IEnumerable<T> source)
        {
            return source.ElementAt(2);
        }
    }
}