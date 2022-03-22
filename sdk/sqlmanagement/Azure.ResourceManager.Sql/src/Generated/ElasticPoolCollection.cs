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

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of ElasticPool and their operations over its parent. </summary>
    public partial class ElasticPoolCollection : ArmCollection, IEnumerable<ElasticPoolResource>, IAsyncEnumerable<ElasticPoolResource>
    {
        private readonly ClientDiagnostics _elasticPoolClientDiagnostics;
        private readonly ElasticPoolsRestOperations _elasticPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="ElasticPoolCollection"/> class for mocking. </summary>
        protected ElasticPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ElasticPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ElasticPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _elasticPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ElasticPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ElasticPoolResource.ResourceType, out string elasticPoolApiVersion);
            _elasticPoolRestClient = new ElasticPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, elasticPoolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an elastic pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// Operation Id: ElasticPools_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="parameters"> The elastic pool parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ElasticPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string elasticPoolName, ElasticPoolData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _elasticPoolRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ElasticPoolResource>(new ElasticPoolOperationSource(Client), _elasticPoolClientDiagnostics, Pipeline, _elasticPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an elastic pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// Operation Id: ElasticPools_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="parameters"> The elastic pool parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ElasticPoolResource> CreateOrUpdate(WaitUntil waitUntil, string elasticPoolName, ElasticPoolData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _elasticPoolRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, parameters, cancellationToken);
                var operation = new SqlArmOperation<ElasticPoolResource>(new ElasticPoolOperationSource(Client), _elasticPoolClientDiagnostics, Pipeline, _elasticPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an elastic pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// Operation Id: ElasticPools_Get
        /// </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual async Task<Response<ElasticPoolResource>> GetAsync(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _elasticPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an elastic pool.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// Operation Id: ElasticPools_Get
        /// </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual Response<ElasticPoolResource> Get(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _elasticPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ElasticPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all elastic pools in a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools
        /// Operation Id: ElasticPools_ListByServer
        /// </summary>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ElasticPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ElasticPoolResource> GetAllAsync(int? skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ElasticPoolResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _elasticPoolRestClient.ListByServerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ElasticPoolResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _elasticPoolRestClient.ListByServerNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all elastic pools in a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools
        /// Operation Id: ElasticPools_ListByServer
        /// </summary>
        /// <param name="skip"> The number of elements in the collection to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ElasticPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ElasticPoolResource> GetAll(int? skip = null, CancellationToken cancellationToken = default)
        {
            Page<ElasticPoolResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _elasticPoolRestClient.ListByServer(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ElasticPoolResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _elasticPoolRestClient.ListByServerNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ElasticPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// Operation Id: ElasticPools_Get
        /// </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(elasticPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// Operation Id: ElasticPools_Get
        /// </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(elasticPoolName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// Operation Id: ElasticPools_Get
        /// </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual async Task<Response<ElasticPoolResource>> GetIfExistsAsync(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _elasticPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ElasticPoolResource>(null, response.GetRawResponse());
                return Response.FromValue(new ElasticPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/elasticPools/{elasticPoolName}
        /// Operation Id: ElasticPools_Get
        /// </summary>
        /// <param name="elasticPoolName"> The name of the elastic pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="elasticPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="elasticPoolName"/> is null. </exception>
        public virtual Response<ElasticPoolResource> GetIfExists(string elasticPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(elasticPoolName, nameof(elasticPoolName));

            using var scope = _elasticPoolClientDiagnostics.CreateScope("ElasticPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _elasticPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, elasticPoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ElasticPoolResource>(null, response.GetRawResponse());
                return Response.FromValue(new ElasticPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ElasticPoolResource> IEnumerable<ElasticPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ElasticPoolResource> IAsyncEnumerable<ElasticPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
