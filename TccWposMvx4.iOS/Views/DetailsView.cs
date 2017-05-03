using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using TccWposMvx4.Core.ViewModels;

namespace TccWposMvx4.iOS.Views
{
    public partial class DetailsView : MvxViewController
    {

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.CreateBinding(Id).To((DetailsViewModel vm) => vm.Id).Apply();
        }
    }
}
