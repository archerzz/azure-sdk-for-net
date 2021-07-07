// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> SSL profile of an application gateway. </summary>
    public partial class ApplicationGatewaySslProfile : WritableSubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of ApplicationGatewaySslProfile. </summary>
        public ApplicationGatewaySslProfile()
        {
            TrustedClientCertificates = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of ApplicationGatewaySslProfile. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Name of the SSL profile that is unique within an Application Gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="trustedClientCertificates"> Array of references to application gateway trusted client certificates. </param>
        /// <param name="sslPolicy"> SSL policy of the application gateway resource. </param>
        /// <param name="clientAuthConfiguration"> Client authentication configuration of the application gateway resource. </param>
        /// <param name="provisioningState"> The provisioning state of the HTTP listener resource. </param>
        internal ApplicationGatewaySslProfile(string id, string name, string etag, string type, IList<SubResource> trustedClientCertificates, ApplicationGatewaySslPolicy sslPolicy, ApplicationGatewayClientAuthConfiguration clientAuthConfiguration, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            TrustedClientCertificates = trustedClientCertificates;
            SslPolicy = sslPolicy;
            ClientAuthConfiguration = clientAuthConfiguration;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the SSL profile that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; }
        /// <summary> Array of references to application gateway trusted client certificates. </summary>
        public IList<SubResource> TrustedClientCertificates { get; }
        /// <summary> SSL policy of the application gateway resource. </summary>
        public ApplicationGatewaySslPolicy SslPolicy { get; set; }
        /// <summary> Client authentication configuration of the application gateway resource. </summary>
        public ApplicationGatewayClientAuthConfiguration ClientAuthConfiguration { get; set; }
        /// <summary> The provisioning state of the HTTP listener resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
