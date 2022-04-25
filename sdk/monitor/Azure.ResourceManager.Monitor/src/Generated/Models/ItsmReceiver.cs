// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> An Itsm receiver. </summary>
    public partial class ItsmReceiver
    {
        /// <summary> Initializes a new instance of ItsmReceiver. </summary>
        /// <param name="name"> The name of the Itsm receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="workspaceId"> OMS LA instance identifier. </param>
        /// <param name="connectionId"> Unique identification of ITSM connection among multiple defined in above workspace. </param>
        /// <param name="ticketConfiguration"> JSON blob for the configurations of the ITSM action. CreateMultipleWorkItems option will be part of this blob as well. </param>
        /// <param name="region"> Region in which workspace resides. Supported values:&apos;centralindia&apos;,&apos;japaneast&apos;,&apos;southeastasia&apos;,&apos;australiasoutheast&apos;,&apos;uksouth&apos;,&apos;westcentralus&apos;,&apos;canadacentral&apos;,&apos;eastus&apos;,&apos;westeurope&apos;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="workspaceId"/>, <paramref name="connectionId"/>, <paramref name="ticketConfiguration"/> or <paramref name="region"/> is null. </exception>
        public ItsmReceiver(string name, string workspaceId, string connectionId, string ticketConfiguration, string region)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (workspaceId == null)
            {
                throw new ArgumentNullException(nameof(workspaceId));
            }
            if (connectionId == null)
            {
                throw new ArgumentNullException(nameof(connectionId));
            }
            if (ticketConfiguration == null)
            {
                throw new ArgumentNullException(nameof(ticketConfiguration));
            }
            if (region == null)
            {
                throw new ArgumentNullException(nameof(region));
            }

            Name = name;
            WorkspaceId = workspaceId;
            ConnectionId = connectionId;
            TicketConfiguration = ticketConfiguration;
            Region = region;
        }

        /// <summary> The name of the Itsm receiver. Names must be unique across all receivers within an action group. </summary>
        public string Name { get; set; }
        /// <summary> OMS LA instance identifier. </summary>
        public string WorkspaceId { get; set; }
        /// <summary> Unique identification of ITSM connection among multiple defined in above workspace. </summary>
        public string ConnectionId { get; set; }
        /// <summary> JSON blob for the configurations of the ITSM action. CreateMultipleWorkItems option will be part of this blob as well. </summary>
        public string TicketConfiguration { get; set; }
        /// <summary> Region in which workspace resides. Supported values:&apos;centralindia&apos;,&apos;japaneast&apos;,&apos;southeastasia&apos;,&apos;australiasoutheast&apos;,&apos;uksouth&apos;,&apos;westcentralus&apos;,&apos;canadacentral&apos;,&apos;eastus&apos;,&apos;westeurope&apos;. </summary>
        public string Region { get; set; }
    }
}
