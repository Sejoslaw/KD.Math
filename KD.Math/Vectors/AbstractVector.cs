using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        public abstract T Absolute();
        public abstract IVector<T> Add(IEnumerable<T> vector);
        public abstract double Angle(IVector<T> vector);
        public abstract int CompareTo(IVector<T> other);
        public abstract IVector<T> CrossProduct(IEnumerable<T> vector);
        public abstract IVector<T> DotProduct(IEnumerable<T> vector);
        public abstract bool Equals(IVector<T> other);
        public abstract IEnumerator<T> GetEnumerator();
        public abstract T Multiply(IEnumerable<T> vector);
        public abstract IVector<T> Normalize();
        public abstract IVector<T> Subtract(IEnumerable<T> vector);
        public abstract IVector<T> ToUnit();

        protected void CheckVectorElements(IEnumerable<T> vector)
        {
            if (this.Count != vector.Count())
            {
                throw new InvalidOperationException($"Specified vector contains different amount of elements than current vector.");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Internals.GetEnumerator();
        }
    }
}