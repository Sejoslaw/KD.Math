using System;

namespace KD.Math.Vectors
{
    /// <summary>
    /// Contains utilities connected with basic vector math.
    /// </summary>
    internal static class VectorUtils
    {
        internal static T Add<T>(T first, T second)
            where T : struct
        {
            T tmp = default(T);
            object ret = default(T);

            if (tmp is byte)
            {
                ret = Convert.ToByte(first) + Convert.ToByte(second);
            }
            else if (tmp is decimal)
            {
                ret = Convert.ToDecimal(first) + Convert.ToDecimal(second);
            }
            else if (tmp is double)
            {
                ret = Convert.ToDouble(first) + Convert.ToDouble(second);
            }
            else if (tmp is short)
            {
                ret = Convert.ToInt16(first) + Convert.ToInt16(second);
            }
            else if (tmp is int)
            {
                ret = Convert.ToInt32(first) + Convert.ToInt32(second);
            }
            else if (tmp is long)
            {
                ret = Convert.ToInt64(first) + Convert.ToInt64(second);
            }
            else if (tmp is sbyte)
            {
                ret = Convert.ToSByte(first) + Convert.ToSByte(second);
            }
            else if (tmp is float)
            {
                ret = Convert.ToSingle(first) + Convert.ToSingle(second);
            }
            else if (tmp is ushort)
            {
                ret = Convert.ToUInt16(first) + Convert.ToUInt16(second);
            }
            else if (tmp is uint)
            {
                ret = Convert.ToUInt32(first) + Convert.ToUInt32(second);
            }
            else if (tmp is ulong)
            {
                ret = Convert.ToUInt64(first) + Convert.ToUInt64(second);
            }
            else
            {
                throw new ArgumentException("Specified parameters are not a basic value structures.");
            }

            return (T)ret;
        }

        internal static T Subtract<T>(T first, T second)
        {
            T tmp = default(T);
            object ret = default(T);

            if (tmp is byte)
            {
                ret = Convert.ToByte(first) - Convert.ToByte(second);
            }
            else if (tmp is decimal)
            {
                ret = Convert.ToDecimal(first) - Convert.ToDecimal(second);
            }
            else if (tmp is double)
            {
                ret = Convert.ToDouble(first) - Convert.ToDouble(second);
            }
            else if (tmp is short)
            {
                ret = Convert.ToInt16(first) - Convert.ToInt16(second);
            }
            else if (tmp is int)
            {
                ret = Convert.ToInt32(first) - Convert.ToInt32(second);
            }
            else if (tmp is long)
            {
                ret = Convert.ToInt64(first) - Convert.ToInt64(second);
            }
            else if (tmp is sbyte)
            {
                ret = Convert.ToSByte(first) - Convert.ToSByte(second);
            }
            else if (tmp is float)
            {
                ret = Convert.ToSingle(first) - Convert.ToSingle(second);
            }
            else if (tmp is ushort)
            {
                ret = Convert.ToUInt16(first) - Convert.ToUInt16(second);
            }
            else if (tmp is uint)
            {
                ret = Convert.ToUInt32(first) - Convert.ToUInt32(second);
            }
            else if (tmp is ulong)
            {
                ret = Convert.ToUInt64(first) - Convert.ToUInt64(second);
            }
            else
            {
                throw new ArgumentException("Specified parameters are not a basic value structures.");
            }

            return (T)ret;
        }

        internal static T Multiply<T>(T first, T second)
        {
            T tmp = default(T);
            object ret = default(T);

            if (tmp is byte)
            {
                ret = Convert.ToByte(first) * Convert.ToByte(second);
            }
            else if (tmp is decimal)
            {
                ret = Convert.ToDecimal(first) * Convert.ToDecimal(second);
            }
            else if (tmp is double)
            {
                ret = Convert.ToDouble(first) * Convert.ToDouble(second);
            }
            else if (tmp is short)
            {
                ret = Convert.ToInt16(first) * Convert.ToInt16(second);
            }
            else if (tmp is int)
            {
                ret = Convert.ToInt32(first) * Convert.ToInt32(second);
            }
            else if (tmp is long)
            {
                ret = Convert.ToInt64(first) * Convert.ToInt64(second);
            }
            else if (tmp is sbyte)
            {
                ret = Convert.ToSByte(first) * Convert.ToSByte(second);
            }
            else if (tmp is float)
            {
                ret = Convert.ToSingle(first) * Convert.ToSingle(second);
            }
            else if (tmp is ushort)
            {
                ret = Convert.ToUInt16(first) * Convert.ToUInt16(second);
            }
            else if (tmp is uint)
            {
                ret = Convert.ToUInt32(first) * Convert.ToUInt32(second);
            }
            else if (tmp is ulong)
            {
                ret = Convert.ToUInt64(first) * Convert.ToUInt64(second);
            }
            else
            {
                throw new ArgumentException("Specified parameters are not a basic value structures.");
            }

            return (T)ret;
        }

        internal static T Divide<T>(T first, T second)
        {
            T tmp = default(T);
            object ret = default(T);

            if (tmp is byte)
            {
                ret = Convert.ToByte(first) / Convert.ToByte(second);
            }
            else if (tmp is decimal)
            {
                ret = Convert.ToDecimal(first) / Convert.ToDecimal(second);
            }
            else if (tmp is double)
            {
                ret = Convert.ToDouble(first) / Convert.ToDouble(second);
            }
            else if (tmp is short)
            {
                ret = Convert.ToInt16(first) / Convert.ToInt16(second);
            }
            else if (tmp is int)
            {
                ret = Convert.ToInt32(first) / Convert.ToInt32(second);
            }
            else if (tmp is long)
            {
                ret = Convert.ToInt64(first) / Convert.ToInt64(second);
            }
            else if (tmp is sbyte)
            {
                ret = Convert.ToSByte(first) / Convert.ToSByte(second);
            }
            else if (tmp is float)
            {
                ret = Convert.ToSingle(first) / Convert.ToSingle(second);
            }
            else if (tmp is ushort)
            {
                ret = Convert.ToUInt16(first) / Convert.ToUInt16(second);
            }
            else if (tmp is uint)
            {
                ret = Convert.ToUInt32(first) / Convert.ToUInt32(second);
            }
            else if (tmp is ulong)
            {
                ret = Convert.ToUInt64(first) / Convert.ToUInt64(second);
            }
            else
            {
                throw new ArgumentException("Specified parameters are not a basic value structures.");
            }

            return (T)ret;
        }
    }
}