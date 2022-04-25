// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the capacity reservation group. Only tags can be updated. </summary>
    public partial class CapacityReservationGroupPatch : UpdateResource
    {
        /// <summary> Initializes a new instance of CapacityReservationGroupPatch. </summary>
        public CapacityReservationGroupPatch()
        {
            CapacityReservations = new ChangeTrackingList<Resources.Models.SubResource>();
            VirtualMachinesAssociated = new ChangeTrackingList<Resources.Models.SubResource>();
        }

        /// <summary> A list of all capacity reservation resource ids that belong to capacity reservation group. </summary>
        public IReadOnlyList<Resources.Models.SubResource> CapacityReservations { get; }
        /// <summary> A list of references to all virtual machines associated to the capacity reservation group. </summary>
        public IReadOnlyList<Resources.Models.SubResource> VirtualMachinesAssociated { get; }
        /// <summary> The capacity reservation group instance view which has the list of instance views for all the capacity reservations that belong to the capacity reservation group. </summary>
        internal CapacityReservationGroupInstanceView InstanceView { get; }
        /// <summary> List of instance view of the capacity reservations under the capacity reservation group. </summary>
        public IReadOnlyList<CapacityReservationInstanceViewWithName> InstanceViewCapacityReservations
        {
            get => InstanceView.CapacityReservations;
        }
    }
}
