using Android.App;
using Android.OS;
using Android.Support.V7.App;
using ThreeSigma.Interview.Xamarin.Shared.ViewModels;

namespace ThreeSigma.Interview.Xamarin.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private readonly MainViewModel viewModel;

        public MainActivity()
        {
            viewModel = new MainViewModel("Hello world!");
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            Title = "Home";
            SetContentView(Resource.Layout.activity_main);
            
            base.OnCreate(savedInstanceState);
        }
    }
}