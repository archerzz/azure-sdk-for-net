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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class representing collection of DeviceUpdateAccount and their operations over its parent. </summary>
    public partial class DeviceUpdateAccountCollection : ArmCollection, IEnumerable<DeviceUpdateAccountResource>, IAsyncEnumerable<DeviceUpdateAccountResource>
    {
        private readonly ClientDiagnostics _deviceUpdateAccountAccountsClientDiagnostics;
        private readonly AccountsRestOperations _deviceUpdateAccountAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdateAccountCollection"/> class for mocking. </summary>
        protected DeviceUpdateAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceUpdateAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeviceUpdateAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceUpdateAccountAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceUpdate", DeviceUpdateAccountResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(DeviceUpdateAccountResource.ResourceType, out string deviceUpdateAccountAccountsApiVersion);
            _deviceUpdateAccountAccountsRestClient = new AccountsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, deviceUpdateAccountAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates Account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}
        /// Operation Id: Accounts_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="account"> Account details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="account"/> is null. </exception>
        public virtual async Task<ArmOperation<DeviceUpdateAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string accountName, DeviceUpdateAccountData account, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(account, nameof(account));

            using var scope = _deviceUpdateAccountAccountsClientDiagnostics.CreateScope("DeviceUpdateAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _deviceUpdateAccountAccountsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, account, cancellationToken).ConfigureAwait(false);
                var operation = new DeviceUpdateArmOperation<DeviceUpdateAccountResource>(new DeviceUpdateAccountOperationSource(Client), _deviceUpdateAccountAccountsClientDiagnostics, Pipeline, _deviceUpdateAccountAccountsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, account).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates Account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}
        /// Operation Id: Accounts_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="account"> Account details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="account"/> is null. </exception>
        public virtual ArmOperation<DeviceUpdateAccountResource> CreateOrUpdate(WaitUntil waitUntil, string accountName, DeviceUpdateAccountData account, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(account, nameof(account));

            using var scope = _deviceUpdateAccountAccountsClientDiagnostics.CreateScope("DeviceUpdateAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _deviceUpdateAccountAccountsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, accountName, account, cancellationToken);
                var operation = new DeviceUpdateArmOperation<DeviceUpdateAccountResource>(new DeviceUpdateAccountOperationSource(Client), _deviceUpdateAccountAccountsClientDiagnostics, Pipeline, _deviceUpdateAccountAccountsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, account).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Returns account details for the given account name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<DeviceUpdateAccountResource>> GetAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _deviceUpdateAccountAccountsClientDiagnostics.CreateScope("DeviceUpdateAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _deviceUpdateAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdateAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns account details for the given account name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<DeviceUpdateAccountResource> Get(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _deviceUpdateAccountAccountsClientDiagnostics.CreateScope("DeviceUpdateAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _deviceUpdateAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceUpdateAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns list of Accounts.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts
        /// Operation Id: Accounts_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeviceUpdateAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeviceUpdateAccountResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeviceUpdateAccountResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _deviceUpdateAccountAccountsClientDiagnostics.CreateScope("DeviceUpdateAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deviceUpdateAccountAccountsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
                using var scope = _deviceUpdateAccountAccountsClientDiagnostics.CreateScope("DeviceUpdateAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _deviceUpdateAccountAccountsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts
        /// Operation Id: Accounts_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeviceUpdateAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeviceUpdateAccountResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DeviceUpdateAccountResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _deviceUpdateAccountAccountsClientDiagnostics.CreateScope("DeviceUpdateAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deviceUpdateAccountAccountsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
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
                using var scope = _deviceUpdateAccountAccountsClientDiagnostics.CreateScope("DeviceUpdateAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _deviceUpdateAccountAccountsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
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

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _deviceUpdateAccountAccountsClientDiagnostics.CreateScope("DeviceUpdateAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<bool> Exists(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _deviceUpdateAccountAccountsClientDiagnostics.CreateScope("DeviceUpdateAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(accountName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<DeviceUpdateAccountResource>> GetIfExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _deviceUpdateAccountAccountsClientDiagnostics.CreateScope("DeviceUpdateAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _deviceUpdateAccountAccountsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DeviceUpdateAccountResource>(null, response.GetRawResponse());
                return Response.FromValue(new DeviceUpdateAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DeviceUpdate/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<DeviceUpdateAccountResource> GetIfExists(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _deviceUpdateAccountAccountsClientDiagnostics.CreateScope("DeviceUpdateAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _deviceUpdateAccountAccountsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DeviceUpdateAccountResource>(null, response.GetRawResponse());
                return Response.FromValue(new DeviceUpdateAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeviceUpdateAccountResource> IEnumerable<DeviceUpdateAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeviceUpdateAccountResource> IAsyncEnumerable<DeviceUpdateAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
