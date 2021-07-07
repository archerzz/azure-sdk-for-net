// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Virtual Wan Vpn profile parameters Vpn profile generation. </summary>
    internal partial class VirtualWanVpnProfileParameters
    {
        /// <summary> Initializes a new instance of VirtualWanVpnProfileParameters. </summary>
        public VirtualWanVpnProfileParameters()
        {
        }

        /// <summary> VpnServerConfiguration partial resource uri with which VirtualWan is associated to. </summary>
        public string VpnServerConfigurationResourceId { get; set; }
        /// <summary> VPN client authentication method. </summary>
        public AuthenticationMethod? AuthenticationMethod { get; set; }
    }
}
