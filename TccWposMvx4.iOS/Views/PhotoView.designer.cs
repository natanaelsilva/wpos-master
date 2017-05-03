// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TccWposMvx4.iOS.Views
{
    [Register ("PhotoView")]
    partial class PhotoView
    {
        [Outlet]
        UIButton GetPhotoButton { get; set; }

        [Outlet]
        UIButton SelectPhotoButton { get; set; }

        [Outlet]
        UIImage ShowPhoto { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (GetPhotoButton != null) {
                GetPhotoButton.Dispose ();
                GetPhotoButton = null;
            }

            if (SelectPhotoButton != null) {
                SelectPhotoButton.Dispose ();
                SelectPhotoButton = null;
            }

            if (ShowPhoto != null) {
                ShowPhoto.Dispose ();
                ShowPhoto = null;
            }
        }
    }
}