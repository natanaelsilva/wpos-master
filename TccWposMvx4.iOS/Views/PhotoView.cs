using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using TccWposMvx4.Core.ViewModels;

namespace TccWposMvx4.iOS.Views
{
    public partial class PhotoView : MvxViewController
    {
        public PhotoView() : base("PhotoView", null)
        {
                
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<PhotoView, PhotoViewModel>();
            set.Bind(GetPhotoButton).To(vm => vm.GetPhotoCommand);
            set.Bind(SelectPhotoButton).To(vm => vm.SelectPhotoCommand);
            set.Bind(ShowPhoto).To(vm => vm.Bytes).WithConversion("InMemoryImage");
            set.Apply();
        }
    }
}
