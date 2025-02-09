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
    public partial class Sample_NetworkFabricL3IsolationDomainResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_L3IsolationDomainsGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/L3IsolationDomains_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "L3IsolationDomains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricL3IsolationDomainResource created on azure
            // for more information of creating NetworkFabricL3IsolationDomainResource, please refer to the document of NetworkFabricL3IsolationDomainResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l3IsolationDomainName = "example-l3domain";
            ResourceIdentifier networkFabricL3IsolationDomainResourceId = NetworkFabricL3IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName);
            NetworkFabricL3IsolationDomainResource networkFabricL3IsolationDomain = client.GetNetworkFabricL3IsolationDomainResource(networkFabricL3IsolationDomainResourceId);

            // invoke the operation
            NetworkFabricL3IsolationDomainResource result = await networkFabricL3IsolationDomain.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFabricL3IsolationDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_L3IsolationDomainsDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/L3IsolationDomains_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "L3IsolationDomains_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricL3IsolationDomainResource created on azure
            // for more information of creating NetworkFabricL3IsolationDomainResource, please refer to the document of NetworkFabricL3IsolationDomainResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l3IsolationDomainName = "example-l3domain";
            ResourceIdentifier networkFabricL3IsolationDomainResourceId = NetworkFabricL3IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName);
            NetworkFabricL3IsolationDomainResource networkFabricL3IsolationDomain = client.GetNetworkFabricL3IsolationDomainResource(networkFabricL3IsolationDomainResourceId);

            // invoke the operation
            await networkFabricL3IsolationDomain.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_L3IsolationDomainsUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/L3IsolationDomains_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "L3IsolationDomains_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricL3IsolationDomainResource created on azure
            // for more information of creating NetworkFabricL3IsolationDomainResource, please refer to the document of NetworkFabricL3IsolationDomainResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l3IsolationDomainName = "example-l3domain";
            ResourceIdentifier networkFabricL3IsolationDomainResourceId = NetworkFabricL3IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName);
            NetworkFabricL3IsolationDomainResource networkFabricL3IsolationDomain = client.GetNetworkFabricL3IsolationDomainResource(networkFabricL3IsolationDomainResourceId);

            // invoke the operation
            NetworkFabricL3IsolationDomainPatch patch = new NetworkFabricL3IsolationDomainPatch
            {
                Annotation = "annotation1",
                RedistributeConnectedSubnets = RedistributeConnectedSubnet.True,
                RedistributeStaticRoutes = RedistributeStaticRoute.False,
                AggregateRouteConfiguration = new AggregateRouteConfiguration
                {
                    IPv4Routes = { new AggregateRoute("10.0.0.0/24") },
                    IPv6Routes = { new AggregateRoute("3FFE:FFFF:0:CD30::a0/29") },
                },
                ConnectedSubnetRoutePolicy = new ConnectedSubnetRoutePolicy
                {
                    ExportRoutePolicyId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.ManagedNetworkFabric/routePolicies/routePolicyName"),
                    ExportRoutePolicy = new L3ExportRoutePolicy
                    {
                        ExportIPv4RoutePolicyId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.ManagedNetworkFabric/routePolicies/example-routePolicy1"),
                        ExportIPv6RoutePolicyId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.ManagedNetworkFabric/routePolicies/example-routePolicy1"),
                    },
                },
                Tags =
{
["key4953"] = "1234"
},
            };
            ArmOperation<NetworkFabricL3IsolationDomainResource> lro = await networkFabricL3IsolationDomain.UpdateAsync(WaitUntil.Completed, patch);
            NetworkFabricL3IsolationDomainResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFabricL3IsolationDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateAdministrativeState_L3IsolationDomainsUpdateAdministrativeStateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/L3IsolationDomains_updateAdministrativeState_MaximumSet_Gen.json
            // this example is just showing the usage of "L3IsolationDomains_UpdateAdministrativeState" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricL3IsolationDomainResource created on azure
            // for more information of creating NetworkFabricL3IsolationDomainResource, please refer to the document of NetworkFabricL3IsolationDomainResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l3IsolationDomainName = "example-l3domain";
            ResourceIdentifier networkFabricL3IsolationDomainResourceId = NetworkFabricL3IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName);
            NetworkFabricL3IsolationDomainResource networkFabricL3IsolationDomain = client.GetNetworkFabricL3IsolationDomainResource(networkFabricL3IsolationDomainResourceId);

            // invoke the operation
            UpdateAdministrativeStateContent content = new UpdateAdministrativeStateContent
            {
                State = AdministrativeEnableState.Enable,
                ResourceIds = { new ResourceIdentifier("") },
            };
            ArmOperation<DeviceUpdateCommonPostActionResult> lro = await networkFabricL3IsolationDomain.UpdateAdministrativeStateAsync(WaitUntil.Completed, content);
            DeviceUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ValidateConfiguration_L3IsolationDomainsValidateConfigurationMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/L3IsolationDomains_ValidateConfiguration_MaximumSet_Gen.json
            // this example is just showing the usage of "L3IsolationDomains_ValidateConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricL3IsolationDomainResource created on azure
            // for more information of creating NetworkFabricL3IsolationDomainResource, please refer to the document of NetworkFabricL3IsolationDomainResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l3IsolationDomainName = "example-l3domain";
            ResourceIdentifier networkFabricL3IsolationDomainResourceId = NetworkFabricL3IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName);
            NetworkFabricL3IsolationDomainResource networkFabricL3IsolationDomain = client.GetNetworkFabricL3IsolationDomainResource(networkFabricL3IsolationDomainResourceId);

            // invoke the operation
            ArmOperation<ValidateConfigurationResult> lro = await networkFabricL3IsolationDomain.ValidateConfigurationAsync(WaitUntil.Completed);
            ValidateConfigurationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CommitConfiguration_L3IsolationDomainsCommitConfigurationMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/L3IsolationDomains_CommitConfiguration_MaximumSet_Gen.json
            // this example is just showing the usage of "L3IsolationDomains_CommitConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricL3IsolationDomainResource created on azure
            // for more information of creating NetworkFabricL3IsolationDomainResource, please refer to the document of NetworkFabricL3IsolationDomainResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string l3IsolationDomainName = "example-l3domain";
            ResourceIdentifier networkFabricL3IsolationDomainResourceId = NetworkFabricL3IsolationDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, l3IsolationDomainName);
            NetworkFabricL3IsolationDomainResource networkFabricL3IsolationDomain = client.GetNetworkFabricL3IsolationDomainResource(networkFabricL3IsolationDomainResourceId);

            // invoke the operation
            ArmOperation<StateUpdateCommonPostActionResult> lro = await networkFabricL3IsolationDomain.CommitConfigurationAsync(WaitUntil.Completed);
            StateUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
