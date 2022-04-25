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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="VpnGatewayResource" /> and their operations.
    /// Each <see cref="VpnGatewayResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="VpnGatewayCollection" /> instance call the GetVpnGateways method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class VpnGatewayCollection : ArmCollection, IEnumerable<VpnGatewayResource>, IAsyncEnumerable<VpnGatewayResource>
    {
        private readonly ClientDiagnostics _vpnGatewayClientDiagnostics;
        private readonly VpnGatewaysRestOperations _vpnGatewayRestClient;

        /// <summary> Initializes a new instance of the <see cref="VpnGatewayCollection"/> class for mocking. </summary>
        protected VpnGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VpnGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VpnGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _vpnGatewayClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VpnGatewayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VpnGatewayResource.ResourceType, out string vpnGatewayApiVersion);
            _vpnGatewayRestClient = new VpnGatewaysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, vpnGatewayApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a virtual wan vpn gateway if it doesn&apos;t exist else updates the existing gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}
        /// Operation Id: VpnGateways_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="data"> Parameters supplied to create or Update a virtual wan vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VpnGatewayResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string gatewayName, VpnGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vpnGatewayClientDiagnostics.CreateScope("VpnGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _vpnGatewayRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VpnGatewayResource>(new VpnGatewayOperationSource(Client), _vpnGatewayClientDiagnostics, Pipeline, _vpnGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a virtual wan vpn gateway if it doesn&apos;t exist else updates the existing gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}
        /// Operation Id: VpnGateways_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="data"> Parameters supplied to create or Update a virtual wan vpn gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VpnGatewayResource> CreateOrUpdate(WaitUntil waitUntil, string gatewayName, VpnGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _vpnGatewayClientDiagnostics.CreateScope("VpnGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _vpnGatewayRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, data, cancellationToken);
                var operation = new NetworkArmOperation<VpnGatewayResource>(new VpnGatewayOperationSource(Client), _vpnGatewayClientDiagnostics, Pipeline, _vpnGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a virtual wan vpn gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}
        /// Operation Id: VpnGateways_Get
        /// </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual async Task<Response<VpnGatewayResource>> GetAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _vpnGatewayClientDiagnostics.CreateScope("VpnGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _vpnGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a virtual wan vpn gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}
        /// Operation Id: VpnGateways_Get
        /// </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<VpnGatewayResource> Get(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _vpnGatewayClientDiagnostics.CreateScope("VpnGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _vpnGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the VpnGateways in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways
        /// Operation Id: VpnGateways_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnGatewayResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnGatewayResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vpnGatewayClientDiagnostics.CreateScope("VpnGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnGatewayRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnGatewayResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vpnGatewayClientDiagnostics.CreateScope("VpnGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _vpnGatewayRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all the VpnGateways in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways
        /// Operation Id: VpnGateways_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnGatewayResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VpnGatewayResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _vpnGatewayClientDiagnostics.CreateScope("VpnGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnGatewayRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnGatewayResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _vpnGatewayClientDiagnostics.CreateScope("VpnGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _vpnGatewayRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VpnGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}
        /// Operation Id: VpnGateways_Get
        /// </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _vpnGatewayClientDiagnostics.CreateScope("VpnGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await _vpnGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/vpnGateways/{gatewayName}
        /// Operation Id: VpnGateways_Get
        /// </summary>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _vpnGatewayClientDiagnostics.CreateScope("VpnGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = _vpnGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, gatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VpnGatewayResource> IEnumerable<VpnGatewayResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VpnGatewayResource> IAsyncEnumerable<VpnGatewayResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
