// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_GalleryInVmAccessControlProfileVersionCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateAGalleryInVMAccessControlProfileVersion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2024-03-03/examples/galleryResourceProfileExamples/GalleryInVMAccessControlProfileVersion_Create.json
            // this example is just showing the usage of "GalleryInVMAccessControlProfileVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryInVmAccessControlProfileResource created on azure
            // for more information of creating GalleryInVmAccessControlProfileResource, please refer to the document of GalleryInVmAccessControlProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string inVmAccessControlProfileName = "myInVMAccessControlProfileName";
            ResourceIdentifier galleryInVmAccessControlProfileResourceId = GalleryInVmAccessControlProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, inVmAccessControlProfileName);
            GalleryInVmAccessControlProfileResource galleryInVmAccessControlProfile = client.GetGalleryInVmAccessControlProfileResource(galleryInVmAccessControlProfileResourceId);

            // get the collection of this GalleryInVmAccessControlProfileVersionResource
            GalleryInVmAccessControlProfileVersionCollection collection = galleryInVmAccessControlProfile.GetGalleryInVmAccessControlProfileVersions();

            // invoke the operation
            string inVmAccessControlProfileVersionName = "1.0.0";
            GalleryInVmAccessControlProfileVersionData data = new GalleryInVmAccessControlProfileVersionData(new AzureLocation("West US"))
            {
                TargetLocations = { new TargetRegion("West US"), new TargetRegion("South Central US") },
                ExcludeFromLatest = false,
                Mode = GalleryInVmAccessControlRulesMode.Audit,
                DefaultAccess = ComputeGalleryEndpointAccess.Allow,
                Rules = new GalleryInVmAccessControlRules
                {
                    Privileges = {new GalleryInVmAccessControlRulesPrivilege("GoalState", "/machine")
{
QueryParameters =
{
["comp"] = "goalstate"
},
}},
                    Roles = { new GalleryInVmAccessControlRulesRole("Provisioning", new string[] { "GoalState" }) },
                    Identities = {new GalleryInVmAccessControlRulesIdentity("WinPA")
{
UserName = "SYSTEM",
GroupName = "Administrators",
ExePath = "C:\\Windows\\System32\\cscript.exe",
ProcessName = "cscript",
}},
                    RoleAssignments = { new GalleryInVmAccessControlRulesRoleAssignment("Provisioning", new string[] { "WinPA" }) },
                },
            };
            ArmOperation<GalleryInVmAccessControlProfileVersionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, inVmAccessControlProfileVersionName, data);
            GalleryInVmAccessControlProfileVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryInVmAccessControlProfileVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAGalleryInVMAccessControlProfileVersion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2024-03-03/examples/galleryResourceProfileExamples/GalleryInVMAccessControlProfileVersion_Get.json
            // this example is just showing the usage of "GalleryInVMAccessControlProfileVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryInVmAccessControlProfileResource created on azure
            // for more information of creating GalleryInVmAccessControlProfileResource, please refer to the document of GalleryInVmAccessControlProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string inVmAccessControlProfileName = "myInVMAccessControlProfileName";
            ResourceIdentifier galleryInVmAccessControlProfileResourceId = GalleryInVmAccessControlProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, inVmAccessControlProfileName);
            GalleryInVmAccessControlProfileResource galleryInVmAccessControlProfile = client.GetGalleryInVmAccessControlProfileResource(galleryInVmAccessControlProfileResourceId);

            // get the collection of this GalleryInVmAccessControlProfileVersionResource
            GalleryInVmAccessControlProfileVersionCollection collection = galleryInVmAccessControlProfile.GetGalleryInVmAccessControlProfileVersions();

            // invoke the operation
            string inVmAccessControlProfileVersionName = "1.0.0";
            GalleryInVmAccessControlProfileVersionResource result = await collection.GetAsync(inVmAccessControlProfileVersionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryInVmAccessControlProfileVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListGalleryInVMAccessControlProfileVersionsInAGalleryInVMAccessControlProfile()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2024-03-03/examples/galleryResourceProfileExamples/GalleryInVMAccessControlProfileVersion_ListByGalleryInVMAccessControlProfile.json
            // this example is just showing the usage of "GalleryInVMAccessControlProfileVersions_ListByGalleryInVMAccessControlProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryInVmAccessControlProfileResource created on azure
            // for more information of creating GalleryInVmAccessControlProfileResource, please refer to the document of GalleryInVmAccessControlProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string inVmAccessControlProfileName = "myInVMAccessControlProfileName";
            ResourceIdentifier galleryInVmAccessControlProfileResourceId = GalleryInVmAccessControlProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, inVmAccessControlProfileName);
            GalleryInVmAccessControlProfileResource galleryInVmAccessControlProfile = client.GetGalleryInVmAccessControlProfileResource(galleryInVmAccessControlProfileResourceId);

            // get the collection of this GalleryInVmAccessControlProfileVersionResource
            GalleryInVmAccessControlProfileVersionCollection collection = galleryInVmAccessControlProfile.GetGalleryInVmAccessControlProfileVersions();

            // invoke the operation and iterate over the result
            await foreach (GalleryInVmAccessControlProfileVersionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GalleryInVmAccessControlProfileVersionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAGalleryInVMAccessControlProfileVersion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2024-03-03/examples/galleryResourceProfileExamples/GalleryInVMAccessControlProfileVersion_Get.json
            // this example is just showing the usage of "GalleryInVMAccessControlProfileVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryInVmAccessControlProfileResource created on azure
            // for more information of creating GalleryInVmAccessControlProfileResource, please refer to the document of GalleryInVmAccessControlProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string inVmAccessControlProfileName = "myInVMAccessControlProfileName";
            ResourceIdentifier galleryInVmAccessControlProfileResourceId = GalleryInVmAccessControlProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, inVmAccessControlProfileName);
            GalleryInVmAccessControlProfileResource galleryInVmAccessControlProfile = client.GetGalleryInVmAccessControlProfileResource(galleryInVmAccessControlProfileResourceId);

            // get the collection of this GalleryInVmAccessControlProfileVersionResource
            GalleryInVmAccessControlProfileVersionCollection collection = galleryInVmAccessControlProfile.GetGalleryInVmAccessControlProfileVersions();

            // invoke the operation
            string inVmAccessControlProfileVersionName = "1.0.0";
            bool result = await collection.ExistsAsync(inVmAccessControlProfileVersionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAGalleryInVMAccessControlProfileVersion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2024-03-03/examples/galleryResourceProfileExamples/GalleryInVMAccessControlProfileVersion_Get.json
            // this example is just showing the usage of "GalleryInVMAccessControlProfileVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryInVmAccessControlProfileResource created on azure
            // for more information of creating GalleryInVmAccessControlProfileResource, please refer to the document of GalleryInVmAccessControlProfileResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string inVmAccessControlProfileName = "myInVMAccessControlProfileName";
            ResourceIdentifier galleryInVmAccessControlProfileResourceId = GalleryInVmAccessControlProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, inVmAccessControlProfileName);
            GalleryInVmAccessControlProfileResource galleryInVmAccessControlProfile = client.GetGalleryInVmAccessControlProfileResource(galleryInVmAccessControlProfileResourceId);

            // get the collection of this GalleryInVmAccessControlProfileVersionResource
            GalleryInVmAccessControlProfileVersionCollection collection = galleryInVmAccessControlProfile.GetGalleryInVmAccessControlProfileVersions();

            // invoke the operation
            string inVmAccessControlProfileVersionName = "1.0.0";
            NullableResponse<GalleryInVmAccessControlProfileVersionResource> response = await collection.GetIfExistsAsync(inVmAccessControlProfileVersionName);
            GalleryInVmAccessControlProfileVersionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GalleryInVmAccessControlProfileVersionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
