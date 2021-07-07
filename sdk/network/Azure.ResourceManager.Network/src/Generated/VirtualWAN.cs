// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a VirtualWAN along with the instance operations that can be performed on it. </summary>
    public class VirtualWAN : VirtualWANOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "VirtualWAN"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal VirtualWAN(OperationsBase options, VirtualWANData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the VirtualWANData. </summary>
        public VirtualWANData Data { get; private set; }
    }
}
