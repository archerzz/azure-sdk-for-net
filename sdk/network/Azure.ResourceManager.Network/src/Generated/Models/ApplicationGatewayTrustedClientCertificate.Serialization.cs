// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayTrustedClientCertificate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Data))
            {
                writer.WritePropertyName("data");
                writer.WriteStringValue(Data);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayTrustedClientCertificate DeserializeApplicationGatewayTrustedClientCertificate(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            ResourceIdentifier id = default;
            Optional<string> data = default;
            Optional<string> validatedCertData = default;
            Optional<string> clientCertIssuerDN = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("data"))
                        {
                            data = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("validatedCertData"))
                        {
                            validatedCertData = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientCertIssuerDN"))
                        {
                            clientCertIssuerDN = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewayTrustedClientCertificate(id, name.Value, etag.Value, type.Value, data.Value, validatedCertData.Value, clientCertIssuerDN.Value, Optional.ToNullable(provisioningState));
        }
    }
}
