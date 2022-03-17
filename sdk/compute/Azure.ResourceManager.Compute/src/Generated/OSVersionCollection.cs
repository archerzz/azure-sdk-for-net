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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of OSVersion and their operations over its parent. </summary>
    public partial class OSVersionCollection : ArmCollection, IEnumerable<OSVersionResource>, IAsyncEnumerable<OSVersionResource>
    {
        private readonly ClientDiagnostics _osVersionCloudServiceOperatingSystemsClientDiagnostics;
        private readonly CloudServiceOperatingSystemsRestOperations _osVersionCloudServiceOperatingSystemsRestClient;
        private readonly string _location;

        /// <summary> Initializes a new instance of the <see cref="OSVersionCollection"/> class for mocking. </summary>
        protected OSVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OSVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> Name of the location that the OS versions pertain to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        internal OSVersionCollection(ArmClient client, ResourceIdentifier id, string location) : base(client, id)
        {
            _location = location;
            _osVersionCloudServiceOperatingSystemsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", OSVersionResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(OSVersionResource.ResourceType, out string osVersionCloudServiceOperatingSystemsApiVersion);
            _osVersionCloudServiceOperatingSystemsRestClient = new CloudServiceOperatingSystemsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, osVersionCloudServiceOperatingSystemsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets properties of a guest operating system version that can be specified in the XML service configuration (.cscfg) for a cloud service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}
        /// Operation Id: CloudServiceOperatingSystems_GetOSVersion
        /// </summary>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osVersionName"/> is null. </exception>
        public virtual async Task<Response<OSVersionResource>> GetAsync(string osVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osVersionName, nameof(osVersionName));

            using var scope = _osVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _osVersionCloudServiceOperatingSystemsRestClient.GetOSVersionAsync(Id.SubscriptionId, _location, osVersionName, cancellationToken).ConfigureAwait(false);
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
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osVersionName"/> is null. </exception>
        public virtual Response<OSVersionResource> Get(string osVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osVersionName, nameof(osVersionName));

            using var scope = _osVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _osVersionCloudServiceOperatingSystemsRestClient.GetOSVersion(Id.SubscriptionId, _location, osVersionName, cancellationToken);
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
        /// Gets a list of all guest operating system versions available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS versions. Do this till nextLink is null to fetch all the OS versions.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions
        /// Operation Id: CloudServiceOperatingSystems_ListOSVersions
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OSVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OSVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<OSVersionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _osVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _osVersionCloudServiceOperatingSystemsRestClient.ListOSVersionsAsync(Id.SubscriptionId, _location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OSVersionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OSVersionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _osVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _osVersionCloudServiceOperatingSystemsRestClient.ListOSVersionsNextPageAsync(nextLink, Id.SubscriptionId, _location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new OSVersionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets a list of all guest operating system versions available to be specified in the XML service configuration (.cscfg) for a cloud service. Use nextLink property in the response to get the next page of OS versions. Do this till nextLink is null to fetch all the OS versions.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions
        /// Operation Id: CloudServiceOperatingSystems_ListOSVersions
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OSVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OSVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<OSVersionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _osVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _osVersionCloudServiceOperatingSystemsRestClient.ListOSVersions(Id.SubscriptionId, _location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OSVersionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OSVersionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _osVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _osVersionCloudServiceOperatingSystemsRestClient.ListOSVersionsNextPage(nextLink, Id.SubscriptionId, _location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new OSVersionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}
        /// Operation Id: CloudServiceOperatingSystems_GetOSVersion
        /// </summary>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osVersionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string osVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osVersionName, nameof(osVersionName));

            using var scope = _osVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(osVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}
        /// Operation Id: CloudServiceOperatingSystems_GetOSVersion
        /// </summary>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osVersionName"/> is null. </exception>
        public virtual Response<bool> Exists(string osVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osVersionName, nameof(osVersionName));

            using var scope = _osVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(osVersionName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}
        /// Operation Id: CloudServiceOperatingSystems_GetOSVersion
        /// </summary>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osVersionName"/> is null. </exception>
        public virtual async Task<Response<OSVersionResource>> GetIfExistsAsync(string osVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osVersionName, nameof(osVersionName));

            using var scope = _osVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _osVersionCloudServiceOperatingSystemsRestClient.GetOSVersionAsync(Id.SubscriptionId, _location, osVersionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<OSVersionResource>(null, response.GetRawResponse());
                return Response.FromValue(new OSVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/cloudServiceOsVersions/{osVersionName}
        /// Operation Id: CloudServiceOperatingSystems_GetOSVersion
        /// </summary>
        /// <param name="osVersionName"> Name of the OS version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="osVersionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="osVersionName"/> is null. </exception>
        public virtual Response<OSVersionResource> GetIfExists(string osVersionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(osVersionName, nameof(osVersionName));

            using var scope = _osVersionCloudServiceOperatingSystemsClientDiagnostics.CreateScope("OSVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _osVersionCloudServiceOperatingSystemsRestClient.GetOSVersion(Id.SubscriptionId, _location, osVersionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<OSVersionResource>(null, response.GetRawResponse());
                return Response.FromValue(new OSVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<OSVersionResource> IEnumerable<OSVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<OSVersionResource> IAsyncEnumerable<OSVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
