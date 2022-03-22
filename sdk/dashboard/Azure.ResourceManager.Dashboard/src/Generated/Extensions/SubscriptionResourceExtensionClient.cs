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

namespace Azure.ResourceManager.Dashboard
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _grafanaResourceGrafanaClientDiagnostics;
        private GrafanaRestOperations _grafanaResourceGrafanaRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics GrafanaResourceGrafanaClientDiagnostics => _grafanaResourceGrafanaClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Dashboard", GrafanaResource.ResourceType.Namespace, Diagnostics);
        private GrafanaRestOperations GrafanaResourceGrafanaRestClient => _grafanaResourceGrafanaRestClient ??= new GrafanaRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(GrafanaResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all resources of workspaces for Grafana under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Dashboard/grafana
        /// Operation Id: Grafana_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GrafanaResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GrafanaResource> GetGrafanaResourcesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GrafanaResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = GrafanaResourceGrafanaClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetGrafanaResources");
                scope.Start();
                try
                {
                    var response = await GrafanaResourceGrafanaRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GrafanaResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GrafanaResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = GrafanaResourceGrafanaClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetGrafanaResources");
                scope.Start();
                try
                {
                    var response = await GrafanaResourceGrafanaRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GrafanaResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List all resources of workspaces for Grafana under the specified subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Dashboard/grafana
        /// Operation Id: Grafana_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GrafanaResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GrafanaResource> GetGrafanaResources(CancellationToken cancellationToken = default)
        {
            Page<GrafanaResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = GrafanaResourceGrafanaClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetGrafanaResources");
                scope.Start();
                try
                {
                    var response = GrafanaResourceGrafanaRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GrafanaResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GrafanaResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = GrafanaResourceGrafanaClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetGrafanaResources");
                scope.Start();
                try
                {
                    var response = GrafanaResourceGrafanaRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GrafanaResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
