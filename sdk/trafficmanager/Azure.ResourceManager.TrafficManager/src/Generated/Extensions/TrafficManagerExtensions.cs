// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TrafficManager.Mocking;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.TrafficManager. </summary>
    public static partial class TrafficManagerExtensions
    {
        private static MockableTrafficManagerArmClient GetMockableTrafficManagerArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableTrafficManagerArmClient(client0));
        }

        private static MockableTrafficManagerResourceGroupResource GetMockableTrafficManagerResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableTrafficManagerResourceGroupResource(client, resource.Id));
        }

        private static MockableTrafficManagerSubscriptionResource GetMockableTrafficManagerSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableTrafficManagerSubscriptionResource(client, resource.Id));
        }

        private static MockableTrafficManagerTenantResource GetMockableTrafficManagerTenantResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableTrafficManagerTenantResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="TrafficManagerEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TrafficManagerEndpointResource.CreateResourceIdentifier" /> to create a <see cref="TrafficManagerEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerArmClient.GetTrafficManagerEndpointResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="TrafficManagerEndpointResource"/> object. </returns>
        public static TrafficManagerEndpointResource GetTrafficManagerEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableTrafficManagerArmClient(client).GetTrafficManagerEndpointResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TrafficManagerProfileResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TrafficManagerProfileResource.CreateResourceIdentifier" /> to create a <see cref="TrafficManagerProfileResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerArmClient.GetTrafficManagerProfileResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="TrafficManagerProfileResource"/> object. </returns>
        public static TrafficManagerProfileResource GetTrafficManagerProfileResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableTrafficManagerArmClient(client).GetTrafficManagerProfileResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TrafficManagerGeographicHierarchyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TrafficManagerGeographicHierarchyResource.CreateResourceIdentifier" /> to create a <see cref="TrafficManagerGeographicHierarchyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerArmClient.GetTrafficManagerGeographicHierarchyResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="TrafficManagerGeographicHierarchyResource"/> object. </returns>
        public static TrafficManagerGeographicHierarchyResource GetTrafficManagerGeographicHierarchyResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableTrafficManagerArmClient(client).GetTrafficManagerGeographicHierarchyResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TrafficManagerHeatMapResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TrafficManagerHeatMapResource.CreateResourceIdentifier" /> to create a <see cref="TrafficManagerHeatMapResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerArmClient.GetTrafficManagerHeatMapResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="TrafficManagerHeatMapResource"/> object. </returns>
        public static TrafficManagerHeatMapResource GetTrafficManagerHeatMapResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableTrafficManagerArmClient(client).GetTrafficManagerHeatMapResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="TrafficManagerUserMetricsResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="TrafficManagerUserMetricsResource.CreateResourceIdentifier(string)" /> to create a <see cref="TrafficManagerUserMetricsResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerArmClient.GetTrafficManagerUserMetricsResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="TrafficManagerUserMetricsResource"/> object. </returns>
        public static TrafficManagerUserMetricsResource GetTrafficManagerUserMetricsResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableTrafficManagerArmClient(client).GetTrafficManagerUserMetricsResource(id);
        }

        /// <summary>
        /// Gets a collection of TrafficManagerProfileResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerResourceGroupResource.GetTrafficManagerProfiles()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of TrafficManagerProfileResources and their operations over a TrafficManagerProfileResource. </returns>
        public static TrafficManagerProfileCollection GetTrafficManagerProfiles(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableTrafficManagerResourceGroupResource(resourceGroupResource).GetTrafficManagerProfiles();
        }

        /// <summary>
        /// Gets a Traffic Manager profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerResourceGroupResource.GetTrafficManagerProfileAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="profileName"> The name of the Traffic Manager profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="profileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<TrafficManagerProfileResource>> GetTrafficManagerProfileAsync(this ResourceGroupResource resourceGroupResource, string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableTrafficManagerResourceGroupResource(resourceGroupResource).GetTrafficManagerProfileAsync(profileName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Traffic Manager profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficmanagerprofiles/{profileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerResourceGroupResource.GetTrafficManagerProfile(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="profileName"> The name of the Traffic Manager profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="profileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="profileName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<TrafficManagerProfileResource> GetTrafficManagerProfile(this ResourceGroupResource resourceGroupResource, string profileName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableTrafficManagerResourceGroupResource(resourceGroupResource).GetTrafficManagerProfile(profileName, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing a TrafficManagerUserMetricsResource along with the instance operations that can be performed on it in the SubscriptionResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerSubscriptionResource.GetTrafficManagerUserMetrics()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> Returns a <see cref="TrafficManagerUserMetricsResource"/> object. </returns>
        public static TrafficManagerUserMetricsResource GetTrafficManagerUserMetrics(this SubscriptionResource subscriptionResource)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableTrafficManagerSubscriptionResource(subscriptionResource).GetTrafficManagerUserMetrics();
        }

        /// <summary>
        /// Checks the availability of a Traffic Manager Relative DNS name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/checkTrafficManagerNameAvailabilityV2</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_checkTrafficManagerNameAvailabilityV2</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerSubscriptionResource.CheckTrafficManagerNameAvailabilityV2Profile(TrafficManagerRelativeDnsNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The Traffic Manager name parameters supplied to the CheckTrafficManagerNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<TrafficManagerNameAvailabilityResult>> CheckTrafficManagerNameAvailabilityV2ProfileAsync(this SubscriptionResource subscriptionResource, TrafficManagerRelativeDnsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableTrafficManagerSubscriptionResource(subscriptionResource).CheckTrafficManagerNameAvailabilityV2ProfileAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks the availability of a Traffic Manager Relative DNS name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/checkTrafficManagerNameAvailabilityV2</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_checkTrafficManagerNameAvailabilityV2</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerSubscriptionResource.CheckTrafficManagerNameAvailabilityV2Profile(TrafficManagerRelativeDnsNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The Traffic Manager name parameters supplied to the CheckTrafficManagerNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<TrafficManagerNameAvailabilityResult> CheckTrafficManagerNameAvailabilityV2Profile(this SubscriptionResource subscriptionResource, TrafficManagerRelativeDnsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableTrafficManagerSubscriptionResource(subscriptionResource).CheckTrafficManagerNameAvailabilityV2Profile(content, cancellationToken);
        }

        /// <summary>
        /// Lists all Traffic Manager profiles within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/trafficmanagerprofiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerSubscriptionResource.GetTrafficManagerProfiles(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="TrafficManagerProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<TrafficManagerProfileResource> GetTrafficManagerProfilesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableTrafficManagerSubscriptionResource(subscriptionResource).GetTrafficManagerProfilesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all Traffic Manager profiles within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/trafficmanagerprofiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerSubscriptionResource.GetTrafficManagerProfiles(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="TrafficManagerProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<TrafficManagerProfileResource> GetTrafficManagerProfiles(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableTrafficManagerSubscriptionResource(subscriptionResource).GetTrafficManagerProfiles(cancellationToken);
        }

        /// <summary>
        /// Gets an object representing a TrafficManagerGeographicHierarchyResource along with the instance operations that can be performed on it in the TenantResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerTenantResource.GetTrafficManagerGeographicHierarchy()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> Returns a <see cref="TrafficManagerGeographicHierarchyResource"/> object. </returns>
        public static TrafficManagerGeographicHierarchyResource GetTrafficManagerGeographicHierarchy(this TenantResource tenantResource)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableTrafficManagerTenantResource(tenantResource).GetTrafficManagerGeographicHierarchy();
        }

        /// <summary>
        /// Checks the availability of a Traffic Manager Relative DNS name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Network/checkTrafficManagerNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_CheckTrafficManagerRelativeDnsNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerTenantResource.CheckTrafficManagerRelativeDnsNameAvailability(TrafficManagerRelativeDnsNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> The Traffic Manager name parameters supplied to the CheckTrafficManagerNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<TrafficManagerNameAvailabilityResult>> CheckTrafficManagerRelativeDnsNameAvailabilityAsync(this TenantResource tenantResource, TrafficManagerRelativeDnsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return await GetMockableTrafficManagerTenantResource(tenantResource).CheckTrafficManagerRelativeDnsNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks the availability of a Traffic Manager Relative DNS name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Network/checkTrafficManagerNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Profiles_CheckTrafficManagerRelativeDnsNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TrafficManagerProfileResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTrafficManagerTenantResource.CheckTrafficManagerRelativeDnsNameAvailability(TrafficManagerRelativeDnsNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> The Traffic Manager name parameters supplied to the CheckTrafficManagerNameAvailability operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<TrafficManagerNameAvailabilityResult> CheckTrafficManagerRelativeDnsNameAvailability(this TenantResource tenantResource, TrafficManagerRelativeDnsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableTrafficManagerTenantResource(tenantResource).CheckTrafficManagerRelativeDnsNameAvailability(content, cancellationToken);
        }
    }
}
