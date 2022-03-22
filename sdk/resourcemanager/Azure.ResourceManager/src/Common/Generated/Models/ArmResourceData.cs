// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Models
{
    /// <summary> Common fields that are returned in the response for all Azure Resource Manager resources. </summary>
    [ReferenceType]
    public abstract partial class ArmResourceData
    {
        /// <summary> Initializes a new instance of ArmResourceData. </summary>
        [InitializationConstructor]
        protected ArmResourceData()
        {
        }

        /// <summary> Initializes a new instance of ArmResourceData. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="resourceType"> The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;. </param>
        /// <param name="systemData"> Azure Resource Manager metadata containing createdBy and modifiedBy information. </param>
        [SerializationConstructor]
        protected ArmResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData)
        {
            Id = id;
            Name = name;
            ResourceType = resourceType;
            SystemData = systemData;
        }

        /// <summary> Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> The name of the resource. </summary>
        public string Name { get; }
        /// <summary> The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;. </summary>
        public ResourceType ResourceType { get; }
        /// <summary> Azure Resource Manager metadata containing createdBy and modifiedBy information. </summary>
        public SystemData SystemData { get; }
    }
}
