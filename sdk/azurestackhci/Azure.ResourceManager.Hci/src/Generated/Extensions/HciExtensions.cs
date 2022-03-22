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

namespace Azure.ResourceManager.Hci
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Hci. </summary>
    public static partial class HciExtensions
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
        /// List all HCI clusters in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/clusters
        /// Operation Id: Clusters_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HciClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HciClusterResource> GetHciClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetHciClustersAsync(cancellationToken);
        }

        /// <summary>
        /// List all HCI clusters in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AzureStackHCI/clusters
        /// Operation Id: Clusters_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HciClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HciClusterResource> GetHciClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetHciClusters(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of HciClusterResources in the HciClusterResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of HciClusterResources and their operations over a HciClusterResource. </returns>
        public static HciClusterCollection GetHciClusters(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetHciClusters();
        }

        /// <summary>
        /// Get HCI cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public static async Task<Response<HciClusterResource>> GetHciClusterAsync(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetHciClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get HCI cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public static Response<HciClusterResource> GetHciCluster(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetHciClusters().Get(clusterName, cancellationToken);
        }

        #region ArcSettingResource
        /// <summary>
        /// Gets an object representing an <see cref="ArcSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ArcSettingResource.CreateResourceIdentifier" /> to create an <see cref="ArcSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArcSettingResource" /> object. </returns>
        public static ArcSettingResource GetArcSettingResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ArcSettingResource.ValidateResourceId(id);
                return new ArcSettingResource(client, id);
            }
            );
        }
        #endregion

        #region HciClusterResource
        /// <summary>
        /// Gets an object representing a <see cref="HciClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HciClusterResource.CreateResourceIdentifier" /> to create a <see cref="HciClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HciClusterResource" /> object. </returns>
        public static HciClusterResource GetHciClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                HciClusterResource.ValidateResourceId(id);
                return new HciClusterResource(client, id);
            }
            );
        }
        #endregion

        #region ArcExtensionResource
        /// <summary>
        /// Gets an object representing an <see cref="ArcExtensionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ArcExtensionResource.CreateResourceIdentifier" /> to create an <see cref="ArcExtensionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArcExtensionResource" /> object. </returns>
        public static ArcExtensionResource GetArcExtensionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ArcExtensionResource.ValidateResourceId(id);
                return new ArcExtensionResource(client, id);
            }
            );
        }
        #endregion
    }
}
