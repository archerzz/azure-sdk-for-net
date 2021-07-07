// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Result of the request to list all vpn connections to a virtual wan vpn gateway. It contains a list of Vpn Connections and a URL nextLink to get the next set of results. </summary>
    internal partial class ListVpnConnectionsResult
    {
        /// <summary> Initializes a new instance of ListVpnConnectionsResult. </summary>
        internal ListVpnConnectionsResult()
        {
            Value = new ChangeTrackingList<VpnConnectionData>();
        }

        /// <summary> Initializes a new instance of ListVpnConnectionsResult. </summary>
        /// <param name="value"> List of Vpn Connections. </param>
        /// <param name="nextLink"> URL to get the next set of operation list results if there are any. </param>
        internal ListVpnConnectionsResult(IReadOnlyList<VpnConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Vpn Connections. </summary>
        public IReadOnlyList<VpnConnectionData> Value { get; }
        /// <summary> URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
