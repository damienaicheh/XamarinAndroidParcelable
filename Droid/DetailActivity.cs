using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

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
        }
    }
}
