// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A Class representing a CapacityReservationGroupResource along with the instance operations that can be performed on it. </summary>
    public partial class CapacityReservationGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CapacityReservationGroupResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string capacityReservationGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _capacityReservationGroupClientDiagnostics;
        private readonly CapacityReservationGroupsRestOperations _capacityReservationGroupRestClient;
        private readonly CapacityReservationGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="CapacityReservationGroupResource"/> class for mocking. </summary>
        protected CapacityReservationGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CapacityReservationGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CapacityReservationGroupResource(ArmClient client, CapacityReservationGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CapacityReservationGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CapacityReservationGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _capacityReservationGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string capacityReservationGroupApiVersion);
            _capacityReservationGroupRestClient = new CapacityReservationGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, capacityReservationGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/capacityReservationGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CapacityReservationGroupData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of CapacityReservationResources in the CapacityReservationResource. </summary>
        /// <returns> An object representing collection of CapacityReservationResources and their operations over a CapacityReservationResource. </returns>
        public virtual CapacityReservationCollection GetCapacityReservations()
        {
            return GetCachedClient(Client => new CapacityReservationCollection(Client, Id));
        }

        /// <summary>
        /// The operation that retrieves information about the capacity reservation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}
        /// Operation Id: CapacityReservations_Get
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual async Task<Response<CapacityReservationResource>> GetCapacityReservationAsync(string capacityReservationName, CapacityReservationInstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            return await GetCapacityReservations().GetAsync(capacityReservationName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// The operation that retrieves information about the capacity reservation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}/capacityReservations/{capacityReservationName}
        /// Operation Id: CapacityReservations_Get
        /// </summary>
        /// <param name="capacityReservationName"> The name of the capacity reservation. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; retrieves a snapshot of the runtime properties of the capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="capacityReservationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="capacityReservationName"/> is null. </exception>
        public virtual Response<CapacityReservationResource> GetCapacityReservation(string capacityReservationName, CapacityReservationInstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            return GetCapacityReservations().Get(capacityReservationName, expand, cancellationToken);
        }

        /// <summary>
        /// The operation that retrieves information about a capacity reservation group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}
        /// Operation Id: CapacityReservationGroups_Get
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the capacity reservations under the capacity reservation group which is a snapshot of the runtime properties of a capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CapacityReservationGroupResource>> GetAsync(CapacityReservationGroupInstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _capacityReservationGroupClientDiagnostics.CreateScope("CapacityReservationGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _capacityReservationGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CapacityReservationGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation that retrieves information about a capacity reservation group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}
        /// Operation Id: CapacityReservationGroups_Get
        /// </summary>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the list of instance views of the capacity reservations under the capacity reservation group which is a snapshot of the runtime properties of a capacity reservation that is managed by the platform and can change outside of control plane operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CapacityReservationGroupResource> Get(CapacityReservationGroupInstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _capacityReservationGroupClientDiagnostics.CreateScope("CapacityReservationGroupResource.Get");
            scope.Start();
            try
            {
                var response = _capacityReservationGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CapacityReservationGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to delete a capacity reservation group. This operation is allowed only if all the associated resources are disassociated from the reservation group and all capacity reservations under the reservation group have also been deleted. Please refer to https://aka.ms/CapacityReservation for more details.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}
        /// Operation Id: CapacityReservationGroups_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _capacityReservationGroupClientDiagnostics.CreateScope("CapacityReservationGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _capacityReservationGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ComputeArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to delete a capacity reservation group. This operation is allowed only if all the associated resources are disassociated from the reservation group and all capacity reservations under the reservation group have also been deleted. Please refer to https://aka.ms/CapacityReservation for more details.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}
        /// Operation Id: CapacityReservationGroups_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _capacityReservationGroupClientDiagnostics.CreateScope("CapacityReservationGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _capacityReservationGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new ComputeArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to update a capacity reservation group. When updating a capacity reservation group, only tags may be modified.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}
        /// Operation Id: CapacityReservationGroups_Update
        /// </summary>
        /// <param name="data"> Parameters supplied to the Update capacity reservation Group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<CapacityReservationGroupResource>> UpdateAsync(PatchableCapacityReservationGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _capacityReservationGroupClientDiagnostics.CreateScope("CapacityReservationGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _capacityReservationGroupRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CapacityReservationGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to update a capacity reservation group. When updating a capacity reservation group, only tags may be modified.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}
        /// Operation Id: CapacityReservationGroups_Update
        /// </summary>
        /// <param name="data"> Parameters supplied to the Update capacity reservation Group operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<CapacityReservationGroupResource> Update(PatchableCapacityReservationGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _capacityReservationGroupClientDiagnostics.CreateScope("CapacityReservationGroupResource.Update");
            scope.Start();
            try
            {
                var response = _capacityReservationGroupRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, data, cancellationToken);
                return Response.FromValue(new CapacityReservationGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}
        /// Operation Id: CapacityReservationGroups_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<CapacityReservationGroupResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _capacityReservationGroupClientDiagnostics.CreateScope("CapacityReservationGroupResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagHelper.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await TagHelper.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _capacityReservationGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CapacityReservationGroupResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}
        /// Operation Id: CapacityReservationGroups_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<CapacityReservationGroupResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _capacityReservationGroupClientDiagnostics.CreateScope("CapacityReservationGroupResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagHelper.Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                TagHelper.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _capacityReservationGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new CapacityReservationGroupResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}
        /// Operation Id: CapacityReservationGroups_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<CapacityReservationGroupResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _capacityReservationGroupClientDiagnostics.CreateScope("CapacityReservationGroupResource.SetTags");
            scope.Start();
            try
            {
                await TagHelper.DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagHelper.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await TagHelper.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _capacityReservationGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CapacityReservationGroupResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}
        /// Operation Id: CapacityReservationGroups_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<CapacityReservationGroupResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _capacityReservationGroupClientDiagnostics.CreateScope("CapacityReservationGroupResource.SetTags");
            scope.Start();
            try
            {
                TagHelper.Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = TagHelper.Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                TagHelper.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _capacityReservationGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new CapacityReservationGroupResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}
        /// Operation Id: CapacityReservationGroups_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<CapacityReservationGroupResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _capacityReservationGroupClientDiagnostics.CreateScope("CapacityReservationGroupResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagHelper.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await TagHelper.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _capacityReservationGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new CapacityReservationGroupResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/capacityReservationGroups/{capacityReservationGroupName}
        /// Operation Id: CapacityReservationGroups_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<CapacityReservationGroupResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _capacityReservationGroupClientDiagnostics.CreateScope("CapacityReservationGroupResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagHelper.Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                TagHelper.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _capacityReservationGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, null, cancellationToken);
                return Response.FromValue(new CapacityReservationGroupResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
