﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SeekiosApp.iOS
{
    [Register ("ListTutorialView")]
    partial class ListTutorialView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView Tableview { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Tableview != null) {
                Tableview.Dispose ();
                Tableview = null;
            }
        }
    }
}