# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.
#TODO: update commit id back to e25881196fcf84fca4dfaedc9fc45a00db4e0541 (?) after merging /azure-rest-api-specs/pull/9800

```yaml
azure-arm: true
library-name: Network
namespace: Azure.ResourceManager.Network
require: https://raw.githubusercontent.com/Azure/azure-rest-api-specs/master/specification/network/resource-manager/readme.md
tag: package-2021-02-preview

clear-output-folder: true
skip-csproj: true
modelerfour:
    lenient-model-deduplication: true
model-namespace: false
public-clients: false
head-as-boolean: false
payload-flattening-threshold: 2

# the following are the configuration for work-around, we should minimize them as few as possible
operation-group-to-resource-type:
    # availableDelegations.json
    AvailableDelegations: Microsoft.Network/locations/availableDelegations
    # azureFirewallFqdnTag.json
    AzureFirewallFqdnTags: Microsoft.Network/azureFirewallFqdnTags
    AvailableEndpointServices: Microsoft.Network/locations/virtualNetworkAvailableEndpointServices
    PeerExpressRouteCircuitConnections: Microsoft.Network/expressRouteCircuits/peerings/peerConnections
    ExpressRouteServiceProviders: Microsoft.Network/expressRouteServiceProviders
    ExpressRoutePortsLocations: Microsoft.Network/ExpressRoutePortsLocations
    ExpressRouteLinks: Microsoft.Network/ExpressRoutePorts/links
    # applicationGateway.json
    ApplicationGatewayPrivateLinkResources: Microsoft.Network/applicationGateways/privateLinkResources
    # azureWebCategory.json
    WebCategories: Microsoft.Network/azureWebCategories
    # bastionHost.json
    BastionShareableLinks: Microsoft.Network/bastionHosts/bastionShareableLinks
    ActiveSessions: Microsoft.Network/bastionHosts/activeSessions
    # checkDnsAvailability.json
    DnsNameAvailabilities: Microsoft.Network/locations/CheckDnsNameAvailability
    # loadBalancer.json
    LoadBalancerFrontendIPConfigurations: Microsoft.Network/loadBalancers/frontendIPConfigurations
    LoadBalancerLoadBalancingRules: Microsoft.Network/loadBalancers/loadBalancingRules
    LoadBalancerOutboundRules: Microsoft.Network/loadBalancers/outboundRules
    LoadBalancerNetworkInterfaces: Microsoft.Network/loadBalancers/networkInterfaces
    LoadBalancerProbes: Microsoft.Network/loadBalancers/probes
    # network.json
    NetworkInterfaceIPConfigurations: Microsoft.Network/networkInterfaces/ipConfigurations
    NetworkInterfaceLoadBalancers: Microsoft.Network/networkInterfaces/loadBalancers
    # networkSecurityGroup.json
    DefaultSecurityRules: Microsoft.Network/networkSecurityGroups/defaultSecurityRules
    # networkVirtualAppliance.json
    VirtualApplianceSkus: Microsoft.Network/networkVirtualApplianceSkus
    # operation.json
    Operations: Microsoft.Network/operations
    # privateEndpoint.json
    AvailablePrivateEndpointTypes: Microsoft.Network/locations/availablePrivateEndpointTypes
    # serviceCommunity.json
    BgpServiceCommunities: Microsoft.Network/bgpServiceCommunities
    # serviceTags.json
    ServiceTags: Microsoft.Network/locations/serviceTags
    # usage.json
    Usages: Microsoft.Network/locations/usages
    # virtualNetwork.json
    ResourceNavigationLinks: Microsoft.Network/virtualNetworks/subnets/ResourceNavigationLinks
    ServiceAssociationLinks: Microsoft.Network/virtualNetworks/subnets/ServiceAssociationLinks
    # virtualWan.json
    VpnSiteLinks: Microsoft.Network/vpnSites/vpnSiteLinks
    VpnSiteLinkConnections: Microsoft.Network/vpnGateways/vpnConnections/vpnLinkConnections
    VpnSitesConfiguration: Microsoft.Network/virtualWans/vpnConfiguration
    VpnServerConfigurationsAssociatedWithVirtualWan: Microsoft.Network/virtualWans
    SupportedSecurityProviders: Microsoft.Network/virtualWans/supportedSecurityProviders
    VpnLinkConnections: Microsoft.Network/vpnGateways/vpnConnections/vpnLinkConnections
    VirtualWanVpnServerConfigurationVpnProfiles: Microsoft.Network/virtualWans/GenerateVpnProfile
operation-group-to-resource:
    # availableDelegations.json
    AvailableDelegations: NonResource
    # applicationGateway.json
    ApplicationGatewayPrivateLinkResources: NonResource
    # azureFirewallFqdnTag.json
    AzureFirewallFqdnTags: NonResource
    AvailableEndpointServices: NonResource
    PeerExpressRouteCircuitConnections: PeerExpressRouteCircuitConnection
    ExpressRouteServiceProviders: NonResource
    ExpressRoutePortsLocations: ExpressRoutePortsLocation
    ExpressRouteLinks: ExpressRouteLink
    # azureWebCategory.json
    WebCategories: NonResource
    # bastionHost.json
    BastionShareableLinks: NonResource
    ActiveSessions: NonResource
    # checkDnsAvailability.json
    DnsNameAvailabilities: NonResource
    # loadBalancer.json
    LoadBalancerFrontendIPConfigurations: FrontendIPConfiguration
    LoadBalancerLoadBalancingRules: LoadBalancingRule
    LoadBalancerOutboundRules: OutboundRule
    LoadBalancerNetworkInterfaces: NonResource
    LoadBalancerProbes: Probe
    # network.json
    NetworkInterfaceIPConfigurations: NetworkInterfaceIPConfiguration
    NetworkInterfaceLoadBalancers: NonResource
    # networkSecurityGroup.json
    DefaultSecurityRules: SecurityRule
    # networkVirtualAppliance.json
    VirtualApplianceSkus: NonResource
    # networkWatcher.json
    PacketCaptures: PacketCaptureResult
    ConnectionMonitors: ConnectionMonitorResult
    # operations.json
    Operations: NonResource
    # privateEndpoint.json
    AvailablePrivateEndpointTypes: NonResource
    # serviceCommunity.json
    BgpServiceCommunities: NonResource
    # serviceTags.json
    ServiceTags: NonResource
    # usage.json
    Usages: NonResource
    # virtualNetwork.json
    ResourceNavigationLinks: NonResource
    ServiceAssociationLinks: NonResource
    # virtualWan.json
    VpnSiteLinks: VpnSiteLink
    VpnSitesConfiguration: NonResource
    VpnServerConfigurationsAssociatedWithVirtualWan: NonResource
    VpnSiteLinkConnections: VpnSiteLinkConnection
    SupportedSecurityProviders: NonResource
    VpnLinkConnections: NonResource
    VirtualWanVpnServerConfigurationVpnProfiles: NonResource
operation-group-to-parent:
    # availableDelegations.json
    AvailableDelegations: Location
    # azureWebCategory.json
    WebCategories: subscriptions
    # bastionHost.json
    BastionShareableLinks: BastionHosts
    ActiveSessions: BastionHosts
    # checkDnsAvailability.json
    DnsNameAvailabilities: Location
    # networkVirtualAppliance.json
    InboundSecurityRule: NetworkVirtualAppliance
    # privateEndpoint.json
    AvailableEndpointServices: Location
    AvailablePrivateEndpointTypes: Location
    # serviceTags.json
    ServiceTags: Location
    # usage.json
    Usages: Location
    # virtualWan.json
    VpnSitesConfiguration: VirtualWan
    VpnServerConfigurationsAssociatedWithVirtualWan: VirtualWan
    VirtualWanVpnServerConfigurationVpnProfiles: VirtualWan
directive:
  # [General]: rename Operation to RestApi
  - rename-model:
      from: Operation
      to: RestApi
  # bastionHost.json
  - from: swagger-document
    where: $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}/createShareableLinks"].post.operationId
    transform: return "BastionShareableLinks_Put"
    reason: Original 'operationId' doesn't follow pattern
  - from: swagger-document
    where: $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}/deleteShareableLinks"].post.operationId
    transform: return "BastionShareableLinks_Delete"
    reason: Original 'operationId' doesn't follow pattern
  - from: swagger-document
    where: $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}/getShareableLinks"].post.operationId
    transform: return "BastionShareableLinks_List"
    reason: Original 'operationId' doesn't follow pattern
  - from: swagger-document
    where: $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}/getActiveSessions"].post.operationId
    transform: return "ActiveSessions_List"
    reason: Original 'operationId' doesn't follow pattern
  - from: swagger-document
    where: $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/bastionHosts/{bastionHostName}/disconnectActiveSessions"].post.operationId
    transform: return "ActiveSessions_Disconnect"
    reason: Original 'operationId' doesn't follow pattern
  - from: swagger-document
    where: $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/locations/{location}/availableDelegations"].get.operationId
    transform: return "AvailableDelegations_ListByResourceGroup"
    reason: Original 'operationId' is not good, it's actually returned the same type resource but under different context
  # checkDnsAvailability.json
  - from: swagger-document
    where: $.paths["/subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/CheckDnsNameAvailability"].get.operationId
    transform: return "DnsNameAvailabilities_Check"
    reason: Original 'operationId' doesn't follow pattern
  # virtualWan.json
  - from: swagger-document
    where: $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{virtualWANName}/supportedSecurityProviders"].get.operationId
    transform: return "SupportedSecurityProviders_List"
    reason: Original 'operationId' doesn't follow pattern
  - from: swagger-document
    where: $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{virtualWANName}/GenerateVpnProfile"].post.operationId
    transform: return "VirtualWanVpnServerConfigurationVpnProfiles_Generate"
    reason: Original 'operationId' doesn't follow pattern
  - from: swagger-document
    where: $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}"].get.operationId
    transform: return "VirtualHubBgpConnections_Get"
    reason: Original 'operationId' doesn't follow pattern
  - from: swagger-document
    where: $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}"].put.operationId
    transform: return "VirtualHubBgpConnections_CreateOrUpdate"
    reason: Original 'operationId' doesn't follow pattern
  - from: swagger-document
    where: $.paths["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/bgpConnections/{connectionName}"].delete.operationId
    transform: return "VirtualHubBgpConnections_Delete"
    reason: Original 'operationId' doesn't follow pattern
```

