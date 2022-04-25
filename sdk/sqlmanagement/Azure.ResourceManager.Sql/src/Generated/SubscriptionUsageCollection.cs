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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionUsageResource" /> and their operations.
    /// Each <see cref="SubscriptionUsageResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SubscriptionUsageCollection" /> instance call the GetSubscriptionUsages method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SubscriptionUsageCollection : ArmCollection, IEnumerable<SubscriptionUsageResource>, IAsyncEnumerable<SubscriptionUsageResource>
    {
        private readonly ClientDiagnostics _subscriptionUsageClientDiagnostics;
        private readonly SubscriptionUsagesRestOperations _subscriptionUsageRestClient;
        private readonly string _locationName;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionUsageCollection"/> class for mocking. </summary>
        protected SubscriptionUsageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionUsageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="locationName"> The name of the region where the resource is located. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        internal SubscriptionUsageCollection(ArmClient client, ResourceIdentifier id, string locationName) : base(client, id)
        {
            _locationName = locationName;
            _subscriptionUsageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SubscriptionUsageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionUsageResource.ResourceType, out string subscriptionUsageApiVersion);
            _subscriptionUsageRestClient = new SubscriptionUsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionUsageApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a subscription usage metric.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}
        /// Operation Id: SubscriptionUsages_Get
        /// </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="usageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public virtual async Task<Response<SubscriptionUsageResource>> GetAsync(string usageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(usageName, nameof(usageName));

            using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionUsageRestClient.GetAsync(Id.SubscriptionId, _locationName, usageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionUsageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a subscription usage metric.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}
        /// Operation Id: SubscriptionUsages_Get
        /// </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="usageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public virtual Response<SubscriptionUsageResource> Get(string usageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(usageName, nameof(usageName));

            using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionUsageRestClient.Get(Id.SubscriptionId, _locationName, usageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionUsageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all subscription usage metrics in a given location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages
        /// Operation Id: SubscriptionUsages_ListByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionUsageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionUsageResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SubscriptionUsageResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionUsageRestClient.ListByLocationAsync(Id.SubscriptionId, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionUsageResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubscriptionUsageResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionUsageRestClient.ListByLocationNextPageAsync(nextLink, Id.SubscriptionId, _locationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionUsageResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all subscription usage metrics in a given location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages
        /// Operation Id: SubscriptionUsages_ListByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionUsageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionUsageResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SubscriptionUsageResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionUsageRestClient.ListByLocation(Id.SubscriptionId, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionUsageResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubscriptionUsageResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionUsageRestClient.ListByLocationNextPage(nextLink, Id.SubscriptionId, _locationName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionUsageResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}
        /// Operation Id: SubscriptionUsages_Get
        /// </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="usageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string usageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(usageName, nameof(usageName));

            using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionUsageRestClient.GetAsync(Id.SubscriptionId, _locationName, usageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/usages/{usageName}
        /// Operation Id: SubscriptionUsages_Get
        /// </summary>
        /// <param name="usageName"> Name of usage metric to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="usageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="usageName"/> is null. </exception>
        public virtual Response<bool> Exists(string usageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(usageName, nameof(usageName));

            using var scope = _subscriptionUsageClientDiagnostics.CreateScope("SubscriptionUsageCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionUsageRestClient.Get(Id.SubscriptionId, _locationName, usageName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionUsageResource> IEnumerable<SubscriptionUsageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionUsageResource> IAsyncEnumerable<SubscriptionUsageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
