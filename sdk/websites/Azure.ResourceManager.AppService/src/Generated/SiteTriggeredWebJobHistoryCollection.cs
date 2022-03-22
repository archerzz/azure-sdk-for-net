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

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of SiteTriggeredWebJobHistory and their operations over its parent. </summary>
    public partial class SiteTriggeredWebJobHistoryCollection : ArmCollection, IEnumerable<SiteTriggeredWebJobHistoryResource>, IAsyncEnumerable<SiteTriggeredWebJobHistoryResource>
    {
        private readonly ClientDiagnostics _siteTriggeredWebJobHistoryWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteTriggeredWebJobHistoryWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteTriggeredWebJobHistoryCollection"/> class for mocking. </summary>
        protected SiteTriggeredWebJobHistoryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteTriggeredWebJobHistoryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteTriggeredWebJobHistoryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteTriggeredWebJobHistoryWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteTriggeredWebJobHistoryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteTriggeredWebJobHistoryResource.ResourceType, out string siteTriggeredWebJobHistoryWebAppsApiVersion);
            _siteTriggeredWebJobHistoryWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteTriggeredWebJobHistoryWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteTriggeredwebJobResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteTriggeredwebJobResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistorySlot
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<SiteTriggeredWebJobHistoryResource>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistorySlot
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<SiteTriggeredWebJobHistoryResource> Get(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = _siteTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List a triggered web job&apos;s history for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history
        /// Operation Id: WebApps_ListTriggeredWebJobHistorySlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteTriggeredWebJobHistoryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteTriggeredWebJobHistoryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteTriggeredWebJobHistoryResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteTriggeredWebJobHistoryWebAppsRestClient.ListTriggeredWebJobHistorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredWebJobHistoryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteTriggeredWebJobHistoryResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _siteTriggeredWebJobHistoryWebAppsRestClient.ListTriggeredWebJobHistorySlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredWebJobHistoryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for List a triggered web job&apos;s history for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history
        /// Operation Id: WebApps_ListTriggeredWebJobHistorySlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteTriggeredWebJobHistoryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteTriggeredWebJobHistoryResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteTriggeredWebJobHistoryResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteTriggeredWebJobHistoryWebAppsRestClient.ListTriggeredWebJobHistorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredWebJobHistoryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteTriggeredWebJobHistoryResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _siteTriggeredWebJobHistoryWebAppsRestClient.ListTriggeredWebJobHistorySlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteTriggeredWebJobHistoryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistorySlot
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(id, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistorySlot
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> Exists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(id, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistorySlot
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<SiteTriggeredWebJobHistoryResource>> GetIfExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteTriggeredWebJobHistoryResource>(null, response.GetRawResponse());
                return Response.FromValue(new SiteTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistorySlot
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<SiteTriggeredWebJobHistoryResource> GetIfExists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _siteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("SiteTriggeredWebJobHistoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteTriggeredWebJobHistoryResource>(null, response.GetRawResponse());
                return Response.FromValue(new SiteTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteTriggeredWebJobHistoryResource> IEnumerable<SiteTriggeredWebJobHistoryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteTriggeredWebJobHistoryResource> IAsyncEnumerable<SiteTriggeredWebJobHistoryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
