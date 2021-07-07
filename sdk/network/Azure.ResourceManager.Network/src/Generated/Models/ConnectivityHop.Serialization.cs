// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectivityHop
    {
        internal static ConnectivityHop DeserializeConnectivityHop(JsonElement element)
        {
            Optional<string> type = default;
            Optional<string> address = default;
            Optional<string> resourceId = default;
            Optional<IReadOnlyList<string>> nextHopIds = default;
            Optional<IReadOnlyList<string>> previousHopIds = default;
            Optional<IReadOnlyList<HopLink>> links = default;
            Optional<IReadOnlyList<HopLink>> previousLinks = default;
            Optional<IReadOnlyList<ConnectivityIssue>> issues = default;
            ResourceIdentifier id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextHopIds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    nextHopIds = array;
                    continue;
                }
                if (property.NameEquals("previousHopIds"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    previousHopIds = array;
                    continue;
                }
                if (property.NameEquals("links"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HopLink> array = new List<HopLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HopLink.DeserializeHopLink(item));
                    }
                    links = array;
                    continue;
                }
                if (property.NameEquals("previousLinks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HopLink> array = new List<HopLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HopLink.DeserializeHopLink(item));
                    }
                    previousLinks = array;
                    continue;
                }
                if (property.NameEquals("issues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConnectivityIssue> array = new List<ConnectivityIssue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectivityIssue.DeserializeConnectivityIssue(item));
                    }
                    issues = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new ConnectivityHop(id, type.Value, address.Value, resourceId.Value, Optional.ToList(nextHopIds), Optional.ToList(previousHopIds), Optional.ToList(links), Optional.ToList(previousLinks), Optional.ToList(issues));
        }
    }
}
