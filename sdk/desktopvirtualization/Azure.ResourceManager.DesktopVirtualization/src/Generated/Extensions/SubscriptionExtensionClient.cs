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

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    internal partial class SubscriptionExtensionClient : ArmResource
    {
        private ClientDiagnostics _virtualWorkspaceWorkspacesClientDiagnostics;
        private WorkspacesRestOperations _virtualWorkspaceWorkspacesRestClient;
        private ClientDiagnostics _scalingPlanClientDiagnostics;
        private ScalingPlansRestOperations _scalingPlanRestClient;
        private ClientDiagnostics _virtualApplicationGroupApplicationGroupsClientDiagnostics;
        private ApplicationGroupsRestOperations _virtualApplicationGroupApplicationGroupsRestClient;
        private ClientDiagnostics _hostPoolClientDiagnostics;
        private HostPoolsRestOperations _hostPoolRestClient;

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

        private ClientDiagnostics VirtualWorkspaceWorkspacesClientDiagnostics => _virtualWorkspaceWorkspacesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", VirtualWorkspaceResource.ResourceType.Namespace, DiagnosticOptions);
        private WorkspacesRestOperations VirtualWorkspaceWorkspacesRestClient => _virtualWorkspaceWorkspacesRestClient ??= new WorkspacesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(VirtualWorkspaceResource.ResourceType));
        private ClientDiagnostics ScalingPlanClientDiagnostics => _scalingPlanClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", ScalingPlanResource.ResourceType.Namespace, DiagnosticOptions);
        private ScalingPlansRestOperations ScalingPlanRestClient => _scalingPlanRestClient ??= new ScalingPlansRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(ScalingPlanResource.ResourceType));
        private ClientDiagnostics VirtualApplicationGroupApplicationGroupsClientDiagnostics => _virtualApplicationGroupApplicationGroupsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", VirtualApplicationGroupResource.ResourceType.Namespace, DiagnosticOptions);
        private ApplicationGroupsRestOperations VirtualApplicationGroupApplicationGroupsRestClient => _virtualApplicationGroupApplicationGroupsRestClient ??= new ApplicationGroupsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(VirtualApplicationGroupResource.ResourceType));
        private ClientDiagnostics HostPoolClientDiagnostics => _hostPoolClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", HostPoolResource.ResourceType.Namespace, DiagnosticOptions);
        private HostPoolsRestOperations HostPoolRestClient => _hostPoolRestClient ??= new HostPoolsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(HostPoolResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List workspaces in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/workspaces
        /// Operation Id: Workspaces_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualWorkspaceResource> GetVirtualWorkspacesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualWorkspaceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VirtualWorkspaceWorkspacesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualWorkspaces");
                scope.Start();
                try
                {
                    var response = await VirtualWorkspaceWorkspacesRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWorkspaceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualWorkspaceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VirtualWorkspaceWorkspacesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualWorkspaces");
                scope.Start();
                try
                {
                    var response = await VirtualWorkspaceWorkspacesRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWorkspaceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List workspaces in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/workspaces
        /// Operation Id: Workspaces_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualWorkspaceResource> GetVirtualWorkspaces(CancellationToken cancellationToken = default)
        {
            Page<VirtualWorkspaceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VirtualWorkspaceWorkspacesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualWorkspaces");
                scope.Start();
                try
                {
                    var response = VirtualWorkspaceWorkspacesRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWorkspaceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualWorkspaceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VirtualWorkspaceWorkspacesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualWorkspaces");
                scope.Start();
                try
                {
                    var response = VirtualWorkspaceWorkspacesRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualWorkspaceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List scaling plans in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/scalingPlans
        /// Operation Id: ScalingPlans_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScalingPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScalingPlanResource> GetScalingPlansAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ScalingPlanResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ScalingPlanClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetScalingPlans");
                scope.Start();
                try
                {
                    var response = await ScalingPlanRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ScalingPlanResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ScalingPlanResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ScalingPlanClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetScalingPlans");
                scope.Start();
                try
                {
                    var response = await ScalingPlanRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ScalingPlanResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List scaling plans in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/scalingPlans
        /// Operation Id: ScalingPlans_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScalingPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScalingPlanResource> GetScalingPlans(CancellationToken cancellationToken = default)
        {
            Page<ScalingPlanResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ScalingPlanClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetScalingPlans");
                scope.Start();
                try
                {
                    var response = ScalingPlanRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ScalingPlanResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ScalingPlanResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ScalingPlanClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetScalingPlans");
                scope.Start();
                try
                {
                    var response = ScalingPlanRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ScalingPlanResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List applicationGroups in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/applicationGroups
        /// Operation Id: ApplicationGroups_ListBySubscription
        /// </summary>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are applicationGroupType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualApplicationGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualApplicationGroupResource> GetVirtualApplicationGroupsAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualApplicationGroupResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VirtualApplicationGroupApplicationGroupsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualApplicationGroups");
                scope.Start();
                try
                {
                    var response = await VirtualApplicationGroupApplicationGroupsRestClient.ListBySubscriptionAsync(Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualApplicationGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualApplicationGroupResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VirtualApplicationGroupApplicationGroupsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualApplicationGroups");
                scope.Start();
                try
                {
                    var response = await VirtualApplicationGroupApplicationGroupsRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualApplicationGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List applicationGroups in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/applicationGroups
        /// Operation Id: ApplicationGroups_ListBySubscription
        /// </summary>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are applicationGroupType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualApplicationGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualApplicationGroupResource> GetVirtualApplicationGroups(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<VirtualApplicationGroupResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VirtualApplicationGroupApplicationGroupsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualApplicationGroups");
                scope.Start();
                try
                {
                    var response = VirtualApplicationGroupApplicationGroupsRestClient.ListBySubscription(Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualApplicationGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualApplicationGroupResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VirtualApplicationGroupApplicationGroupsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualApplicationGroups");
                scope.Start();
                try
                {
                    var response = VirtualApplicationGroupApplicationGroupsRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualApplicationGroupResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List hostPools in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/hostPools
        /// Operation Id: HostPools_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HostPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HostPoolResource> GetHostPoolsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<HostPoolResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = HostPoolClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetHostPools");
                scope.Start();
                try
                {
                    var response = await HostPoolRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HostPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<HostPoolResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = HostPoolClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetHostPools");
                scope.Start();
                try
                {
                    var response = await HostPoolRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new HostPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List hostPools in subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DesktopVirtualization/hostPools
        /// Operation Id: HostPools_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HostPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HostPoolResource> GetHostPools(CancellationToken cancellationToken = default)
        {
            Page<HostPoolResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = HostPoolClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetHostPools");
                scope.Start();
                try
                {
                    var response = HostPoolRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HostPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<HostPoolResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = HostPoolClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetHostPools");
                scope.Start();
                try
                {
                    var response = HostPoolRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new HostPoolResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
