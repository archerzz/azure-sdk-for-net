// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.StoragePool. </summary>
    public static partial class StoragePoolExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Gets a list of Disk Pools in a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/diskPools
        /// Operation Id: DiskPools_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DiskPoolResource> GetDiskPoolsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDiskPoolsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of Disk Pools in a subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/diskPools
        /// Operation Id: DiskPools_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DiskPoolResource> GetDiskPools(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDiskPools(cancellationToken);
        }

        /// <summary>
        /// Lists available Disk Pool Skus in an Azure location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/diskPoolZones
        /// Operation Id: DiskPoolZones_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="DiskPoolZoneInfo" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DiskPoolZoneInfo> GetDiskPoolZonesAsync(this SubscriptionResource subscriptionResource, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscriptionResource).GetDiskPoolZonesAsync(location, cancellationToken);
        }

        /// <summary>
        /// Lists available Disk Pool Skus in an Azure location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/diskPoolZones
        /// Operation Id: DiskPoolZones_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="DiskPoolZoneInfo" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DiskPoolZoneInfo> GetDiskPoolZones(this SubscriptionResource subscriptionResource, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscriptionResource).GetDiskPoolZones(location, cancellationToken);
        }

        /// <summary>
        /// Lists available StoragePool resources and skus in an Azure location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/skus
        /// Operation Id: ResourceSkus_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="ResourceSkuInfo" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceSkuInfo> GetResourceSkusAsync(this SubscriptionResource subscriptionResource, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscriptionResource).GetResourceSkusAsync(location, cancellationToken);
        }

        /// <summary>
        /// Lists available StoragePool resources and skus in an Azure location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/skus
        /// Operation Id: ResourceSkus_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="ResourceSkuInfo" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceSkuInfo> GetResourceSkus(this SubscriptionResource subscriptionResource, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscriptionResource).GetResourceSkus(location, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DiskPoolResources in the DiskPoolResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DiskPoolResources and their operations over a DiskPoolResource. </returns>
        public static DiskPoolCollection GetDiskPools(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetDiskPools();
        }

        /// <summary>
        /// Get a Disk pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}
        /// Operation Id: DiskPools_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public static async Task<Response<DiskPoolResource>> GetDiskPoolAsync(this ResourceGroupResource resourceGroupResource, string diskPoolName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetDiskPools().GetAsync(diskPoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Disk pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}
        /// Operation Id: DiskPools_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskPoolName"/> is null. </exception>
        public static Response<DiskPoolResource> GetDiskPool(this ResourceGroupResource resourceGroupResource, string diskPoolName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetDiskPools().Get(diskPoolName, cancellationToken);
        }

        #region DiskPoolResource
        /// <summary>
        /// Gets an object representing a <see cref="DiskPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DiskPoolResource.CreateResourceIdentifier" /> to create a <see cref="DiskPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DiskPoolResource" /> object. </returns>
        public static DiskPoolResource GetDiskPoolResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DiskPoolResource.ValidateResourceId(id);
                return new DiskPoolResource(client, id);
            }
            );
        }
        #endregion

        #region IscsiTargetResource
        /// <summary>
        /// Gets an object representing an <see cref="IscsiTargetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IscsiTargetResource.CreateResourceIdentifier" /> to create an <see cref="IscsiTargetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IscsiTargetResource" /> object. </returns>
        public static IscsiTargetResource GetIscsiTargetResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                IscsiTargetResource.ValidateResourceId(id);
                return new IscsiTargetResource(client, id);
            }
            );
        }
        #endregion
    }
}
