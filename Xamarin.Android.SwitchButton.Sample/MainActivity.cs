using Android.App;
using Android.Widget;
using Android.OS;

namespace Xamarin.Android.SwitchButton.Sample
{
    [Activity(Label = "Xamarin.Android.SwitchButton.Sample", MainLauncher = true, Theme = "@style/Theme.AppCompat")]
    public class MainActivity : Activity
    {
        private Com.Kyleduo.Switchbutton.SwitchButton _switch;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            _switch = FindViewById<Com.Kyleduo.Switchbutton.SwitchButton>(Resource.Id.sw);
            _switch.CheckedChange += (sender, e) => Toast.MakeText(this, $"isChecked {e.IsChecked}", ToastLength.Short).Show();
        }
    }
}

