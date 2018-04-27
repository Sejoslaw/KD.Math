using System;
using System.Collections.Generic;
using System.Linq;

namespace KD.Math.Vectors
{
    /// <summary>
    /// Basic implementation of <see cref="IVector{T}"/>, based on <see cref="double"/> values.
    /// </summary>
    public class Vector3d : AbstractVector<double>
    {
        public override double Length => this.Absolute();

        public virtual double X => this[0];

        public virtual double Y => this[1];

        public virtual double Z => this[2];

        public override double Absolute()
        {
            if (this.Internals.Count < 3)
            {
                throw new InvalidOperationException($"Current vector contains less than required 3 parameters.");
            }

            return System.Math.Sqrt(
                    System.Math.Pow(this.X, 2) +
                    System.Math.Pow(this.Y, 2) +
                    System.Math.Pow(this.Z, 2)
                );
        }

        public override IVector<double> Add(IEnumerable<double> vector)
        {
            this.CheckVectorElements(vector);

            List<double> sumValues = new List<double>();
            for (int i = 0; i < this.Count; ++i)
            {
                sumValues.Add(this[i] + vector.ElementAt(i));
            }

            Vector3d newVector = new Vector3d();
            newVector.Initialize(sumValues);

            return newVector;
        }

        public override double Angle(IVector<double> vector)
        {
            double multiplied = this.Multiply(vector);
            double length = (this.Length * vector.Length);

            return System.Math.Acos(multiplied / length);
        }

        public override int CompareTo(IVector<double> other)
        {
            if (this.Length > other.Length)
            {
                return 1;
            }
            else if (this.Length == other.Length)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public override IVector<double> CrossProduct(IEnumerable<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public override IVector<double> DotProduct(IEnumerable<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public override bool Equals(IVector<double> other)
        {
            this.CheckVectorElements(other);

            for (int i = 0; i < this.Length; ++i)
            {
                if (this[i] != other.ElementAt(i))
                {
                    return false;
                }
            }

            return true;
        }

        public override IEnumerator<double> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public override double Multiply(IEnumerable<double> vector)
        {
            this.CheckVectorElements(vector);

            double sum = 0;
            for (int i = 0; i < this.Count; ++i)
            {
                sum += this[i] * vector.ElementAt(i);
            }

            return sum;
        }

        public override IVector<double> Normalize()
        {
            throw new System.NotImplementedException();
        }

        public override IVector<double> Subtract(IEnumerable<double> vector)
        {
            throw new System.NotImplementedException();
        }

        public override IVector<double> ToUnit()
        {
            throw new System.NotImplementedException();
        }
    }
}