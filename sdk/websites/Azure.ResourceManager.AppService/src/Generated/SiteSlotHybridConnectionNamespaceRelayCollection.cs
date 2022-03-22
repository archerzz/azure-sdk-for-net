// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of SiteSlotHybridConnectionNamespaceRelay and their operations over its parent. </summary>
    public partial class SiteSlotHybridConnectionNamespaceRelayCollection : ArmCollection
    {
        private readonly ClientDiagnostics _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridConnectionNamespaceRelayCollection"/> class for mocking. </summary>
        protected SiteSlotHybridConnectionNamespaceRelayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHybridConnectionNamespaceRelayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteSlotHybridConnectionNamespaceRelayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", SiteSlotHybridConnectionNamespaceRelayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteSlotHybridConnectionNamespaceRelayResource.ResourceType, out string siteSlotHybridConnectionNamespaceRelayWebAppsApiVersion);
            _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotHybridConnectionNamespaceRelayWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates a new Hybrid Connection using a Service Bus relay.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// Operation Id: WebApps_CreateOrUpdateHybridConnectionSlot
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="connectionEnvelope"> The details of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/>, <paramref name="relayName"/> or <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSlotHybridConnectionNamespaceRelayResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string namespaceName, string relayName, HybridConnectionData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));
            Argument.AssertNotNull(connectionEnvelope, nameof(connectionEnvelope));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.CreateOrUpdateHybridConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, connectionEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotHybridConnectionNamespaceRelayResource>(Response.FromValue(new SiteSlotHybridConnectionNamespaceRelayResource(Client, response), response.GetRawResponse()));
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
        /// Description for Creates a new Hybrid Connection using a Service Bus relay.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// Operation Id: WebApps_CreateOrUpdateHybridConnectionSlot
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="connectionEnvelope"> The details of the hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/>, <paramref name="relayName"/> or <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual ArmOperation<SiteSlotHybridConnectionNamespaceRelayResource> CreateOrUpdate(WaitUntil waitUntil, string namespaceName, string relayName, HybridConnectionData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));
            Argument.AssertNotNull(connectionEnvelope, nameof(connectionEnvelope));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.CreateOrUpdateHybridConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, connectionEnvelope, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotHybridConnectionNamespaceRelayResource>(Response.FromValue(new SiteSlotHybridConnectionNamespaceRelayResource(Client, response), response.GetRawResponse()));
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
        /// Description for Retrieves a specific Service Bus Hybrid Connection used by this Web App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// Operation Id: WebApps_GetHybridConnectionSlot
        /// </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotHybridConnectionNamespaceRelayResource>> GetAsync(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.GetHybridConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Retrieves a specific Service Bus Hybrid Connection used by this Web App.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// Operation Id: WebApps_GetHybridConnectionSlot
        /// </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public virtual Response<SiteSlotHybridConnectionNamespaceRelayResource> Get(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.Get");
            scope.Start();
            try
            {
                var response = _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.GetHybridConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// Operation Id: WebApps_GetHybridConnectionSlot
        /// </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(namespaceName, relayName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// Operation Id: WebApps_GetHybridConnectionSlot
        /// </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public virtual Response<bool> Exists(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(namespaceName, relayName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// Operation Id: WebApps_GetHybridConnectionSlot
        /// </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public virtual async Task<Response<SiteSlotHybridConnectionNamespaceRelayResource>> GetIfExistsAsync(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.GetHybridConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotHybridConnectionNamespaceRelayResource>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hybridConnectionNamespaces/{namespaceName}/relays/{relayName}
        /// Operation Id: WebApps_GetHybridConnectionSlot
        /// </summary>
        /// <param name="namespaceName"> The namespace for this hybrid connection. </param>
        /// <param name="relayName"> The relay name for this hybrid connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="relayName"/> is null. </exception>
        public virtual Response<SiteSlotHybridConnectionNamespaceRelayResource> GetIfExists(string namespaceName, string relayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNullOrEmpty(relayName, nameof(relayName));

            using var scope = _siteSlotHybridConnectionNamespaceRelayWebAppsClientDiagnostics.CreateScope("SiteSlotHybridConnectionNamespaceRelayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteSlotHybridConnectionNamespaceRelayWebAppsRestClient.GetHybridConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, namespaceName, relayName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotHybridConnectionNamespaceRelayResource>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotHybridConnectionNamespaceRelayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
