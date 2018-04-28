using System.Collections.Generic;
using System.Linq;

namespace KD.Math.Vectors
{
    /// <summary>
    /// Represents an N-size vector which contains <see cref="double"/> elements.
    /// </summary>
    public abstract class DoubleVector<TVector> : AbstractVector<double>
        where TVector : AbstractVector<double>, new()
    {
        public override IVector<double> Add(IEnumerable<double> vector)
        {
            this.CheckVectorElements(vector);

            List<double> sumValues = new List<double>();
            for (int i = 0; i < this.Count; ++i)
            {
                sumValues.Add(this[i] + vector.ElementAt(i));
            }

            TVector newVector = new TVector();
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

        public override double DotProduct(IEnumerable<double> vector)
        {
            double val = 0;

            for (int i = 0; i < this.Count; ++i)
            {
                val += this[i] * vector.ElementAt(i);
            }

            return val;
        }

        public override bool Equals(IVector<double> other)
        {
            this.CheckVectorElements(other);

            for (int i = 0; i < this.Count; ++i)
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
            return this.Internals.GetEnumerator();
        }

        public override double Magnitude()
        {
            double val = 0;

            for (int i = 0; i < this.Count; ++i)
            {
                val += System.Math.Pow(this[i], 2);
            }

            return System.Math.Sqrt(val);
        }

        public override double Multiply(IEnumerable<double> vector)
        {
            this.CheckVectorElements(vector);

            double val = 0;
            for (int i = 0; i < this.Count; ++i)
            {
                val += this[i] * vector.ElementAt(i);
            }

            return val;
        }

        public override IVector<double> Normalize()
        {
            double length = this.Length;

            List<double> coords = new List<double>();

            foreach (double coord in this)
            {
                coords.Add(coord / length);
            }

            TVector newVec = new TVector();
            newVec.Initialize(coords);

            return newVec;
        }

        public override IVector<double> Subtract(IEnumerable<double> vector)
        {
            List<double> coords = new List<double>();

            for (int i = 0; i < this.Count; ++i)
            {
                coords.Add(this[i] - vector.ElementAt(i));
            }

            TVector newVec = new TVector();
            newVec.Initialize(coords);

            return newVec;
        }
    }
}