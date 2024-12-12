// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    public partial class OrchestrationExportedProjectAssets : IUtf8JsonSerializable, IJsonModel<OrchestrationExportedProjectAssets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OrchestrationExportedProjectAssets>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OrchestrationExportedProjectAssets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrchestrationExportedProjectAssets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrchestrationExportedProjectAssets)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(Intents))
            {
                writer.WritePropertyName("intents"u8);
                writer.WriteStartArray();
                foreach (var item in Intents)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Utterances))
            {
                writer.WritePropertyName("utterances"u8);
                writer.WriteStartArray();
                foreach (var item in Utterances)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        OrchestrationExportedProjectAssets IJsonModel<OrchestrationExportedProjectAssets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrchestrationExportedProjectAssets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OrchestrationExportedProjectAssets)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOrchestrationExportedProjectAssets(document.RootElement, options);
        }

        internal static OrchestrationExportedProjectAssets DeserializeOrchestrationExportedProjectAssets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<OrchestrationExportedIntent> intents = default;
            IList<OrchestrationExportedUtterance> utterances = default;
            ProjectKind projectKind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("intents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OrchestrationExportedIntent> array = new List<OrchestrationExportedIntent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OrchestrationExportedIntent.DeserializeOrchestrationExportedIntent(item, options));
                    }
                    intents = array;
                    continue;
                }
                if (property.NameEquals("utterances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OrchestrationExportedUtterance> array = new List<OrchestrationExportedUtterance>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OrchestrationExportedUtterance.DeserializeOrchestrationExportedUtterance(item, options));
                    }
                    utterances = array;
                    continue;
                }
                if (property.NameEquals("projectKind"u8))
                {
                    projectKind = new ProjectKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OrchestrationExportedProjectAssets(projectKind, serializedAdditionalRawData, intents ?? new ChangeTrackingList<OrchestrationExportedIntent>(), utterances ?? new ChangeTrackingList<OrchestrationExportedUtterance>());
        }

        BinaryData IPersistableModel<OrchestrationExportedProjectAssets>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrchestrationExportedProjectAssets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OrchestrationExportedProjectAssets)} does not support writing '{options.Format}' format.");
            }
        }

        OrchestrationExportedProjectAssets IPersistableModel<OrchestrationExportedProjectAssets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OrchestrationExportedProjectAssets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOrchestrationExportedProjectAssets(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OrchestrationExportedProjectAssets)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OrchestrationExportedProjectAssets>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new OrchestrationExportedProjectAssets FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOrchestrationExportedProjectAssets(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
