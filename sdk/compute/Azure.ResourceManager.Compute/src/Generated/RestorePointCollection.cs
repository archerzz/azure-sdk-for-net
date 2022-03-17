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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of RestorePoint and their operations over its parent. </summary>
    public partial class RestorePointCollection : ArmCollection
    {
        private readonly ClientDiagnostics _restorePointClientDiagnostics;
        private readonly RestorePointsRestOperations _restorePointRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorePointCollection"/> class for mocking. </summary>
        protected RestorePointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorePointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RestorePointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorePointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", RestorePointResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(RestorePointResource.ResourceType, out string restorePointApiVersion);
            _restorePointRestClient = new RestorePointsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, restorePointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RestorePointGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RestorePointGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create the restore point. Updating properties of an existing restore point is not allowed
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="parameters"> Parameters supplied to the Create restore point operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<RestorePointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string restorePointName, RestorePointData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restorePointRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation<RestorePointResource>(new RestorePointOperationSource(Client), _restorePointClientDiagnostics, Pipeline, _restorePointRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create the restore point. Updating properties of an existing restore point is not allowed
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Create
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="parameters"> Parameters supplied to the Create restore point operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<RestorePointResource> CreateOrUpdate(WaitUntil waitUntil, string restorePointName, RestorePointData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restorePointRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, parameters, cancellationToken);
                var operation = new ComputeArmOperation<RestorePointResource>(new RestorePointOperationSource(Client), _restorePointClientDiagnostics, Pipeline, _restorePointRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to get the restore point.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Get
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual async Task<Response<RestorePointResource>> GetAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorePointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorePointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to get the restore point.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Get
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<RestorePointResource> Get(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.Get");
            scope.Start();
            try
            {
                var response = _restorePointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorePointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Get
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(restorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Get
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<bool> Exists(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(restorePointName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Get
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual async Task<Response<RestorePointResource>> GetIfExistsAsync(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _restorePointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RestorePointResource>(null, response.GetRawResponse());
                return Response.FromValue(new RestorePointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointCollectionName}/restorePoints/{restorePointName}
        /// Operation Id: RestorePoints_Get
        /// </summary>
        /// <param name="restorePointName"> The name of the restore point. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="restorePointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="restorePointName"/> is null. </exception>
        public virtual Response<RestorePointResource> GetIfExists(string restorePointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(restorePointName, nameof(restorePointName));

            using var scope = _restorePointClientDiagnostics.CreateScope("RestorePointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restorePointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, restorePointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RestorePointResource>(null, response.GetRawResponse());
                return Response.FromValue(new RestorePointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
