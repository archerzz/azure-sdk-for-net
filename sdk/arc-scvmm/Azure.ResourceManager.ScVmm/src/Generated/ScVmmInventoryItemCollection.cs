// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ScVmm
{
    /// <summary>
    /// A class representing a collection of <see cref="ScVmmInventoryItemResource"/> and their operations.
    /// Each <see cref="ScVmmInventoryItemResource"/> in the collection will belong to the same instance of <see cref="ScVmmServerResource"/>.
    /// To get a <see cref="ScVmmInventoryItemCollection"/> instance call the GetScVmmInventoryItems method from an instance of <see cref="ScVmmServerResource"/>.
    /// </summary>
    public partial class ScVmmInventoryItemCollection : ArmCollection, IEnumerable<ScVmmInventoryItemResource>, IAsyncEnumerable<ScVmmInventoryItemResource>
    {
        private readonly ClientDiagnostics _scVmmInventoryItemInventoryItemsClientDiagnostics;
        private readonly InventoryItemsRestOperations _scVmmInventoryItemInventoryItemsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScVmmInventoryItemCollection"/> class for mocking. </summary>
        protected ScVmmInventoryItemCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScVmmInventoryItemCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScVmmInventoryItemCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scVmmInventoryItemInventoryItemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ScVmm", ScVmmInventoryItemResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScVmmInventoryItemResource.ResourceType, out string scVmmInventoryItemInventoryItemsApiVersion);
            _scVmmInventoryItemInventoryItemsRestClient = new InventoryItemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scVmmInventoryItemInventoryItemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ScVmmServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ScVmmServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create Or Update InventoryItem.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmInventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inventoryItemResourceName"> Name of the inventoryItem. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScVmmInventoryItemResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string inventoryItemResourceName, ScVmmInventoryItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemResourceName, nameof(inventoryItemResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmInventoryItemInventoryItemsClientDiagnostics.CreateScope("ScVmmInventoryItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scVmmInventoryItemInventoryItemsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemResourceName, data, cancellationToken).ConfigureAwait(false);
                var uri = _scVmmInventoryItemInventoryItemsRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemResourceName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ScVmmArmOperation<ScVmmInventoryItemResource>(Response.FromValue(new ScVmmInventoryItemResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create Or Update InventoryItem.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmInventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="inventoryItemResourceName"> Name of the inventoryItem. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScVmmInventoryItemResource> CreateOrUpdate(WaitUntil waitUntil, string inventoryItemResourceName, ScVmmInventoryItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemResourceName, nameof(inventoryItemResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmInventoryItemInventoryItemsClientDiagnostics.CreateScope("ScVmmInventoryItemCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scVmmInventoryItemInventoryItemsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemResourceName, data, cancellationToken);
                var uri = _scVmmInventoryItemInventoryItemsRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemResourceName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ScVmmArmOperation<ScVmmInventoryItemResource>(Response.FromValue(new ScVmmInventoryItemResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Shows an inventory item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmInventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inventoryItemResourceName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemResourceName"/> is null. </exception>
        public virtual async Task<Response<ScVmmInventoryItemResource>> GetAsync(string inventoryItemResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemResourceName, nameof(inventoryItemResourceName));

            using var scope = _scVmmInventoryItemInventoryItemsClientDiagnostics.CreateScope("ScVmmInventoryItemCollection.Get");
            scope.Start();
            try
            {
                var response = await _scVmmInventoryItemInventoryItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmInventoryItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Shows an inventory item.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmInventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inventoryItemResourceName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemResourceName"/> is null. </exception>
        public virtual Response<ScVmmInventoryItemResource> Get(string inventoryItemResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemResourceName, nameof(inventoryItemResourceName));

            using var scope = _scVmmInventoryItemInventoryItemsClientDiagnostics.CreateScope("ScVmmInventoryItemCollection.Get");
            scope.Start();
            try
            {
                var response = _scVmmInventoryItemInventoryItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmInventoryItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the list of inventoryItems in the given VMMServer.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_ListByVMMServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmInventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScVmmInventoryItemResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScVmmInventoryItemResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scVmmInventoryItemInventoryItemsRestClient.CreateListByVmmServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scVmmInventoryItemInventoryItemsRestClient.CreateListByVmmServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScVmmInventoryItemResource(Client, ScVmmInventoryItemData.DeserializeScVmmInventoryItemData(e)), _scVmmInventoryItemInventoryItemsClientDiagnostics, Pipeline, "ScVmmInventoryItemCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns the list of inventoryItems in the given VMMServer.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_ListByVMMServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmInventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScVmmInventoryItemResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScVmmInventoryItemResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scVmmInventoryItemInventoryItemsRestClient.CreateListByVmmServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scVmmInventoryItemInventoryItemsRestClient.CreateListByVmmServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScVmmInventoryItemResource(Client, ScVmmInventoryItemData.DeserializeScVmmInventoryItemData(e)), _scVmmInventoryItemInventoryItemsClientDiagnostics, Pipeline, "ScVmmInventoryItemCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmInventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inventoryItemResourceName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string inventoryItemResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemResourceName, nameof(inventoryItemResourceName));

            using var scope = _scVmmInventoryItemInventoryItemsClientDiagnostics.CreateScope("ScVmmInventoryItemCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scVmmInventoryItemInventoryItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmInventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inventoryItemResourceName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string inventoryItemResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemResourceName, nameof(inventoryItemResourceName));

            using var scope = _scVmmInventoryItemInventoryItemsClientDiagnostics.CreateScope("ScVmmInventoryItemCollection.Exists");
            scope.Start();
            try
            {
                var response = _scVmmInventoryItemInventoryItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemResourceName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmInventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inventoryItemResourceName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemResourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<ScVmmInventoryItemResource>> GetIfExistsAsync(string inventoryItemResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemResourceName, nameof(inventoryItemResourceName));

            using var scope = _scVmmInventoryItemInventoryItemsClientDiagnostics.CreateScope("ScVmmInventoryItemCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _scVmmInventoryItemInventoryItemsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ScVmmInventoryItemResource>(response.GetRawResponse());
                return Response.FromValue(new ScVmmInventoryItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}/inventoryItems/{inventoryItemResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>InventoryItems_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-07</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ScVmmInventoryItemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="inventoryItemResourceName"> Name of the inventoryItem. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="inventoryItemResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="inventoryItemResourceName"/> is null. </exception>
        public virtual NullableResponse<ScVmmInventoryItemResource> GetIfExists(string inventoryItemResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(inventoryItemResourceName, nameof(inventoryItemResourceName));

            using var scope = _scVmmInventoryItemInventoryItemsClientDiagnostics.CreateScope("ScVmmInventoryItemCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _scVmmInventoryItemInventoryItemsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, inventoryItemResourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ScVmmInventoryItemResource>(response.GetRawResponse());
                return Response.FromValue(new ScVmmInventoryItemResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScVmmInventoryItemResource> IEnumerable<ScVmmInventoryItemResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScVmmInventoryItemResource> IAsyncEnumerable<ScVmmInventoryItemResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
