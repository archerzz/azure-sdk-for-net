// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Fabric.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Fabric.Samples
{
    public partial class Sample_FabricCapacityCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateACapacity()
        {
            // Generated from example definition: 2023-11-01/FabricCapacities_CreateOrUpdate.json
            // this example is just showing the usage of "FabricCapacities_createOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "548B7FB7-3B2A-4F46-BB02-66473F1FC22C";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FabricCapacityResource
            FabricCapacityCollection collection = resourceGroupResource.GetFabricCapacities();

            // invoke the operation
            string capacityName = "azsdktest";
            FabricCapacityData data = new FabricCapacityData(new AzureLocation("westcentralus"), new FabricCapacityProperties(new FabricCapacityAdministration(new string[] { "azsdktest@microsoft.com", "azsdktest2@microsoft.com" })), new FabricSku("F2", FabricSkuTier.Fabric));
            ArmOperation<FabricCapacityResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, capacityName, data);
            FabricCapacityResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FabricCapacityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetACapacity()
        {
            // Generated from example definition: 2023-11-01/FabricCapacities_Get.json
            // this example is just showing the usage of "FabricCapacities_get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "548B7FB7-3B2A-4F46-BB02-66473F1FC22C";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FabricCapacityResource
            FabricCapacityCollection collection = resourceGroupResource.GetFabricCapacities();

            // invoke the operation
            string capacityName = "azsdktest";
            FabricCapacityResource result = await collection.GetAsync(capacityName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FabricCapacityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListCapacitiesByResourceGroup()
        {
            // Generated from example definition: 2023-11-01/FabricCapacities_ListByResourceGroup.json
            // this example is just showing the usage of "FabricCapacities_listByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "548B7FB7-3B2A-4F46-BB02-66473F1FC22C";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FabricCapacityResource
            FabricCapacityCollection collection = resourceGroupResource.GetFabricCapacities();

            // invoke the operation and iterate over the result
            await foreach (FabricCapacityResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FabricCapacityData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetACapacity()
        {
            // Generated from example definition: 2023-11-01/FabricCapacities_Get.json
            // this example is just showing the usage of "FabricCapacities_get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "548B7FB7-3B2A-4F46-BB02-66473F1FC22C";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FabricCapacityResource
            FabricCapacityCollection collection = resourceGroupResource.GetFabricCapacities();

            // invoke the operation
            string capacityName = "azsdktest";
            bool result = await collection.ExistsAsync(capacityName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetACapacity()
        {
            // Generated from example definition: 2023-11-01/FabricCapacities_Get.json
            // this example is just showing the usage of "FabricCapacities_get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "548B7FB7-3B2A-4F46-BB02-66473F1FC22C";
            string resourceGroupName = "TestRG";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this FabricCapacityResource
            FabricCapacityCollection collection = resourceGroupResource.GetFabricCapacities();

            // invoke the operation
            string capacityName = "azsdktest";
            NullableResponse<FabricCapacityResource> response = await collection.GetIfExistsAsync(capacityName);
            FabricCapacityResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FabricCapacityData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
