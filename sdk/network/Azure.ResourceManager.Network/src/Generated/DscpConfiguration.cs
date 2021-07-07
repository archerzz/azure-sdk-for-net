// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a DscpConfiguration along with the instance operations that can be performed on it. </summary>
    public class DscpConfiguration : DscpConfigurationOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "DscpConfiguration"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal DscpConfiguration(OperationsBase options, DscpConfigurationData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the DscpConfigurationData. </summary>
        public DscpConfigurationData Data { get; private set; }
    }
}
