// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VPN client revoked certificate of virtual network gateway. </summary>
    public partial class VpnClientRevokedCertificate : WritableSubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of VpnClientRevokedCertificate. </summary>
        public VpnClientRevokedCertificate()
        {
        }

        /// <summary> Initializes a new instance of VpnClientRevokedCertificate. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="thumbprint"> The revoked VPN client certificate thumbprint. </param>
        /// <param name="provisioningState"> The provisioning state of the VPN client revoked certificate resource. </param>
        internal VpnClientRevokedCertificate(string id, string name, string etag, string thumbprint, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Thumbprint = thumbprint;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The revoked VPN client certificate thumbprint. </summary>
        public string Thumbprint { get; set; }
        /// <summary> The provisioning state of the VPN client revoked certificate resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
