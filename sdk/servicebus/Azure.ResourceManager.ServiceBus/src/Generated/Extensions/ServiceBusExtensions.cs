// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ServiceBus. </summary>
    public static partial class ServiceBusExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Gets all the available namespaces within the subscription, irrespective of the resource groups.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceBus/namespaces
        /// Operation Id: Namespaces_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceBusNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ServiceBusNamespaceResource> GetServiceBusNamespacesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetServiceBusNamespacesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all the available namespaces within the subscription, irrespective of the resource groups.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceBus/namespaces
        /// Operation Id: Namespaces_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceBusNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ServiceBusNamespaceResource> GetServiceBusNamespaces(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetServiceBusNamespaces(cancellationToken);
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceBus/CheckNameAvailability
        /// Operation Id: Namespaces_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="parameters"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityResult>> CheckServiceBusNameAvailabilityAsync(this SubscriptionResource subscriptionResource, CheckNameAvailability parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            return await GetExtensionClient(subscriptionResource).CheckServiceBusNameAvailabilityAsync(parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the give namespace name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.ServiceBus/CheckNameAvailability
        /// Operation Id: Namespaces_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="parameters"> Parameters to check availability of the given namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public static Response<CheckNameAvailabilityResult> CheckServiceBusNameAvailability(this SubscriptionResource subscriptionResource, CheckNameAvailability parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            return GetExtensionClient(subscriptionResource).CheckServiceBusNameAvailability(parameters, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ServiceBusNamespaceResources in the ServiceBusNamespaceResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ServiceBusNamespaceResources and their operations over a ServiceBusNamespaceResource. </returns>
        public static ServiceBusNamespaceCollection GetServiceBusNamespaces(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetServiceBusNamespaces();
        }

        /// <summary>
        /// Gets a description for the specified namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public static async Task<Response<ServiceBusNamespaceResource>> GetServiceBusNamespaceAsync(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetServiceBusNamespaces().GetAsync(namespaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a description for the specified namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public static Response<ServiceBusNamespaceResource> GetServiceBusNamespace(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetServiceBusNamespaces().Get(namespaceName, cancellationToken);
        }

        #region ServiceBusNamespaceResource
        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusNamespaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusNamespaceResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusNamespaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusNamespaceResource" /> object. </returns>
        public static ServiceBusNamespaceResource GetServiceBusNamespaceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServiceBusNamespaceResource.ValidateResourceId(id);
                return new ServiceBusNamespaceResource(client, id);
            }
            );
        }
        #endregion

        #region NetworkRuleSetResource
        /// <summary>
        /// Gets an object representing a <see cref="NetworkRuleSetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NetworkRuleSetResource.CreateResourceIdentifier" /> to create a <see cref="NetworkRuleSetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NetworkRuleSetResource" /> object. </returns>
        public static NetworkRuleSetResource GetNetworkRuleSetResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NetworkRuleSetResource.ValidateResourceId(id);
                return new NetworkRuleSetResource(client, id);
            }
            );
        }
        #endregion

        #region PrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="PrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="PrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnectionResource" /> object. </returns>
        public static PrivateEndpointConnectionResource GetPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PrivateEndpointConnectionResource.ValidateResourceId(id);
                return new PrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region DisasterRecoveryResource
        /// <summary>
        /// Gets an object representing a <see cref="DisasterRecoveryResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DisasterRecoveryResource.CreateResourceIdentifier" /> to create a <see cref="DisasterRecoveryResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DisasterRecoveryResource" /> object. </returns>
        public static DisasterRecoveryResource GetDisasterRecoveryResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DisasterRecoveryResource.ValidateResourceId(id);
                return new DisasterRecoveryResource(client, id);
            }
            );
        }
        #endregion

        #region NamespaceDisasterRecoveryAuthorizationRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="NamespaceDisasterRecoveryAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NamespaceDisasterRecoveryAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="NamespaceDisasterRecoveryAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NamespaceDisasterRecoveryAuthorizationRuleResource" /> object. </returns>
        public static NamespaceDisasterRecoveryAuthorizationRuleResource GetNamespaceDisasterRecoveryAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NamespaceDisasterRecoveryAuthorizationRuleResource.ValidateResourceId(id);
                return new NamespaceDisasterRecoveryAuthorizationRuleResource(client, id);
            }
            );
        }
        #endregion

        #region NamespaceAuthorizationRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="NamespaceAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NamespaceAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="NamespaceAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NamespaceAuthorizationRuleResource" /> object. </returns>
        public static NamespaceAuthorizationRuleResource GetNamespaceAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NamespaceAuthorizationRuleResource.ValidateResourceId(id);
                return new NamespaceAuthorizationRuleResource(client, id);
            }
            );
        }
        #endregion

        #region NamespaceQueueAuthorizationRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="NamespaceQueueAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NamespaceQueueAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="NamespaceQueueAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NamespaceQueueAuthorizationRuleResource" /> object. </returns>
        public static NamespaceQueueAuthorizationRuleResource GetNamespaceQueueAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NamespaceQueueAuthorizationRuleResource.ValidateResourceId(id);
                return new NamespaceQueueAuthorizationRuleResource(client, id);
            }
            );
        }
        #endregion

        #region NamespaceTopicAuthorizationRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="NamespaceTopicAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="NamespaceTopicAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="NamespaceTopicAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="NamespaceTopicAuthorizationRuleResource" /> object. </returns>
        public static NamespaceTopicAuthorizationRuleResource GetNamespaceTopicAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                NamespaceTopicAuthorizationRuleResource.ValidateResourceId(id);
                return new NamespaceTopicAuthorizationRuleResource(client, id);
            }
            );
        }
        #endregion

        #region MigrationConfigPropertiesResource
        /// <summary>
        /// Gets an object representing a <see cref="MigrationConfigPropertiesResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MigrationConfigPropertiesResource.CreateResourceIdentifier" /> to create a <see cref="MigrationConfigPropertiesResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MigrationConfigPropertiesResource" /> object. </returns>
        public static MigrationConfigPropertiesResource GetMigrationConfigPropertiesResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MigrationConfigPropertiesResource.ValidateResourceId(id);
                return new MigrationConfigPropertiesResource(client, id);
            }
            );
        }
        #endregion

        #region ServiceBusQueueResource
        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusQueueResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusQueueResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusQueueResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusQueueResource" /> object. </returns>
        public static ServiceBusQueueResource GetServiceBusQueueResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServiceBusQueueResource.ValidateResourceId(id);
                return new ServiceBusQueueResource(client, id);
            }
            );
        }
        #endregion

        #region ServiceBusTopicResource
        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusTopicResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusTopicResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusTopicResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusTopicResource" /> object. </returns>
        public static ServiceBusTopicResource GetServiceBusTopicResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServiceBusTopicResource.ValidateResourceId(id);
                return new ServiceBusTopicResource(client, id);
            }
            );
        }
        #endregion

        #region ServiceBusRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusRuleResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusRuleResource" /> object. </returns>
        public static ServiceBusRuleResource GetServiceBusRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServiceBusRuleResource.ValidateResourceId(id);
                return new ServiceBusRuleResource(client, id);
            }
            );
        }
        #endregion

        #region ServiceBusSubscriptionResource
        /// <summary>
        /// Gets an object representing a <see cref="ServiceBusSubscriptionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceBusSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="ServiceBusSubscriptionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceBusSubscriptionResource" /> object. </returns>
        public static ServiceBusSubscriptionResource GetServiceBusSubscriptionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ServiceBusSubscriptionResource.ValidateResourceId(id);
                return new ServiceBusSubscriptionResource(client, id);
            }
            );
        }
        #endregion
    }
}
