using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using ParcelableProject.Models;

namespace ParcelableProject.Droid
{
    [Activity(Label = "Parcelable Example", MainLauncher = true, Icon = "@mipmap/icon", Theme ="@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        private Button _seeMoreBtn;

        private User _user;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _seeMoreBtn = FindViewById<Button>(Resource.Id.SeeMoreBtn);

            _user = GetUser();

            FindViewById<TextView>(Resource.Id.FirstNameTextView).Text = _user.FirstName;
            FindViewById<TextView>(Resource.Id.LastNameTextView).Text = _user.LastName;
        }

		protected override void OnResume()
		{
            base.OnResume();
            _seeMoreBtn.Click += SeeMoreBtn_Click;
		}

        private void SeeMoreBtn_Click(object sender, System.EventArgs e)
        {
            //Here the magic
        }

		/// <summary>
		/// Here we create a simple user. In a real app you will get it from your view model.
		/// </summary>
		/// <returns>The user.</returns>
		private User GetUser()
        {
            return new User
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Ricky",
                Age = 34,
                Address = "44 Hilton Lane",
                City = "Sydney",
                Country = "Australia"
            };
        }

		protected override void OnPause()
		{
            base.OnPause();
            _seeMoreBtn.Click -= SeeMoreBtn_Click;
		}
	}
}

