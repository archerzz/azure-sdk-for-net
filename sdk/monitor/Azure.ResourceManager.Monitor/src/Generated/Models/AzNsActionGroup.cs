// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Azure action group. </summary>
    public partial class AzNsActionGroup
    {
        /// <summary> Initializes a new instance of AzNsActionGroup. </summary>
        public AzNsActionGroup()
        {
            ActionGroup = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AzNsActionGroup. </summary>
        /// <param name="actionGroup"> Azure Action Group reference. </param>
        /// <param name="emailSubject"> Custom subject override for all email ids in Azure action group. </param>
        /// <param name="customWebhookPayload"> Custom payload to be sent for all webhook URI in Azure action group. </param>
        internal AzNsActionGroup(IList<string> actionGroup, string emailSubject, string customWebhookPayload)
        {
            ActionGroup = actionGroup;
            EmailSubject = emailSubject;
            CustomWebhookPayload = customWebhookPayload;
        }

        /// <summary> Azure Action Group reference. </summary>
        public IList<string> ActionGroup { get; }
        /// <summary> Custom subject override for all email ids in Azure action group. </summary>
        public string EmailSubject { get; set; }
        /// <summary> Custom payload to be sent for all webhook URI in Azure action group. </summary>
        public string CustomWebhookPayload { get; set; }
    }
}
