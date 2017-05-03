using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace TccWposMvx4.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private string _parameter;

        public MainViewModel()
        {
            _parameter = "0";
        }

        public ICommand NavToFirstCommand
        {
            get { return new MvxCommand(() => ShowViewModel<FirstViewModel>()); }
        }

        public string Parameter
        {
            get { return _parameter; }
            set
            {
                _parameter = value;
                RaisePropertyChanged(() => Parameter);
            }
        }

        public ICommand NavToDetailsCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<DetailsViewModel>(new { id = Parameter }));
            }
        }

        public ICommand NavToPhotoCommand
        {
            get { return new MvxCommand(() => ShowViewModel<PhotoViewModel>()); }
        }
    }
}
