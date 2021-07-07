// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> IP configuration of an Azure Firewall. </summary>
    public partial class AzureFirewallIPConfiguration : WritableSubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of AzureFirewallIPConfiguration. </summary>
        public AzureFirewallIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of AzureFirewallIPConfiguration. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="privateIPAddress"> The Firewall Internal Load Balancer IP to be used as the next hop in User Defined Routes. </param>
        /// <param name="subnet"> Reference to the subnet resource. This resource must be named &apos;AzureFirewallSubnet&apos; or &apos;AzureFirewallManagementSubnet&apos;. </param>
        /// <param name="publicIPAddress"> Reference to the PublicIP resource. This field is a mandatory input if subnet is not null. </param>
        /// <param name="provisioningState"> The provisioning state of the Azure firewall IP configuration resource. </param>
        internal AzureFirewallIPConfiguration(string id, string name, string etag, string type, string privateIPAddress, SubResource subnet, SubResource publicIPAddress, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            PrivateIPAddress = privateIPAddress;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; }
        /// <summary> The Firewall Internal Load Balancer IP to be used as the next hop in User Defined Routes. </summary>
        public string PrivateIPAddress { get; }
        /// <summary> Reference to the subnet resource. This resource must be named &apos;AzureFirewallSubnet&apos; or &apos;AzureFirewallManagementSubnet&apos;. </summary>
        public SubResource Subnet { get; set; }
        /// <summary> Reference to the PublicIP resource. This field is a mandatory input if subnet is not null. </summary>
        public SubResource PublicIPAddress { get; set; }
        /// <summary> The provisioning state of the Azure firewall IP configuration resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
