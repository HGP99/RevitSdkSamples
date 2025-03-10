﻿//
// (C) Copyright 2003-2019 by Autodesk, Inc.
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE. AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
//
// Use, duplication, or disclosure by the U.S. Government is subject to
// restrictions set forth in FAR 52.227-19 (Commercial Computer
// Software - Restricted Rights) and DFAR 252.227-7013(c)(1)(ii)
// (Rights in Technical Data and Computer Software), as applicable.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Autodesk.Revit.UI;

namespace Revit.SDK.Samples.DockableDialogs.CS
{
    class Globals
    {

        public const string ApplicationName = "DockableDialogs";
        public const string DiagnosticsTabName = "DockableDialogs";
        public const string DiagnosticsPanelName = "DockableDialogs Panel";

        public const string RegisterPage = "Register Page";
        public const string ShowPage = "Show Page";
        public const string HidePage = "Hide Page";


        public static DockablePaneId sm_UserDockablePaneId = new DockablePaneId(new Guid("{3BAFCF52-AC5C-4CF8-B1CB-D0B1D0E90237}"));

    }
}
