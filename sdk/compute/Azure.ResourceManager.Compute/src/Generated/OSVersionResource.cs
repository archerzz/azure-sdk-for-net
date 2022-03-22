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

namespace Azure.ResourceManager.Compute
{
    /// <summary> A Class representing a OSVersionResource along with the instance operations that can be performed on it. </summary>
    public partial class OSVersionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="OSVersionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string location, string osVersionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _osVersionCloudServiceOperatingSystemsClientDiagnostics;
        private readonly CloudServiceOperatingSystemsRestOperations _osVersionCloudServiceOperatingSystemsRestClient;
        private readonly OSVersionData _data;

        /// <summary> Initializes a new instance of the <see cref="OSVersionResource"/> class for mocking. </summary>
        protected OSVersionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "OSVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal OSVersionResource(ArmClient client, OSVersionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="OSVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal OSVersionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _osVersionCloudServiceOperatingSystemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string osVersionCloudServiceOperatingSystemsApiVersion);
            _osVersionCloudServiceOperatingSystemsRestClient = new CloudServiceOperatingSystemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, osVersionCloudServiceOperatingSystemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/locations/cloudServiceOsVersions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual OSVersionData Data
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
        /// Gets properties of a guest operating system version that can be specified in the XML service configuration (.cscfg) for a cloud service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}
        /// Operation Id: CloudServiceOperatingSystems_GetOSVersion
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OSVersionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _osVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersionResource.Get");
            scope.Start();
            try
            {
                var response = await _osVersionCloudServiceOperatingSystemsRestClient.GetOSVersionAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OSVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets properties of a guest operating system version that can be specified in the XML service configuration (.cscfg) for a cloud service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}
        /// Operation Id: CloudServiceOperatingSystems_GetOSVersion
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OSVersionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _osVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersionResource.Get");
            scope.Start();
            try
            {
                var response = _osVersionCloudServiceOperatingSystemsRestClient.GetOSVersion(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OSVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
