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
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        UIButton FirstButton { get; set; }

        [Outlet]
        UIButton DetailsButton { get; set; }

        [Outlet]
        UIButton GetPhotoButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Parameter { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DetailsButton != null) {
                DetailsButton.Dispose ();
                DetailsButton = null;
            }

            if (FirstButton != null) {
                FirstButton.Dispose ();
                FirstButton = null;
            }

            if (GetPhotoButton != null) {
                GetPhotoButton.Dispose ();
                GetPhotoButton = null;
            }

            if (Parameter != null) {
                Parameter.Dispose ();
                Parameter = null;
            }
        }
    }
}