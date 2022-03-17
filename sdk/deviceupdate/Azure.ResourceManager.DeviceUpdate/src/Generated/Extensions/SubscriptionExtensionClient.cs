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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.DeviceUpdate.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    internal partial class SubscriptionExtensionClient : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private DeviceUpdateRestOperations _defaultRestClient;
        private ClientDiagnostics _deviceUpdateAccountAccountsClientDiagnostics;
        private AccountsRestOperations _deviceUpdateAccountAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class for mocking. </summary>
        protected SubscriptionExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DeviceUpdate", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private DeviceUpdateRestOperations DefaultRestClient => _defaultRestClient ??= new DeviceUpdateRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics DeviceUpdateAccountAccountsClientDiagnostics => _deviceUpdateAccountAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DeviceUpdate", DeviceUpdateAccountResource.ResourceType.Namespace, DiagnosticOptions);
        private AccountsRestOperations DeviceUpdateAccountAccountsRestClient => _deviceUpdateAccountAccountsRestClient ??= new AccountsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(DeviceUpdateAccountResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Checks ADU resource name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/checknameavailability
        /// Operation Id: CheckNameAvailability
        /// </summary>
        /// <param name="request"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckNameAvailabilityResponse>> CheckDeviceUpdateNameAvailabilityAsync(CheckNameAvailabilityRequest request, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.CheckDeviceUpdateNameAvailability");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, request, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks ADU resource name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/checknameavailability
        /// Operation Id: CheckNameAvailability
        /// </summary>
        /// <param name="request"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameAvailabilityResponse> CheckDeviceUpdateNameAvailability(CheckNameAvailabilityRequest request, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionExtensionClient.CheckDeviceUpdateNameAvailability");
            scope.Start();
            try
            {
                var response = DefaultRestClient.CheckNameAvailability(Id.SubscriptionId, request, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns list of Accounts.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceUpdateAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeviceUpdateAccountResource> GetDeviceUpdateAccountsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeviceUpdateAccountResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DeviceUpdateAccountAccountsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeviceUpdateAccounts");
                scope.Start();
                try
                {
                    var response = await DeviceUpdateAccountAccountsRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeviceUpdateAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeviceUpdateAccountResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DeviceUpdateAccountAccountsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeviceUpdateAccounts");
                scope.Start();
                try
                {
                    var response = await DeviceUpdateAccountAccountsRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeviceUpdateAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Returns list of Accounts.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DeviceUpdate/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceUpdateAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeviceUpdateAccountResource> GetDeviceUpdateAccounts(CancellationToken cancellationToken = default)
        {
            Page<DeviceUpdateAccountResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DeviceUpdateAccountAccountsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeviceUpdateAccounts");
                scope.Start();
                try
                {
                    var response = DeviceUpdateAccountAccountsRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeviceUpdateAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeviceUpdateAccountResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = DeviceUpdateAccountAccountsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetDeviceUpdateAccounts");
                scope.Start();
                try
                {
                    var response = DeviceUpdateAccountAccountsRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeviceUpdateAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
