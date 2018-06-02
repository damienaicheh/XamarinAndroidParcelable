using System;
using Android.OS;

namespace ParcelableProject.Droid.Parcelables
{
    public class GenericParcelableCreator<T> : Java.Lang.Object, IParcelableCreator where T : Java.Lang.Object, new()
    {
        /// <summary>
        /// Function for the creation of a parcel.
        /// </summary>
        private readonly Func<Parcel, T> _createFunc;

        /// <summary>
        /// Initialize an instance of the GenericParcelableCreator.
        /// </summary>
        public GenericParcelableCreator(Func<Parcel, T> createFromParcelFunc)
        {
            _createFunc = createFromParcelFunc;
        }

        /// <summary>
        /// Create a parcelable from a parcel.
        /// </summary>
        public Java.Lang.Object CreateFromParcel(Parcel parcel)
        {
            return _createFunc(parcel);
        }

        /// <summary>
        /// Create an array from the parcelable class.
        /// </summary>
        public Java.Lang.Object[] NewArray(int size)
        {
            return new T[size];
        }
    }
}
