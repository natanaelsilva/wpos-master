using UIKit;
using MvvmCross.iOS.Views;
using TccWposMvx4.Core.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace TccWposMvx4.iOS.Views
{
    public partial class MainView : MvxViewController
    {
        public MainView() : base("MainView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.CreateBinding(Parameter).To((MainViewModel vm) => vm.Parameter).Apply();
            this.CreateBinding(FirstButton).To((MainViewModel vm) => vm.NavToFirstCommand).Apply();
            this.CreateBinding(DetailsButton).To((MainViewModel vm) => vm.NavToDetailsCommand).Apply();
            this.CreateBinding(GetPhotoButton).To((MainViewModel vm) => vm.NavToPhotoCommand).Apply();

            this.View.AddGestureRecognizer(new UITapGestureRecognizer(() => { Parameter.ResignFirstResponder(); }));
        }

    }
}