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
        /// Describes basic math operations on specified generic data type.
        /// This should be mainly specified if the generic type is not a basic value type like int, long, short, etc.
        /// </summary>
        IBasicMathOperator<T> BasicMathOperator { get; set; }

        /// <summary>
        /// Returns new vector which is a sum of current vector and vector specified in argument. Number of elements stays the same but each value is a value of "this[index] + vector[index]".
        /// </summary>
        /// <param name="vector"> Vector which will be added to current vector and create a sum of both. </param>
        /// <param name="mathOperator"> If the specified generic T-type is not a basic value type (int, short, long, etc.), You must specify the adding method. </param>
        /// <returns></returns>
        IVector<T> Add(IEnumerable<T> vector);
        /// <summary>
        /// Returns angle between current vector and vector specified in argument.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        double Angle(IVector<T> vector);
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
        T DotProduct(IEnumerable<T> vector);
        /// <summary>
        /// Initializes current vector with value from specified enumerable.
        /// Each call of this method will remove all current data inside current vector and reinitialize it from specified.
        /// </summary>
        /// <param name="data"> Data from which vector should be created </param>
        /// <returns></returns>
        void Initialize(IEnumerable<T> data);
        /// <summary>
        /// Returns magnitude value of current vector.
        /// </summary>
        /// <returns></returns>
        T Magnitude();
        /// <summary>
        /// Returns vector which is a product of multiplying current vector with specified in argument.
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="mathOperator"> If the specified generic T-type is not a basic value type (int, short, long, etc.), You must specify the multiplying method. </param>
        /// <returns></returns>
        T Multiply(IEnumerable<T> vector);
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
    }
}