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
    public partial class Sample_StandbyVirtualMachinePoolRuntimeViewResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_StandbyVirtualMachinePoolRuntimeViewsGet()
        {
            // Generated from example definition: 2024-03-01/StandbyVirtualMachinePoolRuntimeViews_Get.json
            // this example is just showing the usage of "StandbyVirtualMachinePoolRuntimeViews_get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StandbyVirtualMachinePoolRuntimeViewResource created on azure
            // for more information of creating StandbyVirtualMachinePoolRuntimeViewResource, please refer to the document of StandbyVirtualMachinePoolRuntimeViewResource
            string subscriptionId = "00000000-0000-0000-0000-000000000009";
            string resourceGroupName = "rgstandbypool";
            string standbyVirtualMachinePoolName = "pool";
            string runtimeView = "latest";
            ResourceIdentifier standbyVirtualMachinePoolRuntimeViewResourceId = StandbyVirtualMachinePoolRuntimeViewResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, standbyVirtualMachinePoolName, runtimeView);
            StandbyVirtualMachinePoolRuntimeViewResource standbyVirtualMachinePoolRuntimeView = client.GetStandbyVirtualMachinePoolRuntimeViewResource(standbyVirtualMachinePoolRuntimeViewResourceId);

            // invoke the operation
            StandbyVirtualMachinePoolRuntimeViewResource result = await standbyVirtualMachinePoolRuntimeView.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StandbyVirtualMachinePoolRuntimeViewData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
