// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ExpressRouteConnection and their operations over a ExpressRouteGateway. </summary>
    public partial class ExpressRouteConnectionContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, ExpressRouteConnection, ExpressRouteConnectionData>
    {
        /// <summary> Initializes a new instance of the <see cref="ExpressRouteConnectionContainer"/> class for mocking. </summary>
        protected ExpressRouteConnectionContainer()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteConnectionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ExpressRouteConnectionContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private ExpressRouteConnectionsRestOperations _restClient => new ExpressRouteConnectionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ExpressRouteGatewayOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates a connection between an ExpressRoute gateway and an ExpressRoute circuit. </summary>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="putExpressRouteConnectionParameters"> Parameters required in an ExpressRouteConnection PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="putExpressRouteConnectionParameters"/> is null. </exception>
        public virtual Response<ExpressRouteConnection> CreateOrUpdate(string connectionName, ExpressRouteConnectionData putExpressRouteConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (putExpressRouteConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(connectionName, putExpressRouteConnectionParameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a connection between an ExpressRoute gateway and an ExpressRoute circuit. </summary>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="putExpressRouteConnectionParameters"> Parameters required in an ExpressRouteConnection PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="putExpressRouteConnectionParameters"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteConnection>> CreateOrUpdateAsync(string connectionName, ExpressRouteConnectionData putExpressRouteConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (putExpressRouteConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(connectionName, putExpressRouteConnectionParameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a connection between an ExpressRoute gateway and an ExpressRoute circuit. </summary>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="putExpressRouteConnectionParameters"> Parameters required in an ExpressRouteConnection PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="putExpressRouteConnectionParameters"/> is null. </exception>
        public virtual ExpressRouteConnectionsCreateOrUpdateOperation StartCreateOrUpdate(string connectionName, ExpressRouteConnectionData putExpressRouteConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (putExpressRouteConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, connectionName, putExpressRouteConnectionParameters, cancellationToken);
                return new ExpressRouteConnectionsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, connectionName, putExpressRouteConnectionParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a connection between an ExpressRoute gateway and an ExpressRoute circuit. </summary>
        /// <param name="connectionName"> The name of the connection subresource. </param>
        /// <param name="putExpressRouteConnectionParameters"> Parameters required in an ExpressRouteConnection PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="putExpressRouteConnectionParameters"/> is null. </exception>
        public async virtual Task<ExpressRouteConnectionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string connectionName, ExpressRouteConnectionData putExpressRouteConnectionParameters, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (putExpressRouteConnectionParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteConnectionParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, connectionName, putExpressRouteConnectionParameters, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteConnectionsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, connectionName, putExpressRouteConnectionParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ExpressRouteConnection> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.Get");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                return Response.FromValue(new ExpressRouteConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ExpressRouteConnection>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.Get");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual ExpressRouteConnection TryGet(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.TryGet");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                return Get(connectionName, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<ExpressRouteConnection> TryGetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.TryGet");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                return await GetAsync(connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.DoesExist");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                return TryGet(connectionName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="connectionName"> The name of the ExpressRoute connection. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.DoesExist");
            scope.Start();
            try
            {
                if (connectionName == null)
                {
                    throw new ArgumentNullException(nameof(connectionName));
                }

                return await TryGetAsync(connectionName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of ExpressRouteConnection for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ExpressRouteConnectionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of ExpressRouteConnection for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ExpressRouteConnectionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists ExpressRouteConnections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<ExpressRouteConnection>>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.List");
            scope.Start();
            try
            {
                var response = await _restClient.ListAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(data => new ExpressRouteConnection(Parent, data)).ToArray() as IReadOnlyList<ExpressRouteConnection>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists ExpressRouteConnections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<ExpressRouteConnection>> List(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteConnectionContainer.List");
            scope.Start();
            try
            {
                var response = _restClient.List(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(data => new ExpressRouteConnection(Parent, data)).ToArray() as IReadOnlyList<ExpressRouteConnection>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, ExpressRouteConnection, ExpressRouteConnectionData> Construct() { }
    }
}
