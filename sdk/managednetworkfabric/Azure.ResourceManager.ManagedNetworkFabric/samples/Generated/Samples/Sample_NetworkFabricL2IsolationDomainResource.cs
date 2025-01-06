// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ManagedNetworkFabric.Samples
{
    public partial class Sample_NetworkFabricL2IsolationDomainResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_L2IsolationDomainsGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/L2IsolationDomains_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "L2IsolationDomains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricL2IsolationDomainResource created on azure
            // for more information of creating NetworkFabricL2IsolationDomainResource, please refer to the document of NetworkFabricL2IsolationDomainResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l2IsolationDomainName = "example-l2Domain";
            ResourceIdentifier networkFabricL2IsolationDomainResourceId = NetworkFabricL2IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l2IsolationDomainName);
            NetworkFabricL2IsolationDomainResource networkFabricL2IsolationDomain = client.GetNetworkFabricL2IsolationDomainResource(networkFabricL2IsolationDomainResourceId);

            // invoke the operation
            NetworkFabricL2IsolationDomainResource result = await networkFabricL2IsolationDomain.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFabricL2IsolationDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_L2IsolationDomainsDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/L2IsolationDomains_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "L2IsolationDomains_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricL2IsolationDomainResource created on azure
            // for more information of creating NetworkFabricL2IsolationDomainResource, please refer to the document of NetworkFabricL2IsolationDomainResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l2IsolationDomainName = "example-l2Domain";
            ResourceIdentifier networkFabricL2IsolationDomainResourceId = NetworkFabricL2IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l2IsolationDomainName);
            NetworkFabricL2IsolationDomainResource networkFabricL2IsolationDomain = client.GetNetworkFabricL2IsolationDomainResource(networkFabricL2IsolationDomainResourceId);

            // invoke the operation
            await networkFabricL2IsolationDomain.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_L2IsolationDomainsUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/L2IsolationDomains_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "L2IsolationDomains_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricL2IsolationDomainResource created on azure
            // for more information of creating NetworkFabricL2IsolationDomainResource, please refer to the document of NetworkFabricL2IsolationDomainResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l2IsolationDomainName = "example-l2Domain";
            ResourceIdentifier networkFabricL2IsolationDomainResourceId = NetworkFabricL2IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l2IsolationDomainName);
            NetworkFabricL2IsolationDomainResource networkFabricL2IsolationDomain = client.GetNetworkFabricL2IsolationDomainResource(networkFabricL2IsolationDomainResourceId);

            // invoke the operation
            NetworkFabricL2IsolationDomainPatch patch = new NetworkFabricL2IsolationDomainPatch
            {
                Annotation = "annotation1",
                Mtu = 6000,
                Tags =
{
["keyID"] = "keyValue"
},
            };
            ArmOperation<NetworkFabricL2IsolationDomainResource> lro = await networkFabricL2IsolationDomain.UpdateAsync(WaitUntil.Completed, patch);
            NetworkFabricL2IsolationDomainResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFabricL2IsolationDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateAdministrativeState_L2IsolationDomainsUpdateAdministrativeStateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/L2IsolationDomains_updateAdministrativeState_MaximumSet_Gen.json
            // this example is just showing the usage of "L2IsolationDomains_updateAdministrativeState" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricL2IsolationDomainResource created on azure
            // for more information of creating NetworkFabricL2IsolationDomainResource, please refer to the document of NetworkFabricL2IsolationDomainResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l2IsolationDomainName = "example-l2Domain";
            ResourceIdentifier networkFabricL2IsolationDomainResourceId = NetworkFabricL2IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l2IsolationDomainName);
            NetworkFabricL2IsolationDomainResource networkFabricL2IsolationDomain = client.GetNetworkFabricL2IsolationDomainResource(networkFabricL2IsolationDomainResourceId);

            // invoke the operation
            UpdateAdministrativeStateContent content = new UpdateAdministrativeStateContent
            {
                State = AdministrativeEnableState.Enable,
                ResourceIds = { new ResourceIdentifier("") },
            };
            ArmOperation<DeviceUpdateCommonPostActionResult> lro = await networkFabricL2IsolationDomain.UpdateAdministrativeStateAsync(WaitUntil.Completed, content);
            DeviceUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ValidateConfiguration_L2IsolationDomainsValidateConfigurationMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/L2IsolationDomains_ValidateConfiguration_MaximumSet_Gen.json
            // this example is just showing the usage of "L2IsolationDomains_ValidateConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricL2IsolationDomainResource created on azure
            // for more information of creating NetworkFabricL2IsolationDomainResource, please refer to the document of NetworkFabricL2IsolationDomainResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l2IsolationDomainName = "example-l2domain";
            ResourceIdentifier networkFabricL2IsolationDomainResourceId = NetworkFabricL2IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l2IsolationDomainName);
            NetworkFabricL2IsolationDomainResource networkFabricL2IsolationDomain = client.GetNetworkFabricL2IsolationDomainResource(networkFabricL2IsolationDomainResourceId);

            // invoke the operation
            ArmOperation<ValidateConfigurationResult> lro = await networkFabricL2IsolationDomain.ValidateConfigurationAsync(WaitUntil.Completed);
            ValidateConfigurationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CommitConfiguration_L2IsolationDomainsCommitConfigurationMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/L2IsolationDomains_CommitConfiguration_MaximumSet_Gen.json
            // this example is just showing the usage of "L2IsolationDomains_CommitConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricL2IsolationDomainResource created on azure
            // for more information of creating NetworkFabricL2IsolationDomainResource, please refer to the document of NetworkFabricL2IsolationDomainResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l2IsolationDomainName = "example-l2domain";
            ResourceIdentifier networkFabricL2IsolationDomainResourceId = NetworkFabricL2IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l2IsolationDomainName);
            NetworkFabricL2IsolationDomainResource networkFabricL2IsolationDomain = client.GetNetworkFabricL2IsolationDomainResource(networkFabricL2IsolationDomainResourceId);

            // invoke the operation
            ArmOperation<StateUpdateCommonPostActionResult> lro = await networkFabricL2IsolationDomain.CommitConfigurationAsync(WaitUntil.Completed);
            StateUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
