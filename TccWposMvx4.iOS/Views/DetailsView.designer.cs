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
    [Register ("DetailsView")]
    partial class DetailsView
    {
        [Outlet]
        UILabel ParameterId { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Id { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Id != null) {
                Id.Dispose ();
                Id = null;
            }
        }
    }
}