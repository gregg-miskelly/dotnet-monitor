﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.Diagnostics.Tools.Monitor.LibrarySharing
{
    internal interface ISharedLibraryInitializer
    {
        IFileProviderFactory Initialize();
    }
}
