// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Request routing rule of an application gateway. </summary>
    public partial class ApplicationGatewayRequestRoutingRule : WritableSubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of ApplicationGatewayRequestRoutingRule. </summary>
        public ApplicationGatewayRequestRoutingRule()
        {
        }

        /// <summary> Initializes a new instance of ApplicationGatewayRequestRoutingRule. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Name of the request routing rule that is unique within an Application Gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Type of the resource. </param>
        /// <param name="ruleType"> Rule type. </param>
        /// <param name="priority"> Priority of the request routing rule. </param>
        /// <param name="backendAddressPool"> Backend address pool resource of the application gateway. </param>
        /// <param name="backendHttpSettings"> Backend http settings resource of the application gateway. </param>
        /// <param name="httpListener"> Http listener resource of the application gateway. </param>
        /// <param name="urlPathMap"> URL path map resource of the application gateway. </param>
        /// <param name="rewriteRuleSet"> Rewrite Rule Set resource in Basic rule of the application gateway. </param>
        /// <param name="redirectConfiguration"> Redirect configuration resource of the application gateway. </param>
        /// <param name="provisioningState"> The provisioning state of the request routing rule resource. </param>
        internal ApplicationGatewayRequestRoutingRule(string id, string name, string etag, string type, ApplicationGatewayRequestRoutingRuleType? ruleType, int? priority, SubResource backendAddressPool, SubResource backendHttpSettings, SubResource httpListener, SubResource urlPathMap, SubResource rewriteRuleSet, SubResource redirectConfiguration, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            RuleType = ruleType;
            Priority = priority;
            BackendAddressPool = backendAddressPool;
            BackendHttpSettings = backendHttpSettings;
            HttpListener = httpListener;
            UrlPathMap = urlPathMap;
            RewriteRuleSet = rewriteRuleSet;
            RedirectConfiguration = redirectConfiguration;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the request routing rule that is unique within an Application Gateway. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Type of the resource. </summary>
        public string Type { get; }
        /// <summary> Rule type. </summary>
        public ApplicationGatewayRequestRoutingRuleType? RuleType { get; set; }
        /// <summary> Priority of the request routing rule. </summary>
        public int? Priority { get; set; }
        /// <summary> Backend address pool resource of the application gateway. </summary>
        public SubResource BackendAddressPool { get; set; }
        /// <summary> Backend http settings resource of the application gateway. </summary>
        public SubResource BackendHttpSettings { get; set; }
        /// <summary> Http listener resource of the application gateway. </summary>
        public SubResource HttpListener { get; set; }
        /// <summary> URL path map resource of the application gateway. </summary>
        public SubResource UrlPathMap { get; set; }
        /// <summary> Rewrite Rule Set resource in Basic rule of the application gateway. </summary>
        public SubResource RewriteRuleSet { get; set; }
        /// <summary> Redirect configuration resource of the application gateway. </summary>
        public SubResource RedirectConfiguration { get; set; }
        /// <summary> The provisioning state of the request routing rule resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
