// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.DevOpsInfrastructure.Mocking;
using Azure.ResourceManager.DevOpsInfrastructure.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DevOpsInfrastructure
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DevOpsInfrastructure. </summary>
    public static partial class DevOpsInfrastructureExtensions
    {
        private static MockableDevOpsInfrastructureArmClient GetMockableDevOpsInfrastructureArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableDevOpsInfrastructureArmClient(client0));
        }

        private static MockableDevOpsInfrastructureResourceGroupResource GetMockableDevOpsInfrastructureResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDevOpsInfrastructureResourceGroupResource(client, resource.Id));
        }

        private static MockableDevOpsInfrastructureSubscriptionResource GetMockableDevOpsInfrastructureSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDevOpsInfrastructureSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="DevOpsPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DevOpsPoolResource.CreateResourceIdentifier" /> to create a <see cref="DevOpsPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDevOpsInfrastructureArmClient.GetDevOpsPoolResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DevOpsPoolResource"/> object. </returns>
        public static DevOpsPoolResource GetDevOpsPoolResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDevOpsInfrastructureArmClient(client).GetDevOpsPoolResource(id);
        }

        /// <summary>
        /// Gets a collection of DevOpsPoolResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDevOpsInfrastructureResourceGroupResource.GetDevOpsPools()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of DevOpsPoolResources and their operations over a DevOpsPoolResource. </returns>
        public static DevOpsPoolCollection GetDevOpsPools(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDevOpsInfrastructureResourceGroupResource(resourceGroupResource).GetDevOpsPools();
        }

        /// <summary>
        /// Get a Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDevOpsInfrastructureResourceGroupResource.GetDevOpsPoolAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="poolName"> Name of the pool. It needs to be globally unique. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="poolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DevOpsPoolResource>> GetDevOpsPoolAsync(this ResourceGroupResource resourceGroupResource, string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableDevOpsInfrastructureResourceGroupResource(resourceGroupResource).GetDevOpsPoolAsync(poolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/pools/{poolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDevOpsInfrastructureResourceGroupResource.GetDevOpsPool(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="poolName"> Name of the pool. It needs to be globally unique. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="poolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DevOpsPoolResource> GetDevOpsPool(this ResourceGroupResource resourceGroupResource, string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDevOpsInfrastructureResourceGroupResource(resourceGroupResource).GetDevOpsPool(poolName, cancellationToken);
        }

        /// <summary>
        /// List ImageVersion resources by Image
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/images/{imageName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersions_listByImage</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDevOpsInfrastructureResourceGroupResource.GetImageVersionsByImage(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="imageName"> Name of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="imageName"/> is null. </exception>
        /// <returns> An async collection of <see cref="DevOpsImageVersion"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DevOpsImageVersion> GetImageVersionsByImageAsync(this ResourceGroupResource resourceGroupResource, string imageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDevOpsInfrastructureResourceGroupResource(resourceGroupResource).GetImageVersionsByImageAsync(imageName, cancellationToken);
        }

        /// <summary>
        /// List ImageVersion resources by Image
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevOpsInfrastructure/images/{imageName}/versions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ImageVersions_listByImage</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDevOpsInfrastructureResourceGroupResource.GetImageVersionsByImage(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="imageName"> Name of the image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="imageName"/> is null. </exception>
        /// <returns> A collection of <see cref="DevOpsImageVersion"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DevOpsImageVersion> GetImageVersionsByImage(this ResourceGroupResource resourceGroupResource, string imageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDevOpsInfrastructureResourceGroupResource(resourceGroupResource).GetImageVersionsByImage(imageName, cancellationToken);
        }

        /// <summary>
        /// List Pool resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevOpsInfrastructure/pools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_listBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDevOpsInfrastructureSubscriptionResource.GetDevOpsPools(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DevOpsPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DevOpsPoolResource> GetDevOpsPoolsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDevOpsInfrastructureSubscriptionResource(subscriptionResource).GetDevOpsPoolsAsync(cancellationToken);
        }

        /// <summary>
        /// List Pool resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevOpsInfrastructure/pools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pools_listBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DevOpsPoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDevOpsInfrastructureSubscriptionResource.GetDevOpsPools(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DevOpsPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DevOpsPoolResource> GetDevOpsPools(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDevOpsInfrastructureSubscriptionResource(subscriptionResource).GetDevOpsPools(cancellationToken);
        }

        /// <summary>
        /// List ResourceSku resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevOpsInfrastructure/locations/{locationName}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sku_listByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDevOpsInfrastructureSubscriptionResource.GetSkusByLocation(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> Name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="locationName"/> is null. </exception>
        /// <returns> An async collection of <see cref="DevOpsResourceSku"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DevOpsResourceSku> GetSkusByLocationAsync(this SubscriptionResource subscriptionResource, string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDevOpsInfrastructureSubscriptionResource(subscriptionResource).GetSkusByLocationAsync(locationName, cancellationToken);
        }

        /// <summary>
        /// List ResourceSku resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevOpsInfrastructure/locations/{locationName}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Sku_listByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDevOpsInfrastructureSubscriptionResource.GetSkusByLocation(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> Name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="locationName"/> is null. </exception>
        /// <returns> A collection of <see cref="DevOpsResourceSku"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DevOpsResourceSku> GetSkusByLocation(this SubscriptionResource subscriptionResource, string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDevOpsInfrastructureSubscriptionResource(subscriptionResource).GetSkusByLocation(locationName, cancellationToken);
        }

        /// <summary>
        /// List Quota resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevOpsInfrastructure/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionUsages_usages</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDevOpsInfrastructureSubscriptionResource.GetUsages(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DevOpsResourceQuota"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DevOpsResourceQuota> GetUsagesAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDevOpsInfrastructureSubscriptionResource(subscriptionResource).GetUsagesAsync(location, cancellationToken);
        }

        /// <summary>
        /// List Quota resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DevOpsInfrastructure/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubscriptionUsages_usages</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-19</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDevOpsInfrastructureSubscriptionResource.GetUsages(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DevOpsResourceQuota"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DevOpsResourceQuota> GetUsages(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDevOpsInfrastructureSubscriptionResource(subscriptionResource).GetUsages(location, cancellationToken);
        }
    }
}
