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

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of Disk and their operations over its parent. </summary>
    public partial class DiskCollection : ArmCollection, IEnumerable<DiskResource>, IAsyncEnumerable<DiskResource>
    {
        private readonly ClientDiagnostics _diskClientDiagnostics;
        private readonly DisksRestOperations _diskRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiskCollection"/> class for mocking. </summary>
        protected DiskCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiskCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DiskCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _diskClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", DiskResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DiskResource.ResourceType, out string diskApiVersion);
            _diskRestClient = new DisksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, diskApiVersion);
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
        /// Creates or updates a disk.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}
        /// Operation Id: Disks_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can&apos;t be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="disk"> Disk object supplied in the body of the Put disk operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> or <paramref name="disk"/> is null. </exception>
        public virtual async Task<ArmOperation<DiskResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string diskName, DiskData disk, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));
            Argument.AssertNotNull(disk, nameof(disk));

            using var scope = _diskClientDiagnostics.CreateScope("DiskCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _diskRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, diskName, disk, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<DiskResource>(new DiskOperationSource(Client), _diskClientDiagnostics, Pipeline, _diskRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskName, disk).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a disk.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}
        /// Operation Id: Disks_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can&apos;t be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="disk"> Disk object supplied in the body of the Put disk operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> or <paramref name="disk"/> is null. </exception>
        public virtual ArmOperation<DiskResource> CreateOrUpdate(WaitUntil waitUntil, string diskName, DiskData disk, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));
            Argument.AssertNotNull(disk, nameof(disk));

            using var scope = _diskClientDiagnostics.CreateScope("DiskCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _diskRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, diskName, disk, cancellationToken);
                var operation = new ComputeArmOperation<DiskResource>(new DiskOperationSource(Client), _diskClientDiagnostics, Pipeline, _diskRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, diskName, disk).Request, response, OperationFinalStateVia.Location);
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
        /// Gets information about a disk.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}
        /// Operation Id: Disks_Get
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can&apos;t be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        public virtual async Task<Response<DiskResource>> GetAsync(string diskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));

            using var scope = _diskClientDiagnostics.CreateScope("DiskCollection.Get");
            scope.Start();
            try
            {
                var response = await _diskRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a disk.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}
        /// Operation Id: Disks_Get
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can&apos;t be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        public virtual Response<DiskResource> Get(string diskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));

            using var scope = _diskClientDiagnostics.CreateScope("DiskCollection.Get");
            scope.Start();
            try
            {
                var response = _diskRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the disks under a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks
        /// Operation Id: Disks_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiskResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiskResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DiskResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diskClientDiagnostics.CreateScope("DiskCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diskRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DiskResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _diskClientDiagnostics.CreateScope("DiskCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diskRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all the disks under a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks
        /// Operation Id: Disks_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiskResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiskResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DiskResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _diskClientDiagnostics.CreateScope("DiskCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diskRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DiskResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _diskClientDiagnostics.CreateScope("DiskCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diskRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiskResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}
        /// Operation Id: Disks_Get
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can&apos;t be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string diskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));

            using var scope = _diskClientDiagnostics.CreateScope("DiskCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(diskName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}
        /// Operation Id: Disks_Get
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can&apos;t be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        public virtual Response<bool> Exists(string diskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));

            using var scope = _diskClientDiagnostics.CreateScope("DiskCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(diskName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}
        /// Operation Id: Disks_Get
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can&apos;t be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        public virtual async Task<Response<DiskResource>> GetIfExistsAsync(string diskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));

            using var scope = _diskClientDiagnostics.CreateScope("DiskCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _diskRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, diskName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DiskResource>(null, response.GetRawResponse());
                return Response.FromValue(new DiskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}
        /// Operation Id: Disks_Get
        /// </summary>
        /// <param name="diskName"> The name of the managed disk that is being created. The name can&apos;t be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9, _ and -. The maximum name length is 80 characters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="diskName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="diskName"/> is null. </exception>
        public virtual Response<DiskResource> GetIfExists(string diskName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(diskName, nameof(diskName));

            using var scope = _diskClientDiagnostics.CreateScope("DiskCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diskRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, diskName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DiskResource>(null, response.GetRawResponse());
                return Response.FromValue(new DiskResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DiskResource> IEnumerable<DiskResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiskResource> IAsyncEnumerable<DiskResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
