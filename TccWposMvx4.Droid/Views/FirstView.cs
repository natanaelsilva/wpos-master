using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace TccWposMvx4.Droid.Views
{
    [Activity(
        Label = "View First"
        , Icon = "@drawable/icon")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.First);
        }
    }
}
