// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The network properties. </summary>
    public partial class HDInsightClusterNetworkProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterNetworkProperties"/>. </summary>
        public HDInsightClusterNetworkProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterNetworkProperties"/>. </summary>
        /// <param name="outboundDependenciesManagedType"> A value to describe how the outbound dependencies of a HDInsight cluster are managed. 'Managed' means that the outbound dependencies are managed by the HDInsight service. 'External' means that the outbound dependencies are managed by a customer specific solution. </param>
        /// <param name="resourceProviderConnection"> The direction for the resource provider connection. </param>
        /// <param name="privateLink"> Indicates whether or not private link is enabled. </param>
        /// <param name="publicIPTag"> Gets or sets the IP tag for the public IPs created along with the HDInsight Clusters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightClusterNetworkProperties(OutboundDependenciesManagedType? outboundDependenciesManagedType, HDInsightResourceProviderConnection? resourceProviderConnection, HDInsightPrivateLinkState? privateLink, HDInsightClusterIPTag publicIPTag, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OutboundDependenciesManagedType = outboundDependenciesManagedType;
            ResourceProviderConnection = resourceProviderConnection;
            PrivateLink = privateLink;
            PublicIPTag = publicIPTag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A value to describe how the outbound dependencies of a HDInsight cluster are managed. 'Managed' means that the outbound dependencies are managed by the HDInsight service. 'External' means that the outbound dependencies are managed by a customer specific solution. </summary>
        public OutboundDependenciesManagedType? OutboundDependenciesManagedType { get; set; }
        /// <summary> The direction for the resource provider connection. </summary>
        public HDInsightResourceProviderConnection? ResourceProviderConnection { get; set; }
        /// <summary> Indicates whether or not private link is enabled. </summary>
        public HDInsightPrivateLinkState? PrivateLink { get; set; }
        /// <summary> Gets or sets the IP tag for the public IPs created along with the HDInsight Clusters. </summary>
        public HDInsightClusterIPTag PublicIPTag { get; set; }
    }
}
