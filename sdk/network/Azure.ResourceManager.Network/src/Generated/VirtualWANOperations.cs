// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the operations that can be performed over a specific VirtualWAN. </summary>
    public partial class VirtualWANOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, VirtualWAN>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private VirtualWansRestOperations _restClient { get; }
        private VpnSitesConfigurationRestOperations _vpnSitesConfigurationRestClient { get; }
        private SupportedSecurityProvidersRestOperations _supportedSecurityProvidersRestClient { get; }
        private VpnServerConfigurationsAssociatedWithVirtualWanRestOperations _vpnServerConfigurationsAssociatedWithVirtualWanRestClient { get; }
        private VirtualWanVpnServerConfigurationVpnProfilesRestOperations _virtualWanVpnServerConfigurationVpnProfilesRestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="VirtualWANOperations"/> class for mocking. </summary>
        protected VirtualWANOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualWANOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal VirtualWANOperations(OperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new VirtualWansRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
            _vpnSitesConfigurationRestClient = new VpnSitesConfigurationRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
            _supportedSecurityProvidersRestClient = new SupportedSecurityProvidersRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
            _vpnServerConfigurationsAssociatedWithVirtualWanRestClient = new VpnServerConfigurationsAssociatedWithVirtualWanRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
            _virtualWanVpnServerConfigurationVpnProfilesRestClient = new VirtualWanVpnServerConfigurationVpnProfilesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/virtualWans";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<VirtualWAN>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualWAN(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<VirtualWAN> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new VirtualWAN(this, response.Value), response.GetRawResponse());
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

        /// <summary> Deletes a VirtualWAN. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANOperations.Delete");
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

        /// <summary> Deletes a VirtualWAN. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANOperations.Delete");
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

        /// <summary> Deletes a VirtualWAN. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<VirtualWansDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new VirtualWansDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VirtualWAN. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public VirtualWansDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new VirtualWansDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Updates a VirtualWAN tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualWANData>> UpdateTagsAsync(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANOperations.UpdateTags");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, tags, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a VirtualWAN tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualWANData> UpdateTags(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANOperations.UpdateTags");
            scope.Start();
            try
            {
                var response = _restClient.UpdateTags(Id.ResourceGroupName, Id.Name, tags, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gives the supported security providers for the virtual wan. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualWanSecurityProviders>> ListSupportedSecurityProviderAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANOperations.ListSupportedSecurityProvider");
            scope.Start();
            try
            {
                var response = await _supportedSecurityProvidersRestClient.ListAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gives the supported security providers for the virtual wan. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualWanSecurityProviders> ListSupportedSecurityProvider(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualWANOperations.ListSupportedSecurityProvider");
            scope.Start();
            try
            {
                var response = _supportedSecurityProvidersRestClient.List(Id.ResourceGroupName, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
