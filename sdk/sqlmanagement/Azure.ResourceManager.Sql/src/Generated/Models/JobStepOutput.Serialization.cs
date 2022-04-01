// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class JobStepOutput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StepOutputType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(StepOutputType.Value.ToString());
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId");
                writer.WriteStringValue(SubscriptionId.Value);
            }
            if (Optional.IsDefined(ResourceGroupName))
            {
                writer.WritePropertyName("resourceGroupName");
                writer.WriteStringValue(ResourceGroupName);
            }
            writer.WritePropertyName("serverName");
            writer.WriteStringValue(ServerName);
            writer.WritePropertyName("databaseName");
            writer.WriteStringValue(DatabaseName);
            if (Optional.IsDefined(SchemaName))
            {
                writer.WritePropertyName("schemaName");
                writer.WriteStringValue(SchemaName);
            }
            writer.WritePropertyName("tableName");
            writer.WriteStringValue(TableName);
            writer.WritePropertyName("credential");
            writer.WriteStringValue(Credential);
            writer.WriteEndObject();
        }

        internal static JobStepOutput DeserializeJobStepOutput(JsonElement element)
        {
            Optional<JobStepOutputType> type = default;
            Optional<Guid> subscriptionId = default;
            Optional<string> resourceGroupName = default;
            string serverName = default;
            string databaseName = default;
            Optional<string> schemaName = default;
            string tableName = default;
            string credential = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new JobStepOutputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subscriptionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverName"))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaName"))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tableName"))
                {
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credential"))
                {
                    credential = property.Value.GetString();
                    continue;
                }
            }
            return new JobStepOutput(Optional.ToNullable(type), Optional.ToNullable(subscriptionId), resourceGroupName.Value, serverName, databaseName, schemaName.Value, tableName, credential);
        }
    }
}
