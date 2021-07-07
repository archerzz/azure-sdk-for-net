// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class ListVpnServerConfigurationsResult
    {
        internal static ListVpnServerConfigurationsResult DeserializeListVpnServerConfigurationsResult(JsonElement element)
        {
            Optional<IReadOnlyList<VpnServerConfigurationData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VpnServerConfigurationData> array = new List<VpnServerConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VpnServerConfigurationData.DeserializeVpnServerConfigurationData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ListVpnServerConfigurationsResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
