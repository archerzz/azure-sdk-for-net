// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventGrid.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_NamespaceTopicEventSubscriptionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NamespaceTopicEventSubscriptionsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/NamespaceTopicEventSubscriptions_Get.json
            // this example is just showing the usage of "NamespaceTopicEventSubscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NamespaceTopicEventSubscriptionResource created on azure
            // for more information of creating NamespaceTopicEventSubscriptionResource, please refer to the document of NamespaceTopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "examplenamespace2";
            string topicName = "examplenamespacetopic2";
            string eventSubscriptionName = "examplenamespacetopicEventSub1";
            ResourceIdentifier namespaceTopicEventSubscriptionResourceId = NamespaceTopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName, eventSubscriptionName);
            NamespaceTopicEventSubscriptionResource namespaceTopicEventSubscription = client.GetNamespaceTopicEventSubscriptionResource(namespaceTopicEventSubscriptionResourceId);

            // invoke the operation
            NamespaceTopicEventSubscriptionResource result = await namespaceTopicEventSubscription.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NamespaceTopicEventSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_NamespaceTopicEventSubscriptionsDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/NamespaceTopicEventSubscriptions_Delete.json
            // this example is just showing the usage of "NamespaceTopicEventSubscriptions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NamespaceTopicEventSubscriptionResource created on azure
            // for more information of creating NamespaceTopicEventSubscriptionResource, please refer to the document of NamespaceTopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "examplenamespace2";
            string topicName = "examplenamespacetopic2";
            string eventSubscriptionName = "examplenamespacetopicEventSub2";
            ResourceIdentifier namespaceTopicEventSubscriptionResourceId = NamespaceTopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName, eventSubscriptionName);
            NamespaceTopicEventSubscriptionResource namespaceTopicEventSubscription = client.GetNamespaceTopicEventSubscriptionResource(namespaceTopicEventSubscriptionResourceId);

            // invoke the operation
            await namespaceTopicEventSubscription.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_NamespaceTopicEventSubscriptionsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/NamespaceTopicEventSubscriptions_Update.json
            // this example is just showing the usage of "NamespaceTopicEventSubscriptions_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NamespaceTopicEventSubscriptionResource created on azure
            // for more information of creating NamespaceTopicEventSubscriptionResource, please refer to the document of NamespaceTopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            string topicName = "exampleNamespaceTopicName1";
            string eventSubscriptionName = "exampleNamespaceTopicEventSubscriptionName1";
            ResourceIdentifier namespaceTopicEventSubscriptionResourceId = NamespaceTopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName, eventSubscriptionName);
            NamespaceTopicEventSubscriptionResource namespaceTopicEventSubscription = client.GetNamespaceTopicEventSubscriptionResource(namespaceTopicEventSubscriptionResourceId);

            // invoke the operation
            NamespaceTopicEventSubscriptionPatch patch = new NamespaceTopicEventSubscriptionPatch
            {
                DeliveryConfiguration = new DeliveryConfiguration
                {
                    DeliveryMode = DeliveryMode.Queue,
                    Queue = new QueueInfo
                    {
                        ReceiveLockDurationInSeconds = 60,
                        MaxDeliveryCount = 3,
                        EventTimeToLive = XmlConvert.ToTimeSpan("P1D"),
                    },
                },
                EventDeliverySchema = DeliverySchema.CloudEventSchemaV10,
            };
            ArmOperation<NamespaceTopicEventSubscriptionResource> lro = await namespaceTopicEventSubscription.UpdateAsync(WaitUntil.Completed, patch);
            NamespaceTopicEventSubscriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NamespaceTopicEventSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetDeliveryAttributes_NamespaceTopicEventSubscriptionsGetDeliveryAttributes()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/NamespaceTopicEventSubscriptions_GetDeliveryAttributes.json
            // this example is just showing the usage of "NamespaceTopicEventSubscriptions_GetDeliveryAttributes" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NamespaceTopicEventSubscriptionResource created on azure
            // for more information of creating NamespaceTopicEventSubscriptionResource, please refer to the document of NamespaceTopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespace";
            string topicName = "exampleNamespaceTopic";
            string eventSubscriptionName = "exampleEventSubscriptionName";
            ResourceIdentifier namespaceTopicEventSubscriptionResourceId = NamespaceTopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName, eventSubscriptionName);
            NamespaceTopicEventSubscriptionResource namespaceTopicEventSubscription = client.GetNamespaceTopicEventSubscriptionResource(namespaceTopicEventSubscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DeliveryAttributeMapping item in namespaceTopicEventSubscription.GetDeliveryAttributesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetFullUri_NamespaceTopicEventSubscriptionsGetFullUrl()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2024-06-01-preview/examples/NamespaceTopicEventSubscriptions_GetFullUrl.json
            // this example is just showing the usage of "NamespaceTopicEventSubscriptions_GetFullUrl" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NamespaceTopicEventSubscriptionResource created on azure
            // for more information of creating NamespaceTopicEventSubscriptionResource, please refer to the document of NamespaceTopicEventSubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "exampleNamespaceName1";
            string topicName = "exampleDomainTopic1";
            string eventSubscriptionName = "examplesubscription1";
            ResourceIdentifier namespaceTopicEventSubscriptionResourceId = NamespaceTopicEventSubscriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, topicName, eventSubscriptionName);
            NamespaceTopicEventSubscriptionResource namespaceTopicEventSubscription = client.GetNamespaceTopicEventSubscriptionResource(namespaceTopicEventSubscriptionResourceId);

            // invoke the operation
            SubscriptionFullUri result = await namespaceTopicEventSubscription.GetFullUriAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
