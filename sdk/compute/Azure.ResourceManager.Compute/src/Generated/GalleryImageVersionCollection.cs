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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of GalleryImageVersion and their operations over its parent. </summary>
    public partial class GalleryImageVersionCollection : ArmCollection, IEnumerable<GalleryImageVersionResource>, IAsyncEnumerable<GalleryImageVersionResource>
    {
        private readonly ClientDiagnostics _galleryImageVersionClientDiagnostics;
        private readonly GalleryImageVersionsRestOperations _galleryImageVersionRestClient;

        /// <summary> Initializes a new instance of the <see cref="GalleryImageVersionCollection"/> class for mocking. </summary>
        protected GalleryImageVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GalleryImageVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GalleryImageVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _galleryImageVersionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", GalleryImageVersionResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(GalleryImageVersionResource.ResourceType, out string galleryImageVersionApiVersion);
            _galleryImageVersionRestClient = new GalleryImageVersionsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, galleryImageVersionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != GalleryImageResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, GalleryImageResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a gallery image version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}
        /// Operation Id: GalleryImageVersions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryImageVersion"> Parameters supplied to the create or update gallery image version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> or <paramref name="galleryImageVersion"/> is null. </exception>
        public virtual async Task<ArmOperation<GalleryImageVersionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string galleryImageVersionName, GalleryImageVersionData galleryImageVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));
            Argument.AssertNotNull(galleryImageVersion, nameof(galleryImageVersion));

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _galleryImageVersionRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, galleryImageVersion, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<GalleryImageVersionResource>(new GalleryImageVersionOperationSource(Client), _galleryImageVersionClientDiagnostics, Pipeline, _galleryImageVersionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, galleryImageVersion).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a gallery image version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}
        /// Operation Id: GalleryImageVersions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;. </param>
        /// <param name="galleryImageVersion"> Parameters supplied to the create or update gallery image version operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> or <paramref name="galleryImageVersion"/> is null. </exception>
        public virtual ArmOperation<GalleryImageVersionResource> CreateOrUpdate(WaitUntil waitUntil, string galleryImageVersionName, GalleryImageVersionData galleryImageVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));
            Argument.AssertNotNull(galleryImageVersion, nameof(galleryImageVersion));

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _galleryImageVersionRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, galleryImageVersion, cancellationToken);
                var operation = new ComputeArmOperation<GalleryImageVersionResource>(new GalleryImageVersionOperationSource(Client), _galleryImageVersionClientDiagnostics, Pipeline, _galleryImageVersionRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, galleryImageVersion).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves information about a gallery image version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}
        /// Operation Id: GalleryImageVersions_Get
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual async Task<Response<GalleryImageVersionResource>> GetAsync(string galleryImageVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _galleryImageVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about a gallery image version.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}
        /// Operation Id: GalleryImageVersions_Get
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual Response<GalleryImageVersionResource> Get(string galleryImageVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _galleryImageVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List gallery image versions in a gallery image definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions
        /// Operation Id: GalleryImageVersions_ListByGalleryImage
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryImageVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GalleryImageVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GalleryImageVersionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryImageVersionRestClient.ListByGalleryImageAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImageVersionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GalleryImageVersionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _galleryImageVersionRestClient.ListByGalleryImageNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImageVersionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List gallery image versions in a gallery image definition.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions
        /// Operation Id: GalleryImageVersions_ListByGalleryImage
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryImageVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GalleryImageVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GalleryImageVersionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryImageVersionRestClient.ListByGalleryImage(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImageVersionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GalleryImageVersionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _galleryImageVersionRestClient.ListByGalleryImageNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImageVersionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}
        /// Operation Id: GalleryImageVersions_Get
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string galleryImageVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(galleryImageVersionName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}
        /// Operation Id: GalleryImageVersions_Get
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual Response<bool> Exists(string galleryImageVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(galleryImageVersionName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}
        /// Operation Id: GalleryImageVersions_Get
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual async Task<Response<GalleryImageVersionResource>> GetIfExistsAsync(string galleryImageVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _galleryImageVersionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<GalleryImageVersionResource>(null, response.GetRawResponse());
                return Response.FromValue(new GalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}
        /// Operation Id: GalleryImageVersions_Get
        /// </summary>
        /// <param name="galleryImageVersionName"> The name of the gallery image version to be retrieved. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="galleryImageVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageVersionName"/> is null. </exception>
        public virtual Response<GalleryImageVersionResource> GetIfExists(string galleryImageVersionName, ReplicationStatusTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(galleryImageVersionName, nameof(galleryImageVersionName));

            using var scope = _galleryImageVersionClientDiagnostics.CreateScope("GalleryImageVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _galleryImageVersionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, galleryImageVersionName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<GalleryImageVersionResource>(null, response.GetRawResponse());
                return Response.FromValue(new GalleryImageVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GalleryImageVersionResource> IEnumerable<GalleryImageVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GalleryImageVersionResource> IAsyncEnumerable<GalleryImageVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
