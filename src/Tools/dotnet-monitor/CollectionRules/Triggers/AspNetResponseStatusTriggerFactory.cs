﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Diagnostics.Monitoring.WebApi;
using Microsoft.Diagnostics.Tools.Monitor.CollectionRules.Options.Triggers;
using System;

namespace Microsoft.Diagnostics.Tools.Monitor.CollectionRules.Triggers
{
    /// <summary>
    /// Factory for creating a new AspNetResponseStatusTrigger trigger.
    /// </summary>
    internal sealed class AspNetResponseStatusTriggerFactory :
        ICollectionRuleTriggerFactory<AspNetResponseStatusOptions>
    {
        /// <inheritdoc/>
        public ICollectionRuleTrigger Create(IEndpointInfo endpointInfo, Action callback, AspNetResponseStatusOptions options)
        {
            throw new NotImplementedException("TODO: Implement AspNetResponseStatusTrigger.");
        }
    }
}