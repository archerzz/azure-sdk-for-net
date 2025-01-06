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
    public partial class Sample_NetworkFabricResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NetworkFabricsGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabrics_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabrics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricResource created on azure
            // for more information of creating NetworkFabricResource, please refer to the document of NetworkFabricResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricName = "example-fabric";
            ResourceIdentifier networkFabricResourceId = NetworkFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricName);
            NetworkFabricResource networkFabric = client.GetNetworkFabricResource(networkFabricResourceId);

            // invoke the operation
            NetworkFabricResource result = await networkFabric.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFabricData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_NetworkFabricsDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabrics_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabrics_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricResource created on azure
            // for more information of creating NetworkFabricResource, please refer to the document of NetworkFabricResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricName = "example-fabric";
            ResourceIdentifier networkFabricResourceId = NetworkFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricName);
            NetworkFabricResource networkFabric = client.GetNetworkFabricResource(networkFabricResourceId);

            // invoke the operation
            await networkFabric.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_NetworkFabricsUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabrics_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabrics_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricResource created on azure
            // for more information of creating NetworkFabricResource, please refer to the document of NetworkFabricResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricName = "example-fabric";
            ResourceIdentifier networkFabricResourceId = NetworkFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricName);
            NetworkFabricResource networkFabric = client.GetNetworkFabricResource(networkFabricResourceId);

            // invoke the operation
            NetworkFabricPatch patch = new NetworkFabricPatch
            {
                Annotation = "annotation1",
                RackCount = 6,
                ServerCountPerRack = 10,
                IPv4Prefix = "10.18.0.0/17",
                IPv6Prefix = "3FFE:FFFF:0:CD40::/60",
                FabricAsn = 12345L,
                TerminalServerConfiguration = new NetworkFabricPatchablePropertiesTerminalServerConfiguration
                {
                    PrimaryIPv4Prefix = "10.0.0.12/30",
                    PrimaryIPv6Prefix = "4FFE:FFFF:0:CD30::a8/127",
                    SecondaryIPv4Prefix = "40.0.0.14/30",
                    SecondaryIPv6Prefix = "6FFE:FFFF:0:CD30::ac/127",
                    Username = "username1",
                    Password = "xxxxxxxx",
                    SerialNumber = "1234567",
                },
                ManagementNetworkConfiguration = new ManagementNetworkConfigurationPatchableProperties
                {
                    InfrastructureVpnConfiguration = new VpnConfigurationPatchableProperties
                    {
                        NetworkToNetworkInterconnectId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.ManagedNetworkFabric/networkFabrics/example-fabric/networkToNetworkInterconnects/example-nni"),
                        PeeringOption = PeeringOption.OptionB,
                        OptionBProperties = new OptionBProperties
                        {
                            ImportRouteTargets = { "65046:10050" },
                            ExportRouteTargets = { "65046:10050" },
                            RouteTargets = new RouteTargetInformation
                            {
                                ImportIPv4RouteTargets = { "65046:10050" },
                                ImportIPv6RouteTargets = { "65046:10050" },
                                ExportIPv4RouteTargets = { "65046:10050" },
                                ExportIPv6RouteTargets = { "65046:10050" },
                            },
                        },
                        OptionAProperties = new VpnConfigurationPatchableOptionAProperties
                        {
                            PrimaryIPv4Prefix = "10.0.0.12/30",
                            PrimaryIPv6Prefix = "4FFE:FFFF:0:CD30::a8/127",
                            SecondaryIPv4Prefix = "20.0.0.13/30",
                            SecondaryIPv6Prefix = "6FFE:FFFF:0:CD30::ac/127",
                            Mtu = 1501,
                            VlanId = 3001,
                            PeerAsn = 1235L,
                            BfdConfiguration = new BfdConfiguration
                            {
                                IntervalInMilliSeconds = 300,
                                Multiplier = 10,
                            },
                        },
                    },
                    WorkloadVpnConfiguration = new VpnConfigurationPatchableProperties
                    {
                        NetworkToNetworkInterconnectId = new ResourceIdentifier("/subscriptions/1234ABCD-0A1B-1234-5678-123456ABCDEF/resourceGroups/example-rg/providers/Microsoft.ManagedNetworkFabric/networkFabrics/example-fabric/networkToNetworkInterconnects/example-nni"),
                        PeeringOption = PeeringOption.OptionA,
                        OptionBProperties = new OptionBProperties
                        {
                            ImportRouteTargets = { "65046:10050" },
                            ExportRouteTargets = { "65046:10050" },
                            RouteTargets = new RouteTargetInformation
                            {
                                ImportIPv4RouteTargets = { "65046:10050" },
                                ImportIPv6RouteTargets = { "65046:10050" },
                                ExportIPv4RouteTargets = { "65046:10050" },
                                ExportIPv6RouteTargets = { "65046:10050" },
                            },
                        },
                        OptionAProperties = new VpnConfigurationPatchableOptionAProperties
                        {
                            PrimaryIPv4Prefix = "10.0.0.14/30",
                            PrimaryIPv6Prefix = "2FFE:FFFF:0:CD30::a7/126",
                            SecondaryIPv4Prefix = "10.0.0.15/30",
                            SecondaryIPv6Prefix = "2FFE:FFFF:0:CD30::ac/126",
                            Mtu = 1500,
                            VlanId = 3000,
                            PeerAsn = 61234L,
                            BfdConfiguration = new BfdConfiguration
                            {
                                IntervalInMilliSeconds = 300,
                                Multiplier = 5,
                            },
                        },
                    },
                },
                Tags =
{
["keyID"] = "KeyValue"
},
            };
            ArmOperation<NetworkFabricResource> lro = await networkFabric.UpdateAsync(WaitUntil.Completed, patch);
            NetworkFabricResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFabricData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Provision_NetworkFabricsProvisionMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabrics_provision_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabrics_provision" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricResource created on azure
            // for more information of creating NetworkFabricResource, please refer to the document of NetworkFabricResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricName = "example-fabric";
            ResourceIdentifier networkFabricResourceId = NetworkFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricName);
            NetworkFabricResource networkFabric = client.GetNetworkFabricResource(networkFabricResourceId);

            // invoke the operation
            ArmOperation<DeviceUpdateCommonPostActionResult> lro = await networkFabric.ProvisionAsync(WaitUntil.Completed);
            DeviceUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Deprovision_NetworkFabricsDeprovisionMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabrics_deprovision_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabrics_deprovision" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricResource created on azure
            // for more information of creating NetworkFabricResource, please refer to the document of NetworkFabricResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricName = "example-fabric";
            ResourceIdentifier networkFabricResourceId = NetworkFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricName);
            NetworkFabricResource networkFabric = client.GetNetworkFabricResource(networkFabricResourceId);

            // invoke the operation
            ArmOperation<DeviceUpdateCommonPostActionResult> lro = await networkFabric.DeprovisionAsync(WaitUntil.Completed);
            DeviceUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Upgrade_NetworkFabricsUpgradeMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabrics_upgrade_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabrics_upgrade" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricResource created on azure
            // for more information of creating NetworkFabricResource, please refer to the document of NetworkFabricResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricName = "example-fabric";
            ResourceIdentifier networkFabricResourceId = NetworkFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricName);
            NetworkFabricResource networkFabric = client.GetNetworkFabricResource(networkFabricResourceId);

            // invoke the operation
            NetworkFabricUpdateVersionContent content = new NetworkFabricUpdateVersionContent
            {
                Version = "version1",
            };
            ArmOperation<StateUpdateCommonPostActionResult> lro = await networkFabric.UpgradeAsync(WaitUntil.Completed, content);
            StateUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task RefreshConfiguration_NetworkFabricsRefreshConfigurationMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabrics_refreshConfiguration_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabrics_refreshConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricResource created on azure
            // for more information of creating NetworkFabricResource, please refer to the document of NetworkFabricResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricName = "example-fabric";
            ResourceIdentifier networkFabricResourceId = NetworkFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricName);
            NetworkFabricResource networkFabric = client.GetNetworkFabricResource(networkFabricResourceId);

            // invoke the operation
            ArmOperation<StateUpdateCommonPostActionResult> lro = await networkFabric.RefreshConfigurationAsync(WaitUntil.Completed);
            StateUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateWorkloadManagementBfdConfiguration_NetworkFabricsUpdateWorkloadManagementBfdConfigurationMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabrics_UpdateWorkloadManagementBfdConfiguration_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabrics_UpdateWorkloadManagementBfdConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricResource created on azure
            // for more information of creating NetworkFabricResource, please refer to the document of NetworkFabricResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricName = "example-fabric";
            ResourceIdentifier networkFabricResourceId = NetworkFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricName);
            NetworkFabricResource networkFabric = client.GetNetworkFabricResource(networkFabricResourceId);

            // invoke the operation
            UpdateAdministrativeStateContent content = new UpdateAdministrativeStateContent
            {
                State = AdministrativeEnableState.Enable,
                ResourceIds = { new ResourceIdentifier("") },
            };
            ArmOperation<StateUpdateCommonPostActionResult> lro = await networkFabric.UpdateWorkloadManagementBfdConfigurationAsync(WaitUntil.Completed, content);
            StateUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task UpdateInfraManagementBfdConfiguration_NetworkFabricsUpdateInfraManagementBfdConfigurationMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabrics_UpdateInfraManagementBfdConfiguration_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabrics_UpdateInfraManagementBfdConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricResource created on azure
            // for more information of creating NetworkFabricResource, please refer to the document of NetworkFabricResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricName = "example-fabric";
            ResourceIdentifier networkFabricResourceId = NetworkFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricName);
            NetworkFabricResource networkFabric = client.GetNetworkFabricResource(networkFabricResourceId);

            // invoke the operation
            UpdateAdministrativeStateContent content = new UpdateAdministrativeStateContent
            {
                State = AdministrativeEnableState.Enable,
                ResourceIds = { new ResourceIdentifier("") },
            };
            ArmOperation<StateUpdateCommonPostActionResult> lro = await networkFabric.UpdateInfraManagementBfdConfigurationAsync(WaitUntil.Completed, content);
            StateUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ValidateConfiguration_NetworkFabricsValidateConfigurationMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabrics_ValidateConfiguration_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabrics_ValidateConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricResource created on azure
            // for more information of creating NetworkFabricResource, please refer to the document of NetworkFabricResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricName = "example-fabric";
            ResourceIdentifier networkFabricResourceId = NetworkFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricName);
            NetworkFabricResource networkFabric = client.GetNetworkFabricResource(networkFabricResourceId);

            // invoke the operation
            ValidateConfigurationContent content = new ValidateConfigurationContent
            {
                ValidateAction = NetworkFabricValidateAction.Cabling,
            };
            ArmOperation<ValidateConfigurationResult> lro = await networkFabric.ValidateConfigurationAsync(WaitUntil.Completed, content);
            ValidateConfigurationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetTopology_NetworkFabricsGetTopologyMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabrics_GetTopology_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabrics_GetTopology" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricResource created on azure
            // for more information of creating NetworkFabricResource, please refer to the document of NetworkFabricResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricName = "example-fabric";
            ResourceIdentifier networkFabricResourceId = NetworkFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricName);
            NetworkFabricResource networkFabric = client.GetNetworkFabricResource(networkFabricResourceId);

            // invoke the operation
            ArmOperation<ValidateConfigurationResult> lro = await networkFabric.GetTopologyAsync(WaitUntil.Completed);
            ValidateConfigurationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CommitConfiguration_NetworkFabricsCommitConfigurationMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkFabrics_CommitConfiguration_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkFabrics_CommitConfiguration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFabricResource created on azure
            // for more information of creating NetworkFabricResource, please refer to the document of NetworkFabricResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkFabricName = "example-fabric";
            ResourceIdentifier networkFabricResourceId = NetworkFabricResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkFabricName);
            NetworkFabricResource networkFabric = client.GetNetworkFabricResource(networkFabricResourceId);

            // invoke the operation
            ArmOperation<StateUpdateCommonPostActionResult> lro = await networkFabric.CommitConfigurationAsync(WaitUntil.Completed);
            StateUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
