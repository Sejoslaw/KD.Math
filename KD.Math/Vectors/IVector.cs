using System;
using System.Collections.Generic;

namespace KD.Math.Vectors
{
    /// <summary>
    /// General vector definition.
    /// </summary>
    /// <typeparam name="T"> Vector's elements type. </typeparam>
    public interface IVector<T> :
        IEnumerable<T>, IComparable<IVector<T>>, IEquatable<IVector<T>>
    {
        /// <summary>
        /// Returns value at specified index in current vector.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T this[int index] { get; set; }

        /// <summary>
        /// Returns the number of elements in current vector.
        /// </summary>
        int Count { get; }
        /// <summary>
        /// Returns the length of current vector.
        /// </summary>
        T Length { get; }

        /// <summary>
        /// Returns current vector but with all the values being absoluted.
        /// </summary>
        /// <returns></returns>
        IVector<T> Absolute();
        /// <summary>
        /// Returns new vector which is a sum of current vector and vector specified in argument. Number of elements stays the same but each value is a value of "this[index] + vector[index]".
        /// </summary>
        /// <param name="vector"> Vector which will be added to current vector and create a sum of both. </param>
        /// <returns></returns>
        IVector<T> Add(IEnumerable<T> vector);
        /// <summary>
        /// Returns angle between current vector and vector specified in argument.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        double Angle(IEnumerable<T> vector);
        /// <summary>
        /// Returns cross product of current vector and vector specified in argument.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        IVector<T> CrossProduct(IEnumerable<T> vector);
        /// <summary>
        /// Returns dot product of current vector and vector specified in argument.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        IVector<T> DotProduct(IEnumerable<T> vector);
        /// <summary>
        /// Initializes current vector with value from specified enumerable.
        /// Each call of this method will remove all current data inside current vector and reinitialize it from specified.
        /// </summary>
        /// <param name="data"> Data from which vector should be created </param>
        /// <returns></returns>
        void Initialize(IEnumerable<T> data);
        /// <summary>
        /// Returns vector which is a product of multiplying current vector with specified in argument.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        IVector<T> Multiply(IEnumerable<T> vector);
        /// <summary>
        /// Returns normalized current vector.
        /// </summary>
        /// <returns></returns>
        IVector<T> Normalize();
        /// <summary>
        /// Returns vector which is a product of subtracting specified vector from current.
        /// </summary>
        /// <param name="vector"> Vector which will be subtracted from current. </param>
        /// <returns></returns>
        IVector<T> Subtract(IEnumerable<T> vector);
        /// <summary>
        /// Converts current vector to unit vector.
        /// 
        /// NOTE: Unit vector is a vector which length is equal '1' (one).
        /// </summary>
        /// <returns></returns>
        IVector<T> ToUnit();
    }
}