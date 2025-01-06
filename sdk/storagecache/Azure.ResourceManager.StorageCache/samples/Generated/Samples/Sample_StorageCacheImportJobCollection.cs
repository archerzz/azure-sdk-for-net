// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.StorageCache.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.StorageCache.Samples
{
    public partial class Sample_StorageCacheImportJobCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_ImportJobsCreateOrUpdate()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/importJobs_CreateOrUpdate.json
            // this example is just showing the usage of "importJobs_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AmlFileSystemResource created on azure
            // for more information of creating AmlFileSystemResource, please refer to the document of AmlFileSystemResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string amlFileSystemName = "fs1";
            ResourceIdentifier amlFileSystemResourceId = AmlFileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, amlFileSystemName);
            AmlFileSystemResource amlFileSystem = client.GetAmlFileSystemResource(amlFileSystemResourceId);

            // get the collection of this StorageCacheImportJobResource
            StorageCacheImportJobCollection collection = amlFileSystem.GetStorageCacheImportJobs();

            // invoke the operation
            string importJobName = "job1";
            StorageCacheImportJobData data = new StorageCacheImportJobData(new AzureLocation("eastus"))
            {
                ImportPrefixes = { "/" },
                ConflictResolutionMode = ConflictResolutionMode.OverwriteAlways,
                MaximumErrors = 0,
                Tags =
{
["Dept"] = "ContosoAds"
},
            };
            ArmOperation<StorageCacheImportJobResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, importJobName, data);
            StorageCacheImportJobResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageCacheImportJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ImportJobsGet()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/importJobs_Get.json
            // this example is just showing the usage of "importJobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AmlFileSystemResource created on azure
            // for more information of creating AmlFileSystemResource, please refer to the document of AmlFileSystemResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string amlFileSystemName = "fs1";
            ResourceIdentifier amlFileSystemResourceId = AmlFileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, amlFileSystemName);
            AmlFileSystemResource amlFileSystem = client.GetAmlFileSystemResource(amlFileSystemResourceId);

            // get the collection of this StorageCacheImportJobResource
            StorageCacheImportJobCollection collection = amlFileSystem.GetStorageCacheImportJobs();

            // invoke the operation
            string importJobName = "job1";
            StorageCacheImportJobResource result = await collection.GetAsync(importJobName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageCacheImportJobData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ImportJobsListByAmlFilesystem()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/importJobs_ListByAmlFilesystem.json
            // this example is just showing the usage of "importJobs_ListByAmlFilesystem" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AmlFileSystemResource created on azure
            // for more information of creating AmlFileSystemResource, please refer to the document of AmlFileSystemResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string amlFileSystemName = "fs1";
            ResourceIdentifier amlFileSystemResourceId = AmlFileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, amlFileSystemName);
            AmlFileSystemResource amlFileSystem = client.GetAmlFileSystemResource(amlFileSystemResourceId);

            // get the collection of this StorageCacheImportJobResource
            StorageCacheImportJobCollection collection = amlFileSystem.GetStorageCacheImportJobs();

            // invoke the operation and iterate over the result
            await foreach (StorageCacheImportJobResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StorageCacheImportJobData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_ImportJobsGet()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/importJobs_Get.json
            // this example is just showing the usage of "importJobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AmlFileSystemResource created on azure
            // for more information of creating AmlFileSystemResource, please refer to the document of AmlFileSystemResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string amlFileSystemName = "fs1";
            ResourceIdentifier amlFileSystemResourceId = AmlFileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, amlFileSystemName);
            AmlFileSystemResource amlFileSystem = client.GetAmlFileSystemResource(amlFileSystemResourceId);

            // get the collection of this StorageCacheImportJobResource
            StorageCacheImportJobCollection collection = amlFileSystem.GetStorageCacheImportJobs();

            // invoke the operation
            string importJobName = "job1";
            bool result = await collection.ExistsAsync(importJobName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_ImportJobsGet()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/importJobs_Get.json
            // this example is just showing the usage of "importJobs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AmlFileSystemResource created on azure
            // for more information of creating AmlFileSystemResource, please refer to the document of AmlFileSystemResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string amlFileSystemName = "fs1";
            ResourceIdentifier amlFileSystemResourceId = AmlFileSystemResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, amlFileSystemName);
            AmlFileSystemResource amlFileSystem = client.GetAmlFileSystemResource(amlFileSystemResourceId);

            // get the collection of this StorageCacheImportJobResource
            StorageCacheImportJobCollection collection = amlFileSystem.GetStorageCacheImportJobs();

            // invoke the operation
            string importJobName = "job1";
            NullableResponse<StorageCacheImportJobResource> response = await collection.GetIfExistsAsync(importJobName);
            StorageCacheImportJobResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StorageCacheImportJobData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
