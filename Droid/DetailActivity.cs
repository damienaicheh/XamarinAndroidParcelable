using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using ParcelableProject.Droid.Parcelables;
using ParcelableProject.Models;

namespace ParcelableProject.Droid
{
    [Activity(Label = "DetailActivity", Theme = "@style/AppTheme")]
    public class DetailActivity : AppCompatActivity
    {
        private TextView _idTextView;
        private TextView _firstNameTextView;
        private TextView _lastNameTextView;
        private TextView _ageTextView;
        private TextView _addressTextView;
        private TextView _cityTextView;
        private TextView _countryTextView;

        public const string UserParcelableExtra = "UserParcelableExtra";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Detail);

            _idTextView = FindViewById<TextView>(Resource.Id.IdTextView);
            _firstNameTextView = FindViewById<TextView>(Resource.Id.FirstNameTextView);
            _lastNameTextView = FindViewById<TextView>(Resource.Id.LastNameTextView);
            _ageTextView = FindViewById<TextView>(Resource.Id.AgeTextView);
            _addressTextView = FindViewById<TextView>(Resource.Id.AddressTextView);
            _cityTextView = FindViewById<TextView>(Resource.Id.CityTextView);
            _countryTextView = FindViewById<TextView>(Resource.Id.CountryTextView);

            UserParcelable parcelable = (UserParcelable)Intent.GetParcelableExtra(UserParcelableExtra);
            UpdateView(parcelable.User);
        }

        public void UpdateView(User user)
        {
            _idTextView.Text = user.Id.ToString();
            _firstNameTextView.Text = user.FirstName;
            _lastNameTextView.Text = user.LastName;
            _ageTextView.Text = user.Age.ToString();
            _addressTextView.Text = user.Address;
            _cityTextView.Text = user.City;
            _countryTextView.Text = user.Country;
        }
    }
}
