using System.Collections.Generic;

namespace KD.Math.Matrices
{
    /// <summary>
    /// General Matrix definition.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMatrix<T>
    {
        /// <summary>
        /// Returns the height of the matrix.
        /// </summary>
        int Height { get; }
        /// <summary>
        /// Returns the width of the matrix.
        /// </summary>
        int Width { get; }

        /// <summary>
        /// Returns element at specified position.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        T this[int width, int height] { get; }

        /// <summary>
        /// Adds specified matrix to current one and returns as new.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        IMatrix<T> Add(IMatrix<T> matrix);
        /// <summary>
        /// Returns the specified column.
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        IEnumerable<T> GetColumn(int column);
        /// <summary>
        /// Returns the specified row.
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        IEnumerable<T> GetRow(int row);
        /// <summary>
        /// Initializes matrix with data.
        /// </summary>
        /// <param name="data"></param>
        void Initialize(T[][] data);
        /// <summary>
        /// Inverses current matrix.
        /// </summary>
        /// <returns></returns>
        IMatrix<T> Inverse();
        /// <summary>
        /// Multiplies specified matrix with current one and returns as new.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        IMatrix<T> Multiply(IMatrix<T> matrix);
        /// <summary>
        /// Multiplies current matrix by specified value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        IMatrix<T> Multiply(T value);
        /// <summary>
        /// Multiplies current matrix by specified vector.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        IMatrix<T> Multiply(IEnumerable<T> vector);
        /// <summary>
        /// Rotates current matrix horizontally.
        /// </summary>
        /// <returns></returns>
        IMatrix<T> RotateHorizontally();
        /// <summary>
        /// Rotates the current matrix by 90 degree to left.
        /// </summary>
        /// <returns></returns>
        IMatrix<T> RotateLeft();
        /// <summary>
        /// Rotates the current matrix by 90 degree to right.
        /// </summary>
        /// <returns></returns>
        IMatrix<T> RotateRight();
        /// <summary>
        /// Rotates current matrix vertically.
        /// </summary>
        /// <returns></returns>
        IMatrix<T> RotateVertically();
        /// <summary>
        /// Transposes current matrix.
        /// </summary>
        /// <returns></returns>
        IMatrix<T> Transpose();
    }
}