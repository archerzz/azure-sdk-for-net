// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Network.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Tests.Tests
{
    public class NetworkWatcherTests : NetworkServiceClientTestBase
    {
        public NetworkWatcherTests(bool isAsync) : base(isAsync)
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
        public async Task NetworkWatcherApiTest()
        {
            string resourceGroupName = Recording.GenerateAssetName("nw");

            string location = "eastus";
            await ResourceGroupsOperations.CreateOrUpdateAsync(resourceGroupName, new ResourceGroup(location));
            string networkWatcherName = Recording.GenerateAssetName("azsmnet");
            var properties = new NetworkWatcherData { Location = location };

            //Create Network Watcher in the resource group
            var networkWatcherContainer = GetNetworkWatcherContainer(resourceGroupName);
            await networkWatcherContainer.CreateOrUpdateAsync(networkWatcherName, properties);

            //Get Network Watcher by name in the resource group
            Response<NetworkWatcher> getNetworkWatcherByName = await networkWatcherContainer.GetAsync(networkWatcherName);

            //Get all Network Watchers in the resource group
            AsyncPageable<NetworkWatcher> getNetworkWatchersByResourceGroupAP = networkWatcherContainer.ListAsync();
            List<NetworkWatcher> getNetworkWatchersByResourceGroup = await getNetworkWatchersByResourceGroupAP.ToEnumerableAsync();

            //Get all Network Watchers in the subscription
            AsyncPageable<NetworkWatcher> getNetworkWatchersBySubscriptionAP = ArmClient.DefaultSubscription.ListNetworkWatchersAsync();
            List<NetworkWatcher> getNetworkWatchersBySubscription = await getNetworkWatchersBySubscriptionAP.ToEnumerableAsync();

            //Delete Network Watcher
            await getNetworkWatcherByName.Value.StartDeleteAsync();

            //Get all Network Watchers in the subscription
            AsyncPageable<NetworkWatcher> getNetworkWatcherBySubscriptionAfterDeletingAP = ArmClient.DefaultSubscription.ListNetworkWatchersAsync();
            List<NetworkWatcher> getNetworkWatcherBySubscriptionAfterDeleting = await getNetworkWatcherBySubscriptionAfterDeletingAP.ToEnumerableAsync();

            //Verify name of the created Network Watcher
            Assert.AreEqual(networkWatcherName, getNetworkWatcherByName.Value.Data.Name);

            //Verify provisioning state
            Assert.AreEqual("Succeeded", getNetworkWatcherByName.Value.Data.ProvisioningState.ToString());

            //Verify the number of Network Watchers in the resource group (should be 1)
            Has.One.EqualTo(getNetworkWatchersByResourceGroup);

            //Verify the number of Network Watchers in the subscription
            //Assert.AreEqual(2, getNetworkWatchersBySubscription.Count());

            //Verify the number of Network Watchers in the subscription after deleting one which was created in the test
            Has.One.EqualTo(getNetworkWatcherBySubscriptionAfterDeleting);
        }
    }
}
