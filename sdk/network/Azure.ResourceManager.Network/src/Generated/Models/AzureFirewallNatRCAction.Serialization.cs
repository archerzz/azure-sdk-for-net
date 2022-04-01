// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class AzureFirewallNatRCAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RCActionType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(RCActionType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AzureFirewallNatRCAction DeserializeAzureFirewallNatRCAction(JsonElement element)
        {
            Optional<AzureFirewallNatRCActionType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new AzureFirewallNatRCActionType(property.Value.GetString());
                    continue;
                }
            }
            return new AzureFirewallNatRCAction(Optional.ToNullable(type));
        }
    }
}
