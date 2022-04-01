// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmApplicationDefinitionArtifact : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name.ToString());
            writer.WritePropertyName("uri");
            writer.WriteStringValue(Uri.AbsoluteUri);
            writer.WritePropertyName("type");
            writer.WriteStringValue(ApplicationArtifactType.ToSerialString());
            writer.WriteEndObject();
        }

        internal static ArmApplicationDefinitionArtifact DeserializeArmApplicationDefinitionArtifact(JsonElement element)
        {
            ArmApplicationDefinitionArtifactName name = default;
            Uri uri = default;
            ArmApplicationArtifactType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = new ArmApplicationDefinitionArtifactName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uri"))
                {
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString().ToArmApplicationArtifactType();
                    continue;
                }
            }
            return new ArmApplicationDefinitionArtifact(name, uri, type);
        }
    }
}
