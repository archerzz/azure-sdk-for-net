// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.InformaticaDataManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="InformaticaOrganizationResource"/> and their operations.
    /// Each <see cref="InformaticaOrganizationResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="InformaticaOrganizationCollection"/> instance call the GetInformaticaOrganizations method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class InformaticaOrganizationCollection : ArmCollection, IEnumerable<InformaticaOrganizationResource>, IAsyncEnumerable<InformaticaOrganizationResource>
    {
        private readonly ClientDiagnostics _informaticaOrganizationOrganizationsClientDiagnostics;
        private readonly OrganizationsRestOperations _informaticaOrganizationOrganizationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="InformaticaOrganizationCollection"/> class for mocking. </summary>
        protected InformaticaOrganizationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="InformaticaOrganizationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal InformaticaOrganizationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _informaticaOrganizationOrganizationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.InformaticaDataManagement", InformaticaOrganizationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(InformaticaOrganizationResource.ResourceType, out string informaticaOrganizationOrganizationsApiVersion);
            _informaticaOrganizationOrganizationsRestClient = new OrganizationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, informaticaOrganizationOrganizationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a InformaticaOrganizationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Informatica.DataManagement/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_createOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InformaticaOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="organizationName"> Name of the Organizations resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<InformaticaOrganizationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string organizationName, InformaticaOrganizationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(organizationName, nameof(organizationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _informaticaOrganizationOrganizationsClientDiagnostics.CreateScope("InformaticaOrganizationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _informaticaOrganizationOrganizationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, organizationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new InformaticaDataManagementArmOperation<InformaticaOrganizationResource>(new InformaticaOrganizationOperationSource(Client), _informaticaOrganizationOrganizationsClientDiagnostics, Pipeline, _informaticaOrganizationOrganizationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, organizationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a InformaticaOrganizationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Informatica.DataManagement/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_createOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InformaticaOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="organizationName"> Name of the Organizations resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<InformaticaOrganizationResource> CreateOrUpdate(WaitUntil waitUntil, string organizationName, InformaticaOrganizationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(organizationName, nameof(organizationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _informaticaOrganizationOrganizationsClientDiagnostics.CreateScope("InformaticaOrganizationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _informaticaOrganizationOrganizationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, organizationName, data, cancellationToken);
                var operation = new InformaticaDataManagementArmOperation<InformaticaOrganizationResource>(new InformaticaOrganizationOperationSource(Client), _informaticaOrganizationOrganizationsClientDiagnostics, Pipeline, _informaticaOrganizationOrganizationsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, organizationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a InformaticaOrganizationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Informatica.DataManagement/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InformaticaOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="organizationName"> Name of the Organizations resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> is null. </exception>
        public virtual async Task<Response<InformaticaOrganizationResource>> GetAsync(string organizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(organizationName, nameof(organizationName));

            using var scope = _informaticaOrganizationOrganizationsClientDiagnostics.CreateScope("InformaticaOrganizationCollection.Get");
            scope.Start();
            try
            {
                var response = await _informaticaOrganizationOrganizationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, organizationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InformaticaOrganizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a InformaticaOrganizationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Informatica.DataManagement/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InformaticaOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="organizationName"> Name of the Organizations resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> is null. </exception>
        public virtual Response<InformaticaOrganizationResource> Get(string organizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(organizationName, nameof(organizationName));

            using var scope = _informaticaOrganizationOrganizationsClientDiagnostics.CreateScope("InformaticaOrganizationCollection.Get");
            scope.Start();
            try
            {
                var response = _informaticaOrganizationOrganizationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, organizationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new InformaticaOrganizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List InformaticaOrganizationResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Informatica.DataManagement/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_listByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InformaticaOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="InformaticaOrganizationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<InformaticaOrganizationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _informaticaOrganizationOrganizationsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _informaticaOrganizationOrganizationsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new InformaticaOrganizationResource(Client, InformaticaOrganizationData.DeserializeInformaticaOrganizationData(e)), _informaticaOrganizationOrganizationsClientDiagnostics, Pipeline, "InformaticaOrganizationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List InformaticaOrganizationResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Informatica.DataManagement/organizations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_listByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InformaticaOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="InformaticaOrganizationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<InformaticaOrganizationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _informaticaOrganizationOrganizationsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _informaticaOrganizationOrganizationsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new InformaticaOrganizationResource(Client, InformaticaOrganizationData.DeserializeInformaticaOrganizationData(e)), _informaticaOrganizationOrganizationsClientDiagnostics, Pipeline, "InformaticaOrganizationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Informatica.DataManagement/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InformaticaOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="organizationName"> Name of the Organizations resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string organizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(organizationName, nameof(organizationName));

            using var scope = _informaticaOrganizationOrganizationsClientDiagnostics.CreateScope("InformaticaOrganizationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _informaticaOrganizationOrganizationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, organizationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Informatica.DataManagement/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InformaticaOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="organizationName"> Name of the Organizations resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> is null. </exception>
        public virtual Response<bool> Exists(string organizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(organizationName, nameof(organizationName));

            using var scope = _informaticaOrganizationOrganizationsClientDiagnostics.CreateScope("InformaticaOrganizationCollection.Exists");
            scope.Start();
            try
            {
                var response = _informaticaOrganizationOrganizationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, organizationName, cancellationToken: cancellationToken);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Informatica.DataManagement/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InformaticaOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="organizationName"> Name of the Organizations resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> is null. </exception>
        public virtual async Task<NullableResponse<InformaticaOrganizationResource>> GetIfExistsAsync(string organizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(organizationName, nameof(organizationName));

            using var scope = _informaticaOrganizationOrganizationsClientDiagnostics.CreateScope("InformaticaOrganizationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _informaticaOrganizationOrganizationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, organizationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<InformaticaOrganizationResource>(response.GetRawResponse());
                return Response.FromValue(new InformaticaOrganizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Informatica.DataManagement/organizations/{organizationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Organizations_get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-08</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="InformaticaOrganizationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="organizationName"> Name of the Organizations resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="organizationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="organizationName"/> is null. </exception>
        public virtual NullableResponse<InformaticaOrganizationResource> GetIfExists(string organizationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(organizationName, nameof(organizationName));

            using var scope = _informaticaOrganizationOrganizationsClientDiagnostics.CreateScope("InformaticaOrganizationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _informaticaOrganizationOrganizationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, organizationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<InformaticaOrganizationResource>(response.GetRawResponse());
                return Response.FromValue(new InformaticaOrganizationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<InformaticaOrganizationResource> IEnumerable<InformaticaOrganizationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<InformaticaOrganizationResource> IAsyncEnumerable<InformaticaOrganizationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
