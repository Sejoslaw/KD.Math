using System;
using System.Collections.Generic;

namespace KD.Math.Vectors
{
    /// <summary>
    /// <see cref="IVector{T}"/> for more information and details.
    /// </summary>
    public class Vector2d : DoubleVector<Vector2d>
    {
        public double X => this[0];

        public double Y => this[1];

        protected override int WantedNumberOfElements => 2;

        public override IVector<double> CrossProduct(IEnumerable<double> vector)
        {
            throw new NotImplementedException("Cross product is not formally defined for 2D vector.");
        }
    }
}