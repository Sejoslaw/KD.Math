using System;
using System.Collections.Generic;

namespace KD.Math.Vectors
{
    /// <summary>
    /// General vector definition.
    /// </summary>
    /// <typeparam name="TDataType">  </typeparam>
    public interface IVector<TDataType> : 
        IEnumerable<TDataType>, IComparable<IVector<TDataType>>, IEquatable<IVector<TDataType>>
        where TDataType : IComparable<TDataType>
    {
        /// <summary>
        /// Returns value at specified index in current vector.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        IVector<TDataType> this[int index] { get; }

        /// <summary>
        /// Returns the number of elements in current vector.
        /// </summary>
        TDataType Count { get; }
        /// <summary>
        /// Returns the length of current vector.
        /// </summary>
        TDataType Length { get; }

        /// <summary>
        /// Returns current vector but with all the values being absoluted.
        /// </summary>
        /// <returns></returns>
        IVector<TDataType> Absolute();
        /// <summary>
        /// Returns new vector which is a sum of current vector and vector specified in argument.
        /// </summary>
        /// <param name="vector"> Vector which will be added to current vector and create a sum of both. </param>
        /// <returns></returns>
        IVector<TDataType> Add(IVector<TDataType> vector);
        /// <summary>
        /// Returns angle between current vector and vector specified in argument.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        double Angle(IVector<TDataType> vector);
        /// <summary>
        /// Returns cross product of current vector and vector specified in argument.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        IVector<TDataType> CrossProduct(IVector<TDataType> vector);
        /// <summary>
        /// Returns dot product of current vector and vector specified in argument.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        IVector<TDataType> DotProduct(IVector<TDataType> vector);
        /// <summary>
        /// Initializes current vector with value from specified enumerable.
        /// Each call of this method will remove all current data inside current vector and reinitialize it from specified.
        /// </summary>
        /// <param name="data"> Data from which vector should be created </param>
        /// <returns></returns>
        IVector<TDataType> Initialize(IEnumerable<TDataType> data);
        /// <summary>
        /// Returns vector which is a product of multiplying current vector with specified in argument.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        IVector<TDataType> Multiply(IVector<TDataType> vector);
        /// <summary>
        /// Returns normalized current vector.
        /// </summary>
        /// <returns></returns>
        IVector<TDataType> Normalize();
        /// <summary>
        /// Returns vector which is a product of subtracting specified vector from current.
        /// </summary>
        /// <param name="vector"> Vector which will be subtracted from current. </param>
        /// <returns></returns>
        IVector<TDataType> Subtract(IVector<TDataType> vector);
        /// <summary>
        /// Converts current vector to unit vector.
        /// 
        /// NOTE: Unit vector is a vector which length is equal '1' (one).
        /// </summary>
        /// <returns></returns>
        IVector<TDataType> ToUnit();
    }
}