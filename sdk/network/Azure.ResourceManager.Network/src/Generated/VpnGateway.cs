// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a VpnGateway along with the instance operations that can be performed on it. </summary>
    public class VpnGateway : VpnGatewayOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "VpnGateway"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal VpnGateway(OperationsBase options, VpnGatewayData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the VpnGatewayData. </summary>
        public VpnGatewayData Data { get; private set; }
    }
}
