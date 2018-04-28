using System.Collections.Generic;

namespace KD.Math.Vectors
{
    /// <summary>
    /// Basic implementation of <see cref="IVector{T}"/>, based on <see cref="double"/> values.
    /// </summary>
    public class Vector3d : DoubleVector<Vector3d>
    {
        public virtual double X => this[0];

        public virtual double Y => this[1];

        public virtual double Z => this[2];

        protected override int WantedNumberOfElements => 3;

        public override IVector<double> CrossProduct(IEnumerable<double> vector)
        {
            double x = (this.Y * vector.GetZ()) - (this.Z * vector.GetY());
            double y = (this.Z * vector.GetX()) - (this.X * vector.GetZ());
            double z = (this.X * vector.GetY()) - (this.Y * vector.GetX());

            double[] coords = new double[] { x, y, z };

            Vector3d newVec = new Vector3d();
            newVec.Initialize(coords);

            return newVec;
        }
    }
}