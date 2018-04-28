namespace KD.Math
{
    /// <summary>
    /// Describes basic math operations on specified generic data type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBasicMathOperator<T>
    {
        /// <summary>
        /// Returns first + second;
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        T Add(T first, T second);
        /// <summary>
        /// Returns first - second;
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        T Subtract(T first, T second);
        /// <summary>
        /// Returns first * second;
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        T Multiply(T first, T second);
        /// <summary>
        /// Returns first / second;
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        T Divide(T first, T second);
    }
}