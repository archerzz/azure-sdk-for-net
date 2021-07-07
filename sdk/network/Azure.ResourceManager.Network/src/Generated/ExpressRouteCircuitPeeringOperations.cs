// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the operations that can be performed over a specific ExpressRouteCircuitPeering. </summary>
    public partial class ExpressRouteCircuitPeeringOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, ExpressRouteCircuitPeering>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private ExpressRouteCircuitPeeringsRestOperations _restClient { get; }
        private PeerExpressRouteCircuitConnectionsRestOperations _peerExpressRouteCircuitConnectionsRestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitPeeringOperations"/> class for mocking. </summary>
        protected ExpressRouteCircuitPeeringOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCircuitPeeringOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal ExpressRouteCircuitPeeringOperations(OperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ExpressRouteCircuitPeeringsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
            _peerExpressRouteCircuitConnectionsRestClient = new PeerExpressRouteCircuitConnectionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/expressRouteCircuits/peerings";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<ExpressRouteCircuitPeering>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteCircuitPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<ExpressRouteCircuitPeering> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new ExpressRouteCircuitPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async Task<IEnumerable<Location>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public IEnumerable<Location> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes the specified peering from the specified express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified peering from the specified express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified peering from the specified express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ExpressRouteCircuitPeeringsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteCircuitPeeringsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified peering from the specified express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ExpressRouteCircuitPeeringsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new ExpressRouteCircuitPeeringsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Gets the specified Peer Express Route Circuit Connection from the specified express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PeerExpressRouteCircuitConnection>> GetPeerExpressRouteCircuitConnectionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringOperations.GetPeerExpressRouteCircuitConnection");
            scope.Start();
            try
            {
                var response = await _peerExpressRouteCircuitConnectionsRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified Peer Express Route Circuit Connection from the specified express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PeerExpressRouteCircuitConnection> GetPeerExpressRouteCircuitConnection(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringOperations.GetPeerExpressRouteCircuitConnection");
            scope.Start();
            try
            {
                var response = _peerExpressRouteCircuitConnectionsRestClient.Get(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all global reach peer connections associated with a private peering in an express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PeerExpressRouteCircuitConnection" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<PeerExpressRouteCircuitConnection> ListPeerExpressRouteCircuitConnections(CancellationToken cancellationToken = default)
        {
            Page<PeerExpressRouteCircuitConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringOperations.ListPeerExpressRouteCircuitConnections");
                scope.Start();
                try
                {
                    var response = _peerExpressRouteCircuitConnectionsRestClient.List(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PeerExpressRouteCircuitConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringOperations.ListPeerExpressRouteCircuitConnections");
                scope.Start();
                try
                {
                    var response = _peerExpressRouteCircuitConnectionsRestClient.ListNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all global reach peer connections associated with a private peering in an express route circuit. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PeerExpressRouteCircuitConnection" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<PeerExpressRouteCircuitConnection> ListPeerExpressRouteCircuitConnectionsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PeerExpressRouteCircuitConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringOperations.ListPeerExpressRouteCircuitConnections");
                scope.Start();
                try
                {
                    var response = await _peerExpressRouteCircuitConnectionsRestClient.ListAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PeerExpressRouteCircuitConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCircuitPeeringOperations.ListPeerExpressRouteCircuitConnections");
                scope.Start();
                try
                {
                    var response = await _peerExpressRouteCircuitConnectionsRestClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of ExpressRouteCircuitConnections in the ExpressRouteCircuitPeering. </summary>
        /// <returns> An object representing collection of ExpressRouteCircuitConnections and their operations over a ExpressRouteCircuitPeering. </returns>
        public ExpressRouteCircuitConnectionContainer GetExpressRouteCircuitConnections()
        {
            return new ExpressRouteCircuitConnectionContainer(this);
        }
    }
}
