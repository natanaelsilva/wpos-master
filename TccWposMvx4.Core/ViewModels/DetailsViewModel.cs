using MvvmCross.Core.ViewModels;

namespace TccWposMvx4.Core.ViewModels
{
    public class DetailsViewModel : MvxViewModel
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                RaisePropertyChanged(() => Id);
            }
        }

        public void Init(string id)
        {
            Id = id;
        }
    }
}
