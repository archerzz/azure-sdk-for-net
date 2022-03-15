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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a Provider along with the instance operations that can be performed on it. </summary>
    public partial class Provider : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="Provider"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceProviderNamespace)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _providerClientDiagnostics;
        private readonly ProvidersRestOperations _providerRestClient;
        private readonly ClientDiagnostics _providerResourceTypesClientDiagnostics;
        private readonly ProviderResourceTypesRestOperations _providerResourceTypesRestClient;
        private readonly ProviderData _data;

        /// <summary> Initializes a new instance of the <see cref="Provider"/> class for mocking. </summary>
        protected Provider()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "Provider"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal Provider(ArmClient client, ProviderData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="Provider"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal Provider(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _providerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string providerApiVersion);
            _providerRestClient = new ProvidersRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, providerApiVersion);
            _providerResourceTypesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
            _providerResourceTypesRestClient = new ProviderResourceTypesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/providers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ProviderData Data
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

        /// <summary> Gets a collection of Features in the Feature. </summary>
        /// <returns> An object representing collection of Features and their operations over a Feature. </returns>
        public virtual FeatureCollection GetFeatures()
        {
            return GetCachedClient(Client => new FeatureCollection(Client, Id));
        }

        /// <summary>
        /// Gets the preview feature with the specified name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// Operation Id: Features_Get
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual async Task<Response<Feature>> GetFeatureAsync(string featureName, CancellationToken cancellationToken = default)
        {
            return await GetFeatures().GetAsync(featureName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the preview feature with the specified name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Features/providers/{resourceProviderNamespace}/features/{featureName}
        /// Operation Id: Features_Get
        /// </summary>
        /// <param name="featureName"> The name of the feature to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        public virtual Response<Feature> GetFeature(string featureName, CancellationToken cancellationToken = default)
        {
            return GetFeatures().Get(featureName, cancellationToken);
        }

        /// <summary>
        /// Gets the specified resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}
        /// Operation Id: Providers_Get
        /// </summary>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Provider>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _providerClientDiagnostics.CreateScope("Provider.Get");
            scope.Start();
            try
            {
                var response = await _providerRestClient.GetAsync(Id.SubscriptionId, Id.Provider, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Provider(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}
        /// Operation Id: Providers_Get
        /// </summary>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Provider> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _providerClientDiagnostics.CreateScope("Provider.Get");
            scope.Start();
            try
            {
                var response = _providerRestClient.Get(Id.SubscriptionId, Id.Provider, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Provider(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Unregisters a subscription from a resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/unregister
        /// Operation Id: Providers_Unregister
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Provider>> UnregisterAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _providerClientDiagnostics.CreateScope("Provider.Unregister");
            scope.Start();
            try
            {
                var response = await _providerRestClient.UnregisterAsync(Id.SubscriptionId, Id.Provider, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Provider(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Unregisters a subscription from a resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/unregister
        /// Operation Id: Providers_Unregister
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Provider> Unregister(CancellationToken cancellationToken = default)
        {
            using var scope = _providerClientDiagnostics.CreateScope("Provider.Unregister");
            scope.Start();
            try
            {
                var response = _providerRestClient.Unregister(Id.SubscriptionId, Id.Provider, cancellationToken);
                return Response.FromValue(new Provider(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the provider permissions.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/providerPermissions
        /// Operation Id: Providers_ProviderPermissions
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProviderPermission" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProviderPermission> ProviderPermissionsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ProviderPermission>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _providerClientDiagnostics.CreateScope("Provider.ProviderPermissions");
                scope.Start();
                try
                {
                    var response = await _providerRestClient.ProviderPermissionsAsync(Id.SubscriptionId, Id.Provider, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Get the provider permissions.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/providerPermissions
        /// Operation Id: Providers_ProviderPermissions
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProviderPermission" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProviderPermission> ProviderPermissions(CancellationToken cancellationToken = default)
        {
            Page<ProviderPermission> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _providerClientDiagnostics.CreateScope("Provider.ProviderPermissions");
                scope.Start();
                try
                {
                    var response = _providerRestClient.ProviderPermissions(Id.SubscriptionId, Id.Provider, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Registers a subscription with a resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/register
        /// Operation Id: Providers_Register
        /// </summary>
        /// <param name="properties"> The third party consent for S2S. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Provider>> RegisterAsync(ProviderRegistrationOptions properties = null, CancellationToken cancellationToken = default)
        {
            using var scope = _providerClientDiagnostics.CreateScope("Provider.Register");
            scope.Start();
            try
            {
                var response = await _providerRestClient.RegisterAsync(Id.SubscriptionId, Id.Provider, properties, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Provider(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Registers a subscription with a resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/register
        /// Operation Id: Providers_Register
        /// </summary>
        /// <param name="properties"> The third party consent for S2S. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Provider> Register(ProviderRegistrationOptions properties = null, CancellationToken cancellationToken = default)
        {
            using var scope = _providerClientDiagnostics.CreateScope("Provider.Register");
            scope.Start();
            try
            {
                var response = _providerRestClient.Register(Id.SubscriptionId, Id.Provider, properties, cancellationToken);
                return Response.FromValue(new Provider(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the resource types for a specified resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/resourceTypes
        /// Operation Id: ProviderResourceTypes_List
        /// </summary>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProviderResourceType" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProviderResourceType> GetProviderResourceTypesAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ProviderResourceType>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _providerResourceTypesClientDiagnostics.CreateScope("Provider.GetProviderResourceTypes");
                scope.Start();
                try
                {
                    var response = await _providerResourceTypesRestClient.ListAsync(Id.SubscriptionId, Id.Provider, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List the resource types for a specified resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/{resourceProviderNamespace}/resourceTypes
        /// Operation Id: ProviderResourceTypes_List
        /// </summary>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProviderResourceType" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProviderResourceType> GetProviderResourceTypes(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<ProviderResourceType> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _providerResourceTypesClientDiagnostics.CreateScope("Provider.GetProviderResourceTypes");
                scope.Start();
                try
                {
                    var response = _providerResourceTypesRestClient.List(Id.SubscriptionId, Id.Provider, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
