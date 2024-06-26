// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Existing recovery resource group input. </summary>
    public partial class ExistingRecoveryResourceGroup : RecoveryResourceGroupCustomDetails
    {
        /// <summary> Initializes a new instance of <see cref="ExistingRecoveryResourceGroup"/>. </summary>
        public ExistingRecoveryResourceGroup()
        {
            ResourceType = "Existing";
        }

        /// <summary> Initializes a new instance of <see cref="ExistingRecoveryResourceGroup"/>. </summary>
        /// <param name="resourceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryResourceGroupId"> The recovery resource group Id. Valid for V2 scenarios. </param>
        internal ExistingRecoveryResourceGroup(string resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier recoveryResourceGroupId) : base(resourceType, serializedAdditionalRawData)
        {
            RecoveryResourceGroupId = recoveryResourceGroupId;
            ResourceType = resourceType ?? "Existing";
        }

        /// <summary> The recovery resource group Id. Valid for V2 scenarios. </summary>
        public ResourceIdentifier RecoveryResourceGroupId { get; set; }
    }
}