### Tag: package-2021-02-preview

These settings apply only when `--tag=package-2021-02-preview` is specified on the command line.

```yaml $(tag) == 'package-2021-02-preview'
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/applicationGateway.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/applicationSecurityGroup.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/availableDelegations.json
  # - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/availableServiceAliases.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/azureFirewall.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/azureFirewallFqdnTag.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/azureWebCategory.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/bastionHost.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/checkDnsAvailability.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/cloudServiceNetworkInterface.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/cloudServicePublicIpAddress.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/customIpPrefix.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/ddosCustomPolicy.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/ddosProtectionPlan.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/dscpConfiguration.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/endpointService.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/expressRouteCircuit.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/expressRouteCrossConnection.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/expressRoutePort.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/firewallPolicy.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/ipAllocation.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/ipGroups.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/loadBalancer.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/natGateway.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/network.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/networkInterface.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/networkProfile.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/networkSecurityGroup.json
  # - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/networkVirtualAppliance.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/networkWatcher.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/operation.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/privateEndpoint.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/privateLinkService.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/publicIpAddress.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/publicIpPrefix.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/routeFilter.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/routeTable.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/securityPartnerProvider.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/serviceCommunity.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/serviceEndpointPolicy.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/serviceTags.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/usage.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/virtualNetwork.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/virtualNetworkGateway.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/virtualNetworkTap.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/virtualRouter.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/virtualWan.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/vmssNetworkInterface.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/vmssPublicIpAddress.json
  - https://github.com/Azure/azure-rest-api-specs/blob/master/specification/network/resource-manager/Microsoft.Network/stable/2021-02-01/webapplicationfirewall.json
```
