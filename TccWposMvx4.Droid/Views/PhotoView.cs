
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace TccWposMvx4.Droid.Views
{
    [Activity(Label = "View Photo")]
    public class PhotoView : MvxActivity
    {
        protected override void OnCreate( Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Photo);
        }
    }
}