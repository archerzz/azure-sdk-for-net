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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ManagedDatabaseSecurityAlertPolicy along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="ManagedDatabaseSecurityAlertPolicyResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetManagedDatabaseSecurityAlertPolicyResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedDatabaseResource" /> using the GetManagedDatabaseSecurityAlertPolicy method.
    /// </summary>
    public partial class ManagedDatabaseSecurityAlertPolicyResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedDatabaseSecurityAlertPolicyResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string securityAlertPolicyName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedDatabaseSecurityAlertPolicyClientDiagnostics;
        private readonly ManagedDatabaseSecurityAlertPoliciesRestOperations _managedDatabaseSecurityAlertPolicyRestClient;
        private readonly ManagedDatabaseSecurityAlertPolicyData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseSecurityAlertPolicyResource"/> class for mocking. </summary>
        protected ManagedDatabaseSecurityAlertPolicyResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedDatabaseSecurityAlertPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedDatabaseSecurityAlertPolicyResource(ArmClient client, ManagedDatabaseSecurityAlertPolicyData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseSecurityAlertPolicyResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedDatabaseSecurityAlertPolicyResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedDatabaseSecurityAlertPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedDatabaseSecurityAlertPolicyApiVersion);
            _managedDatabaseSecurityAlertPolicyRestClient = new ManagedDatabaseSecurityAlertPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedDatabaseSecurityAlertPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/securityAlertPolicies";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedDatabaseSecurityAlertPolicyData Data
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

        /// <summary>
        /// Gets a managed database&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: ManagedDatabaseSecurityAlertPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedDatabaseSecurityAlertPolicyResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseSecurityAlertPolicyClientDiagnostics.CreateScope("ManagedDatabaseSecurityAlertPolicyResource.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSecurityAlertPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a managed database&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: ManagedDatabaseSecurityAlertPolicies_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedDatabaseSecurityAlertPolicyResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseSecurityAlertPolicyClientDiagnostics.CreateScope("ManagedDatabaseSecurityAlertPolicyResource.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseSecurityAlertPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a database&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: ManagedDatabaseSecurityAlertPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The database security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedDatabaseSecurityAlertPolicyResource>> UpdateAsync(WaitUntil waitUntil, ManagedDatabaseSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedDatabaseSecurityAlertPolicyClientDiagnostics.CreateScope("ManagedDatabaseSecurityAlertPolicyResource.Update");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSecurityAlertPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedDatabaseSecurityAlertPolicyResource>(Response.FromValue(new ManagedDatabaseSecurityAlertPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a database&apos;s security alert policy.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/securityAlertPolicies/{securityAlertPolicyName}
        /// Operation Id: ManagedDatabaseSecurityAlertPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The database security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedDatabaseSecurityAlertPolicyResource> Update(WaitUntil waitUntil, ManagedDatabaseSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedDatabaseSecurityAlertPolicyClientDiagnostics.CreateScope("ManagedDatabaseSecurityAlertPolicyResource.Update");
            scope.Start();
            try
            {
                var response = _managedDatabaseSecurityAlertPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SqlArmOperation<ManagedDatabaseSecurityAlertPolicyResource>(Response.FromValue(new ManagedDatabaseSecurityAlertPolicyResource(Client, response), response.GetRawResponse()));
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
    }
}
