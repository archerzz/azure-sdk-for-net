﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Network.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Tests.Tests
{
    public class RouteTableTests : NetworkServiceClientTestBase
    {
        public RouteTableTests(bool isAsync) : base(isAsync)
        {
        }

        [SetUp]
        public void ClearChallengeCacheforRecord()
        {
            if (Mode == RecordedTestMode.Record || Mode == RecordedTestMode.Playback)
            {
                Initialize();
            }
        }

        [TearDown]
        public async Task CleanupResourceGroup()
        {
            await CleanupResourceGroupsAsync();
        }

        [Test]
        public async Task EmptyRouteTableTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/routeTables");
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new ResourceGroup(location));
            string routeTableName = Recording.GenerateAssetName("azsmnet");
            var routeTable = new RouteTableData() { Location = location, };

            // Put RouteTable
            var routeTableContainer = GetRouteTableContainer(resourceGroupName);
            RouteTablesCreateOrUpdateOperation putRouteTableResponseOperation = await routeTableContainer.StartCreateOrUpdateAsync(routeTableName, routeTable);
            Response<RouteTable> putRouteTableResponse = await WaitForCompletionAsync(putRouteTableResponseOperation);
            Assert.AreEqual("Succeeded", putRouteTableResponse.Value.Data.ProvisioningState.ToString());

            // Get RouteTable
            Response<RouteTable> getRouteTableResponse = await routeTableContainer.GetAsync(routeTableName);
            Assert.AreEqual(routeTableName, getRouteTableResponse.Value.Data.Name);
            Assert.False(getRouteTableResponse.Value.Data.Routes.Any());

            // List RouteTable
            AsyncPageable<RouteTable> listRouteTableResponseAP = routeTableContainer.ListAsync();
            List<RouteTable> listRouteTableResponse = await listRouteTableResponseAP.ToEnumerableAsync();
            Has.One.EqualTo(listRouteTableResponse);
            Assert.AreEqual(getRouteTableResponse.Value.Data.Name, listRouteTableResponse.First().Data.Name);
            Assert.AreEqual(getRouteTableResponse.Value.Id, listRouteTableResponse.First().Id);

            // Delete RouteTable
            RouteTablesDeleteOperation deleteOperation = await getRouteTableResponse.Value.StartDeleteAsync();
            await WaitForCompletionAsync(deleteOperation);

            // Verify delete
            listRouteTableResponseAP = routeTableContainer.ListAsync();
            listRouteTableResponse = await listRouteTableResponseAP.ToEnumerableAsync();

            Assert.IsEmpty(listRouteTableResponse);
        }

        [Test]
        public async Task RouteTableApiTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/routeTables");
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new ResourceGroup(location));
            string routeTableName = Recording.GenerateAssetName("azsmnet");
            string route1Name = Recording.GenerateAssetName("azsmnet");
            string route2Name = Recording.GenerateAssetName("azsmnet");

            var routeTable = new RouteTableData() { Location = location, };

            // Add a route
            var route1 = new RouteData()
            {
                AddressPrefix = "192.168.1.0/24",
                Name = route1Name,
                NextHopIpAddress = "23.108.1.1",
                NextHopType = RouteNextHopType.VirtualAppliance
            };

            routeTable.Routes.Add(route1);

            // Put RouteTable
            var routeTableContainer = GetRouteTableContainer(resourceGroupName);
            RouteTablesCreateOrUpdateOperation putRouteTableResponseOperation = await routeTableContainer.StartCreateOrUpdateAsync(routeTableName, routeTable);
            Response<RouteTable> putRouteTableResponse = await WaitForCompletionAsync(putRouteTableResponseOperation);
            Assert.AreEqual("Succeeded", putRouteTableResponse.Value.Data.ProvisioningState.ToString());

            // Get RouteTable
            Response<RouteTable> getRouteTableResponse = await routeTableContainer.GetAsync(routeTableName);
            Assert.AreEqual(routeTableName, getRouteTableResponse.Value.Data.Name);
            Assert.AreEqual(1, getRouteTableResponse.Value.Data.Routes.Count);
            Assert.AreEqual(route1Name, getRouteTableResponse.Value.Data.Routes[0].Name);
            Assert.AreEqual("192.168.1.0/24", getRouteTableResponse.Value.Data.Routes[0].AddressPrefix);
            Assert.AreEqual("23.108.1.1", getRouteTableResponse.Value.Data.Routes[0].NextHopIpAddress);
            Assert.AreEqual(RouteNextHopType.VirtualAppliance, getRouteTableResponse.Value.Data.Routes[0].NextHopType);

            // Add another route
            var route2 = new RouteData()
            {
                AddressPrefix = "10.0.1.0/24",
                Name = route2Name,
                NextHopType = RouteNextHopType.VnetLocal
            };
            getRouteTableResponse.Value.Data.Routes.Add(route2);

            await routeTableContainer.StartCreateOrUpdateAsync(routeTableName, getRouteTableResponse.Value.Data);

            getRouteTableResponse = await routeTableContainer.GetAsync(routeTableName);
            Assert.AreEqual(routeTableName, getRouteTableResponse.Value.Data.Name);
            Assert.AreEqual(2, getRouteTableResponse.Value.Data.Routes.Count);
            Assert.AreEqual(route2Name, getRouteTableResponse.Value.Data.Routes[1].Name);
            Assert.AreEqual("10.0.1.0/24", getRouteTableResponse.Value.Data.Routes[1].AddressPrefix);
            Assert.True(string.IsNullOrEmpty(getRouteTableResponse.Value.Data.Routes[1].NextHopIpAddress));
            Assert.AreEqual(RouteNextHopType.VnetLocal, getRouteTableResponse.Value.Data.Routes[1].NextHopType);

            // Delete a route
            getRouteTableResponse.Value.Data.Routes.RemoveAt(0);

            await routeTableContainer.StartCreateOrUpdateAsync(routeTableName, getRouteTableResponse.Value.Data);

            getRouteTableResponse = await routeTableContainer.GetAsync(routeTableName);
            Assert.AreEqual(routeTableName, getRouteTableResponse.Value.Data.Name);
            Assert.AreEqual(1, getRouteTableResponse.Value.Data.Routes.Count);
            Assert.AreEqual(route2Name, getRouteTableResponse.Value.Data.Routes[0].Name);
            Assert.AreEqual("10.0.1.0/24", getRouteTableResponse.Value.Data.Routes[0].AddressPrefix);
            Assert.True(string.IsNullOrEmpty(getRouteTableResponse.Value.Data.Routes[0].NextHopIpAddress));
            Assert.AreEqual(RouteNextHopType.VnetLocal, getRouteTableResponse.Value.Data.Routes[0].NextHopType);

            // Delete RouteTable
            RouteTablesDeleteOperation deleteOperation = await getRouteTableResponse.Value.StartDeleteAsync();
            await WaitForCompletionAsync(deleteOperation);

            // Verify delete
            AsyncPageable<RouteTable> listRouteTableResponseAP = routeTableContainer.ListAsync();
            List<RouteTable> listRouteTableResponse = await listRouteTableResponseAP.ToEnumerableAsync();
            Assert.IsEmpty(listRouteTableResponse);
        }

        [Test]
        public async Task SubnetRouteTableTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("csmrg");

            string location = await NetworkManagementTestUtilities.GetResourceLocation(ResourceManagementClient, "Microsoft.Network/routeTables");
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new ResourceGroup(location));
            string routeTableName = Recording.GenerateAssetName("azsmnet");
            string route1Name = Recording.GenerateAssetName("azsmnet");

            var routeTable = new RouteTableData() { Location = location, };

            var route1 = new RouteData()
            {
                AddressPrefix = "192.168.1.0/24",
                Name = route1Name,
                NextHopIpAddress = "23.108.1.1",
                NextHopType = RouteNextHopType.VirtualAppliance
            };

            routeTable.Routes.Add(route1);

            // Put RouteTable
            var routeTableContainer = GetRouteTableContainer(resourceGroupName);
            RouteTablesCreateOrUpdateOperation putRouteTableResponseOperation = await routeTableContainer.StartCreateOrUpdateAsync(routeTableName, routeTable);
            Response<RouteTable> putRouteTableResponse = await WaitForCompletionAsync(putRouteTableResponseOperation);
            Assert.AreEqual("Succeeded", putRouteTableResponse.Value.Data.ProvisioningState.ToString());

            // Get RouteTable
            Response<RouteTable> getRouteTableResponse = await routeTableContainer.GetAsync(routeTableName);

            // Verify that the subnet reference is null
            Assert.IsEmpty(getRouteTableResponse.Value.Data.Subnets);

            // Create Vnet with subnet and add a route table
            string vnetName = Recording.GenerateAssetName("azsmnet");
            string subnetName = Recording.GenerateAssetName("azsmnet");

            var vnet = new VirtualNetworkData()
            {
                Location = location,

                AddressSpace = new AddressSpace()
                {
                    AddressPrefixes = { "10.0.0.0/16", }
                },
                DhcpOptions = new DhcpOptions()
                {
                    DnsServers = { "10.1.1.1", "10.1.2.4" }
                },
                Subnets = {
                    new SubnetData()
                    {
                        Name = subnetName,
                        AddressPrefix = "10.0.0.0/24",
                        RouteTable = new RouteTableData()
                        {
                            Id = getRouteTableResponse.Value.Id,
                        }
                    }
                }
            };

            VirtualNetworksCreateOrUpdateOperation putVnetResponseOperation = await GetVirtualNetworkContainer(resourceGroupName).StartCreateOrUpdateAsync(vnetName, vnet);
            Response<VirtualNetwork> putVnetResponse = await WaitForCompletionAsync(putVnetResponseOperation);
            Assert.AreEqual("Succeeded", putVnetResponse.Value.Data.ProvisioningState.ToString());

            Response<Subnet> getSubnetResponse = await putVnetResponse.Value.GetSubnets().GetAsync(subnetName);
            Assert.AreEqual(getSubnetResponse.Value.Data.RouteTable.Id, getRouteTableResponse.Value.Id);

            // Get RouteTable
            getRouteTableResponse = await routeTableContainer.GetAsync(routeTableName);
            Assert.AreEqual(1, getRouteTableResponse.Value.Data.Subnets.Count);
            Assert.AreEqual(getSubnetResponse.Value.Id, getRouteTableResponse.Value.Data.Subnets[0].Id);
        }
    }
}
