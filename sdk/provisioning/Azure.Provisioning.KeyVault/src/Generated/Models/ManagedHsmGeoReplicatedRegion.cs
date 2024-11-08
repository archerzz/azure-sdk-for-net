// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.KeyVault;

/// <summary>
/// A region that this managed HSM Pool has been extended to.
/// </summary>
public partial class ManagedHsmGeoReplicatedRegion : ProvisionableConstruct
{
    /// <summary>
    /// Name of the geo replicated region.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Provisioning state of the geo replicated region.
    /// </summary>
    public BicepValue<ManagedHsmGeoReplicatedRegionProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<ManagedHsmGeoReplicatedRegionProvisioningState>? _provisioningState;

    /// <summary>
    /// A boolean value that indicates whether the region is the primary region
    /// or a secondary region.
    /// </summary>
    public BicepValue<bool> IsPrimary 
    {
        get { Initialize(); return _isPrimary!; }
        set { Initialize(); _isPrimary!.Assign(value); }
    }
    private BicepValue<bool>? _isPrimary;

    /// <summary>
    /// Creates a new ManagedHsmGeoReplicatedRegion.
    /// </summary>
    public ManagedHsmGeoReplicatedRegion()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagedHsmGeoReplicatedRegion.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
        _provisioningState = DefineProperty<ManagedHsmGeoReplicatedRegionProvisioningState>("ProvisioningState", ["provisioningState"], isOutput: true);
        _isPrimary = DefineProperty<bool>("IsPrimary", ["isPrimary"]);
    }
}
