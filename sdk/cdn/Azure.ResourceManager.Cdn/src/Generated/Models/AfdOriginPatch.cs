// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> AFDOrigin properties needed for origin update. </summary>
    public partial class AfdOriginPatch
    {
        /// <summary> Initializes a new instance of AfdOriginPatch. </summary>
        public AfdOriginPatch()
        {
        }

        /// <summary> The name of the origin group which contains this origin. </summary>
        public string OriginGroupName { get; }
        /// <summary> Resource reference to the Azure origin resource. </summary>
        internal WritableSubResource AzureOrigin { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier AzureOriginId
        {
            get => AzureOrigin is null ? default : AzureOrigin.Id;
            set
            {
                if (AzureOrigin is null)
                    AzureOrigin = new WritableSubResource();
                AzureOrigin.Id = value;
            }
        }

        /// <summary> The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint. </summary>
        public string HostName { get; set; }
        /// <summary> The value of the HTTP port. Must be between 1 and 65535. </summary>
        public int? HttpPort { get; set; }
        /// <summary> The value of the HTTPS port. Must be between 1 and 65535. </summary>
        public int? HttpsPort { get; set; }
        /// <summary> The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint. </summary>
        public string OriginHostHeader { get; set; }
        /// <summary> Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5. </summary>
        public int? Priority { get; set; }
        /// <summary> Weight of the origin in given origin group for load balancing. Must be between 1 and 1000. </summary>
        public int? Weight { get; set; }
        /// <summary> The properties of the private link resource for private origin. </summary>
        public SharedPrivateLinkResourceProperties SharedPrivateLinkResource { get; set; }
        /// <summary> Whether to enable health probes to be made against backends defined under backendPools. Health probes can only be disabled if there is a single enabled backend in single enabled backend pool. </summary>
        public EnabledState? EnabledState { get; set; }
        /// <summary> Whether to enable certificate name check at origin level. </summary>
        public bool? EnforceCertificateNameCheck { get; set; }
    }
}
