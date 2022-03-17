// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Hci
{
    /// <summary> A class representing collection of ArcSetting and their operations over its parent. </summary>
    public partial class ArcSettingCollection : ArmCollection, IEnumerable<ArcSettingResource>, IAsyncEnumerable<ArcSettingResource>
    {
        private readonly ClientDiagnostics _arcSettingClientDiagnostics;
        private readonly ArcSettingsRestOperations _arcSettingRestClient;

        /// <summary> Initializes a new instance of the <see cref="ArcSettingCollection"/> class for mocking. </summary>
        protected ArcSettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ArcSettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ArcSettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _arcSettingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", ArcSettingResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ArcSettingResource.ResourceType, out string arcSettingApiVersion);
            _arcSettingRestClient = new ArcSettingsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, arcSettingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HciClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HciClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create ArcSetting for HCI cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}
        /// Operation Id: ArcSettings_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="arcSetting"> Parameters supplied to the Create ArcSetting resource for this HCI cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> or <paramref name="arcSetting"/> is null. </exception>
        public virtual async Task<ArmOperation<ArcSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string arcSettingName, ArcSettingData arcSetting, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));
            Argument.AssertNotNull(arcSetting, nameof(arcSetting));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _arcSettingRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, arcSetting, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<ArcSettingResource>(Response.FromValue(new ArcSettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create ArcSetting for HCI cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}
        /// Operation Id: ArcSettings_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="arcSetting"> Parameters supplied to the Create ArcSetting resource for this HCI cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> or <paramref name="arcSetting"/> is null. </exception>
        public virtual ArmOperation<ArcSettingResource> CreateOrUpdate(WaitUntil waitUntil, string arcSettingName, ArcSettingData arcSetting, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));
            Argument.AssertNotNull(arcSetting, nameof(arcSetting));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _arcSettingRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, arcSetting, cancellationToken);
                var operation = new HciArmOperation<ArcSettingResource>(Response.FromValue(new ArcSettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get ArcSetting resource details of HCI Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}
        /// Operation Id: ArcSettings_Get
        /// </summary>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> is null. </exception>
        public virtual async Task<Response<ArcSettingResource>> GetAsync(string arcSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _arcSettingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArcSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get ArcSetting resource details of HCI Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}
        /// Operation Id: ArcSettings_Get
        /// </summary>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> is null. </exception>
        public virtual Response<ArcSettingResource> Get(string arcSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.Get");
            scope.Start();
            try
            {
                var response = _arcSettingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ArcSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get ArcSetting resources of HCI Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings
        /// Operation Id: ArcSettings_ListByCluster
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ArcSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ArcSettingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ArcSettingResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _arcSettingRestClient.ListByClusterAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ArcSettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ArcSettingResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _arcSettingRestClient.ListByClusterNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ArcSettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Get ArcSetting resources of HCI Cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings
        /// Operation Id: ArcSettings_ListByCluster
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ArcSettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ArcSettingResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ArcSettingResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _arcSettingRestClient.ListByCluster(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ArcSettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ArcSettingResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _arcSettingRestClient.ListByClusterNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ArcSettingResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}
        /// Operation Id: ArcSettings_Get
        /// </summary>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string arcSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(arcSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}
        /// Operation Id: ArcSettings_Get
        /// </summary>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> is null. </exception>
        public virtual Response<bool> Exists(string arcSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(arcSettingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}
        /// Operation Id: ArcSettings_Get
        /// </summary>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> is null. </exception>
        public virtual async Task<Response<ArcSettingResource>> GetIfExistsAsync(string arcSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _arcSettingRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ArcSettingResource>(null, response.GetRawResponse());
                return Response.FromValue(new ArcSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/arcSettings/{arcSettingName}
        /// Operation Id: ArcSettings_Get
        /// </summary>
        /// <param name="arcSettingName"> The name of the proxy resource holding details of HCI ArcSetting information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="arcSettingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="arcSettingName"/> is null. </exception>
        public virtual Response<ArcSettingResource> GetIfExists(string arcSettingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(arcSettingName, nameof(arcSettingName));

            using var scope = _arcSettingClientDiagnostics.CreateScope("ArcSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _arcSettingRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, arcSettingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ArcSettingResource>(null, response.GetRawResponse());
                return Response.FromValue(new ArcSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ArcSettingResource> IEnumerable<ArcSettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ArcSettingResource> IAsyncEnumerable<ArcSettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
