using System;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using ParcelableProject.Models;

namespace ParcelableProject.Droid.Parcelables
{
    public class UserParcelable : Java.Lang.Object, IParcelable
    {
        public User User { get; set; }

        public UserParcelable()
        {
        }

        // The creator creates an instance of the specified object
        private static readonly GenericParcelableCreator<UserParcelable> _creator
            = new GenericParcelableCreator<UserParcelable>((parcel) => new UserParcelable(parcel));

        [ExportField("CREATOR")]
        public static GenericParcelableCreator<UserParcelable> GetCreator()
        {
            return _creator;
        }

        private UserParcelable(Parcel parcel)
        {
            User = new User
            {
                Id = parcel.ReadLong(),
                FirstName = parcel.ReadString(),
                LastName = parcel.ReadString(),
                Age = parcel.ReadInt(),
                Address = parcel.ReadString(),
                City = parcel.ReadString(),
                Country = parcel.ReadString()
            };
        }

        public int DescribeContents()
        {
            return 0;
        }

        public void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
        {
            dest.WriteLong(User.Id);
            dest.WriteString(User.FirstName);
            dest.WriteString(User.LastName);
            dest.WriteInt(User.Age);
            dest.WriteString(User.Address);
            dest.WriteString(User.City);
            dest.WriteString(User.Country);
        }
    }
}
