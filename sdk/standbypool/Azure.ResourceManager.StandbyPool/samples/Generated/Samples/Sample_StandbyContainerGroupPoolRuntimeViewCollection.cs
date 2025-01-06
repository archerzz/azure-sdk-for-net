// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.StandbyPool.Samples
{
    public partial class Sample_StandbyContainerGroupPoolRuntimeViewCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_StandbyContainerGroupPoolRuntimeViewsGet()
        {
            // Generated from example definition: 2024-03-01/StandbyContainerGroupPoolRuntimeViews_Get.json
            // this example is just showing the usage of "StandbyContainerGroupPoolRuntimeViews_get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyContainerGroupPoolResource created on azure
            // for more information of creating StandbyContainerGroupPoolResource, please refer to the document of StandbyContainerGroupPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            string standbyContainerGroupPoolName = "pool";
            ResourceIdentifier standbyContainerGroupPoolResourceId = StandbyContainerGroupPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyContainerGroupPoolName);
            StandbyContainerGroupPoolResource standbyContainerGroupPool = client.GetStandbyContainerGroupPoolResource(standbyContainerGroupPoolResourceId);

            // get the collection of this StandbyContainerGroupPoolRuntimeViewResource
            StandbyContainerGroupPoolRuntimeViewCollection collection = standbyContainerGroupPool.GetStandbyContainerGroupPoolRuntimeViews();

            // invoke the operation
            string runtimeView = "latest";
            StandbyContainerGroupPoolRuntimeViewResource result = await collection.GetAsync(runtimeView);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyContainerGroupPoolRuntimeViewData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_StandbyContainerGroupPoolRuntimeViewsListByStandbyPool()
        {
            // Generated from example definition: 2024-03-01/StandbyContainerGroupPoolRuntimeViews_ListByStandbyPool.json
            // this example is just showing the usage of "StandbyContainerGroupPoolRuntimeViews_listByStandbyPool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyContainerGroupPoolResource created on azure
            // for more information of creating StandbyContainerGroupPoolResource, please refer to the document of StandbyContainerGroupPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            string standbyContainerGroupPoolName = "pool";
            ResourceIdentifier standbyContainerGroupPoolResourceId = StandbyContainerGroupPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyContainerGroupPoolName);
            StandbyContainerGroupPoolResource standbyContainerGroupPool = client.GetStandbyContainerGroupPoolResource(standbyContainerGroupPoolResourceId);

            // get the collection of this StandbyContainerGroupPoolRuntimeViewResource
            StandbyContainerGroupPoolRuntimeViewCollection collection = standbyContainerGroupPool.GetStandbyContainerGroupPoolRuntimeViews();

            // invoke the operation and iterate over the result
            await foreach (StandbyContainerGroupPoolRuntimeViewResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StandbyContainerGroupPoolRuntimeViewData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_StandbyContainerGroupPoolRuntimeViewsGet()
        {
            // Generated from example definition: 2024-03-01/StandbyContainerGroupPoolRuntimeViews_Get.json
            // this example is just showing the usage of "StandbyContainerGroupPoolRuntimeViews_get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyContainerGroupPoolResource created on azure
            // for more information of creating StandbyContainerGroupPoolResource, please refer to the document of StandbyContainerGroupPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            string standbyContainerGroupPoolName = "pool";
            ResourceIdentifier standbyContainerGroupPoolResourceId = StandbyContainerGroupPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyContainerGroupPoolName);
            StandbyContainerGroupPoolResource standbyContainerGroupPool = client.GetStandbyContainerGroupPoolResource(standbyContainerGroupPoolResourceId);

            // get the collection of this StandbyContainerGroupPoolRuntimeViewResource
            StandbyContainerGroupPoolRuntimeViewCollection collection = standbyContainerGroupPool.GetStandbyContainerGroupPoolRuntimeViews();

            // invoke the operation
            string runtimeView = "latest";
            bool result = await collection.ExistsAsync(runtimeView);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_StandbyContainerGroupPoolRuntimeViewsGet()
        {
            // Generated from example definition: 2024-03-01/StandbyContainerGroupPoolRuntimeViews_Get.json
            // this example is just showing the usage of "StandbyContainerGroupPoolRuntimeViews_get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyContainerGroupPoolResource created on azure
            // for more information of creating StandbyContainerGroupPoolResource, please refer to the document of StandbyContainerGroupPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            string standbyContainerGroupPoolName = "pool";
            ResourceIdentifier standbyContainerGroupPoolResourceId = StandbyContainerGroupPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyContainerGroupPoolName);
            StandbyContainerGroupPoolResource standbyContainerGroupPool = client.GetStandbyContainerGroupPoolResource(standbyContainerGroupPoolResourceId);

            // get the collection of this StandbyContainerGroupPoolRuntimeViewResource
            StandbyContainerGroupPoolRuntimeViewCollection collection = standbyContainerGroupPool.GetStandbyContainerGroupPoolRuntimeViews();

            // invoke the operation
            string runtimeView = "latest";
            NullableResponse<StandbyContainerGroupPoolRuntimeViewResource> response = await collection.GetIfExistsAsync(runtimeView);
            StandbyContainerGroupPoolRuntimeViewResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StandbyContainerGroupPoolRuntimeViewData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
