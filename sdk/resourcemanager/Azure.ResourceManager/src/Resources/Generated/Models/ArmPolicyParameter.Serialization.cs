// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmPolicyParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicyParameterType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(PolicyParameterType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AllowedValues))
            {
                writer.WritePropertyName("allowedValues");
                writer.WriteStartArray();
                foreach (var item in AllowedValues)
                {
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultValue))
            {
                writer.WritePropertyName("defaultValue");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DefaultValue);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(DefaultValue.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteObjectValue(Metadata);
            }
            writer.WriteEndObject();
        }

        internal static ArmPolicyParameter DeserializeArmPolicyParameter(JsonElement element)
        {
            Optional<ArmPolicyParameterType> type = default;
            Optional<IList<BinaryData>> allowedValues = default;
            Optional<BinaryData> defaultValue = default;
            Optional<ParameterDefinitionsValueMetadata> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ArmPolicyParameterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowedValues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryData.FromString(item.GetRawText()));
                    }
                    allowedValues = array;
                    continue;
                }
                if (property.NameEquals("defaultValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultValue = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metadata = ParameterDefinitionsValueMetadata.DeserializeParameterDefinitionsValueMetadata(property.Value);
                    continue;
                }
            }
            return new ArmPolicyParameter(Optional.ToNullable(type), Optional.ToList(allowedValues), defaultValue.Value, metadata.Value);
        }
    }
}
