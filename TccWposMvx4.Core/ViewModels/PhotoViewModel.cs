using MvvmCross.Core.ViewModels;
using MvvmCross.Plugins.PictureChooser;
using System.IO;
using System.Windows.Input;

namespace TccWposMvx4.Core.ViewModels
{
    public class PhotoViewModel : MvxViewModel
    {
        private readonly IMvxPictureChooserTask _photoTask;

        public PhotoViewModel(IMvxPictureChooserTask photoTask)
        {
            _photoTask = photoTask;
        }

        private MvxCommand _getPhotoCommand;

        public ICommand GetPhotoCommand
        {
            get
            {
                _getPhotoCommand = _getPhotoCommand ?? new MvxCommand(GetPhoto);
                return _getPhotoCommand;
            }
        }

        private void GetPhoto()
        {
            _photoTask.TakePicture(300, 80, PhotoAction, () => { });
        }

        private MvxCommand _selectPhotoCommand;

        public ICommand SelectPhotoCommand
        {
            get
            {
                _selectPhotoCommand = _selectPhotoCommand ?? new MvxCommand(SelectPhoto);
                return _selectPhotoCommand;
            }
        }

        private void SelectPhoto()
        {
            _photoTask.ChoosePictureFromLibrary(300, 80, PhotoAction, () => { });
        }

        private byte[] _bytes;

        public byte[] Bytes
        {
            get { return _bytes; }
            set { _bytes = value; RaisePropertyChanged(() => Bytes); }
        }

        private void PhotoAction(Stream stream)
        {
            var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);
            Bytes = memoryStream.ToArray();
        }

    }
}
