// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ResourcePoolResources in the ResourcePoolResource. </summary>
        /// <returns> An object representing collection of ResourcePoolResources and their operations over a ResourcePoolResource. </returns>
        public virtual ResourcePoolCollection GetResourcePools()
        {
            return GetCachedClient(Client => new ResourcePoolCollection(Client, Id));
        }

        /// <summary> Gets a collection of VMwareClusterResources in the VMwareClusterResource. </summary>
        /// <returns> An object representing collection of VMwareClusterResources and their operations over a VMwareClusterResource. </returns>
        public virtual VMwareClusterCollection GetVMwareClusters()
        {
            return GetCachedClient(Client => new VMwareClusterCollection(Client, Id));
        }

        /// <summary> Gets a collection of VMwareHostResources in the VMwareHostResource. </summary>
        /// <returns> An object representing collection of VMwareHostResources and their operations over a VMwareHostResource. </returns>
        public virtual VMwareHostCollection GetVMwareHosts()
        {
            return GetCachedClient(Client => new VMwareHostCollection(Client, Id));
        }

        /// <summary> Gets a collection of VMwareDatastoreResources in the VMwareDatastoreResource. </summary>
        /// <returns> An object representing collection of VMwareDatastoreResources and their operations over a VMwareDatastoreResource. </returns>
        public virtual VMwareDatastoreCollection GetVMwareDatastores()
        {
            return GetCachedClient(Client => new VMwareDatastoreCollection(Client, Id));
        }

        /// <summary> Gets a collection of VCenterResources in the VCenterResource. </summary>
        /// <returns> An object representing collection of VCenterResources and their operations over a VCenterResource. </returns>
        public virtual VCenterCollection GetVCenters()
        {
            return GetCachedClient(Client => new VCenterCollection(Client, Id));
        }

        /// <summary> Gets a collection of VirtualMachineResources in the VirtualMachineResource. </summary>
        /// <returns> An object representing collection of VirtualMachineResources and their operations over a VirtualMachineResource. </returns>
        public virtual VirtualMachineCollection GetVirtualMachines()
        {
            return GetCachedClient(Client => new VirtualMachineCollection(Client, Id));
        }

        /// <summary> Gets a collection of VirtualMachineTemplateResources in the VirtualMachineTemplateResource. </summary>
        /// <returns> An object representing collection of VirtualMachineTemplateResources and their operations over a VirtualMachineTemplateResource. </returns>
        public virtual VirtualMachineTemplateCollection GetVirtualMachineTemplates()
        {
            return GetCachedClient(Client => new VirtualMachineTemplateCollection(Client, Id));
        }

        /// <summary> Gets a collection of VirtualNetworkResources in the VirtualNetworkResource. </summary>
        /// <returns> An object representing collection of VirtualNetworkResources and their operations over a VirtualNetworkResource. </returns>
        public virtual VirtualNetworkCollection GetVirtualNetworks()
        {
            return GetCachedClient(Client => new VirtualNetworkCollection(Client, Id));
        }
    }
}
