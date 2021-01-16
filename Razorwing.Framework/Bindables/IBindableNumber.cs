using System;
using Razorwing.Framework.Configuration;

namespace Razorwing.Framework.Bindables
{
    public interface IBindableNumber<T> : IBindable<T>
        where T : struct, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// An event which is raised when <see cref="Precision"/> has changed.
        /// </summary>
        event Action<T> PrecisionChanged;

        /// <summary>
        /// An event which is raised when <see cref="MinValue"/> has changed.
        /// </summary>
        event Action<T> MinValueChanged;

        /// <summary>
        /// An event which is raised when <see cref="MaxValue"/> has changed.
        /// </summary>
        event Action<T> MaxValueChanged;

        /// <summary>
        /// The precision up to which the value of this bindable should be rounded.
        /// </summary>
        T Precision { get; }

        /// <summary>
        /// The minimum value of this bindable. <see cref="IBindable{T}.Value">Value</see> will never go below this value.
        /// </summary>
        T MinValue { get; }

        /// <summary>
        /// The maximum value of this bindable. <see cref="IBindable{T}.Value">Value</see> will never go above this value.
        /// </summary>
        T MaxValue { get; }

        /// <summary>
        /// Whether <typeparamref name="T"/> is an integer.
        /// </summary>
        bool IsInteger { get; }

        /// <summary>
        /// Retrieve a new bindable instance weakly bound to the configuration backing.
        /// If you are further binding to events of a bindable retrieved using this method, ensure to hold
        /// a local reference.
        /// </summary>
        /// <returns>A weakly bound copy of the specified bindable.</returns>
        new IBindableNumber<T> GetBoundCopy();
    }
}
