using System.Collections;
using System.Collections.Generic;

namespace KD.Math.Vectors
{
    /// <summary>
    /// Abstract implementation of <see cref="IVector{T}"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractVector<T> : IVector<T>
    {
        private List<T> _internals;
        protected List<T> Internals
        {
            get
            {
                if (this._internals == null)
                {
                    this._internals = new List<T>();
                }
                return this._internals;
            }
        }

        public virtual T this[int index]
        {
            get
            {
                return this.Internals[index];
            }
            set
            {
                this.Internals[index] = value;
            }
        }

        public virtual int Count
        {
            get
            {
                return this.Internals.Count;
            }
        }

        public abstract T Length { get; }

        public virtual void Initialize(IEnumerable<T> data)
        {
            this.Internals.Clear();

            foreach (T element in data)
            {
                this.Internals.Add(element);
            }
        }

        public abstract IVector<T> Absolute();
        public abstract IVector<T> Add(IEnumerable<T> vector);
        public abstract double Angle(IEnumerable<T> vector);
        public abstract int CompareTo(IVector<T> other);
        public abstract IVector<T> CrossProduct(IEnumerable<T> vector);
        public abstract IVector<T> DotProduct(IEnumerable<T> vector);
        public abstract bool Equals(IVector<T> other);
        public abstract IEnumerator<T> GetEnumerator();
        public abstract IVector<T> Multiply(IEnumerable<T> vector);
        public abstract IVector<T> Normalize();
        public abstract IVector<T> Subtract(IEnumerable<T> vector);
        public abstract IVector<T> ToUnit();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Internals.GetEnumerator();
        }
    }
}