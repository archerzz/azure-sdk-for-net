// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualWAN and their operations over a ResourceGroup. </summary>
    public partial class VirtualWANContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, VirtualWAN, VirtualWANData>
    {
        /// <summary> Initializes a new instance of the <see cref="VirtualWANContainer"/> class for mocking. </summary>
        protected VirtualWANContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualWANContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualWANContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private VirtualWansRestOperations _restClient => new VirtualWansRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="wANParameters"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> or <paramref name="wANParameters"/> is null. </exception>
        public virtual Response<VirtualWAN> CreateOrUpdate(string virtualWANName, VirtualWANData wANParameters, CancellationToken cancellationToken = default)
        {
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (wANParameters == null)
            {
                throw new ArgumentNullException(nameof(wANParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(virtualWANName, wANParameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="wANParameters"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> or <paramref name="wANParameters"/> is null. </exception>
        public async virtual Task<Response<VirtualWAN>> CreateOrUpdateAsync(string virtualWANName, VirtualWANData wANParameters, CancellationToken cancellationToken = default)
        {
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (wANParameters == null)
            {
                throw new ArgumentNullException(nameof(wANParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(virtualWANName, wANParameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="wANParameters"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> or <paramref name="wANParameters"/> is null. </exception>
        public virtual VirtualWansCreateOrUpdateOperation StartCreateOrUpdate(string virtualWANName, VirtualWANData wANParameters, CancellationToken cancellationToken = default)
        {
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (wANParameters == null)
            {
                throw new ArgumentNullException(nameof(wANParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, virtualWANName, wANParameters, cancellationToken);
                return new VirtualWansCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, virtualWANName, wANParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VirtualWAN resource if it doesn&apos;t exist else updates the existing VirtualWAN. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="wANParameters"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWANName"/> or <paramref name="wANParameters"/> is null. </exception>
        public async virtual Task<VirtualWansCreateOrUpdateOperation> StartCreateOrUpdateAsync(string virtualWANName, VirtualWANData wANParameters, CancellationToken cancellationToken = default)
        {
            if (virtualWANName == null)
            {
                throw new ArgumentNullException(nameof(virtualWANName));
            }
            if (wANParameters == null)
            {
                throw new ArgumentNullException(nameof(wANParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, virtualWANName, wANParameters, cancellationToken).ConfigureAwait(false);
                return new VirtualWansCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, virtualWANName, wANParameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualWAN> Get(string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.Get");
            scope.Start();
            try
            {
                if (virtualWANName == null)
                {
                    throw new ArgumentNullException(nameof(virtualWANName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, virtualWANName, cancellationToken: cancellationToken);
                return Response.FromValue(new VirtualWAN(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualWAN>> GetAsync(string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.Get");
            scope.Start();
            try
            {
                if (virtualWANName == null)
                {
                    throw new ArgumentNullException(nameof(virtualWANName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, virtualWANName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualWAN(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual VirtualWAN TryGet(string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.TryGet");
            scope.Start();
            try
            {
                if (virtualWANName == null)
                {
                    throw new ArgumentNullException(nameof(virtualWANName));
                }

                return Get(virtualWANName, cancellationToken: cancellationToken).Value;
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
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<VirtualWAN> TryGetAsync(string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.TryGet");
            scope.Start();
            try
            {
                if (virtualWANName == null)
                {
                    throw new ArgumentNullException(nameof(virtualWANName));
                }

                return await GetAsync(virtualWANName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.DoesExist");
            scope.Start();
            try
            {
                if (virtualWANName == null)
                {
                    throw new ArgumentNullException(nameof(virtualWANName));
                }

                return TryGet(virtualWANName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualWANName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string virtualWANName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.DoesExist");
            scope.Start();
            try
            {
                if (virtualWANName == null)
                {
                    throw new ArgumentNullException(nameof(virtualWANName));
                }

                return await TryGetAsync(virtualWANName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all the VirtualWANs in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualWAN" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<VirtualWAN> List(CancellationToken cancellationToken = default)
        {
            Page<VirtualWAN> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWAN(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualWAN> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWAN(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all the VirtualWANs in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualWAN" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<VirtualWAN> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualWAN>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWAN(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualWAN>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWAN(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of VirtualWAN for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualWANOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of VirtualWAN for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualWANOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, VirtualWAN, VirtualWANData> Construct() { }
    }
}
