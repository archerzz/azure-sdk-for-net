// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.StandbyPool.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableStandbyPoolResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableStandbyPoolResourceGroupResource"/> class for mocking. </summary>
        protected MockableStandbyPoolResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableStandbyPoolResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableStandbyPoolResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of StandbyVirtualMachinePoolResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of StandbyVirtualMachinePoolResources and their operations over a StandbyVirtualMachinePoolResource. </returns>
        public virtual StandbyVirtualMachinePoolCollection GetStandbyVirtualMachinePools()
        {
            return GetCachedClient(client => new StandbyVirtualMachinePoolCollection(client, Id));
        }

        /// <summary>
        /// Get a StandbyVirtualMachinePoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePools_get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="standbyVirtualMachinePoolName"> Name of the standby virtual machine pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="standbyVirtualMachinePoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="standbyVirtualMachinePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<StandbyVirtualMachinePoolResource>> GetStandbyVirtualMachinePoolAsync(string standbyVirtualMachinePoolName, CancellationToken cancellationToken = default)
        {
            return await GetStandbyVirtualMachinePools().GetAsync(standbyVirtualMachinePoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a StandbyVirtualMachinePoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePools_get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="standbyVirtualMachinePoolName"> Name of the standby virtual machine pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="standbyVirtualMachinePoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="standbyVirtualMachinePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<StandbyVirtualMachinePoolResource> GetStandbyVirtualMachinePool(string standbyVirtualMachinePoolName, CancellationToken cancellationToken = default)
        {
            return GetStandbyVirtualMachinePools().Get(standbyVirtualMachinePoolName, cancellationToken);
        }

        /// <summary> Gets a collection of StandbyContainerGroupPoolResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of StandbyContainerGroupPoolResources and their operations over a StandbyContainerGroupPoolResource. </returns>
        public virtual StandbyContainerGroupPoolCollection GetStandbyContainerGroupPools()
        {
            return GetCachedClient(client => new StandbyContainerGroupPoolCollection(client, Id));
        }

        /// <summary>
        /// Get a StandbyContainerGroupPoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPools_get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="standbyContainerGroupPoolName"> Name of the standby container group pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<StandbyContainerGroupPoolResource>> GetStandbyContainerGroupPoolAsync(string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            return await GetStandbyContainerGroupPools().GetAsync(standbyContainerGroupPoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a StandbyContainerGroupPoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPools_get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="standbyContainerGroupPoolName"> Name of the standby container group pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<StandbyContainerGroupPoolResource> GetStandbyContainerGroupPool(string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            return GetStandbyContainerGroupPools().Get(standbyContainerGroupPoolName, cancellationToken);
        }
    }
}
