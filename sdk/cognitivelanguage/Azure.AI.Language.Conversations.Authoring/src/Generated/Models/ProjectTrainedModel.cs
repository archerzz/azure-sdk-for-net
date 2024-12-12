// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    /// <summary> Represents a trained model. </summary>
    public partial class ProjectTrainedModel
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProjectTrainedModel"/>. </summary>
        /// <param name="modelId"> The model ID. </param>
        /// <param name="lastTrainedDateTime"> The last trained date time of the model. </param>
        /// <param name="lastTrainingDurationInSeconds"> The duration of the model's last training request in seconds. </param>
        /// <param name="modelExpirationDate"> The model expiration date. </param>
        /// <param name="modelTrainingConfigVersion"> The model training config version. </param>
        /// <param name="hasSnapshot"> The flag to indicate if the trained model has a snapshot ready. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> or <paramref name="modelTrainingConfigVersion"/> is null. </exception>
        internal ProjectTrainedModel(string modelId, DateTimeOffset lastTrainedDateTime, int lastTrainingDurationInSeconds, DateTimeOffset modelExpirationDate, string modelTrainingConfigVersion, bool hasSnapshot)
        {
            Argument.AssertNotNull(modelId, nameof(modelId));
            Argument.AssertNotNull(modelTrainingConfigVersion, nameof(modelTrainingConfigVersion));

            ModelId = modelId;
            LastTrainedDateTime = lastTrainedDateTime;
            LastTrainingDurationInSeconds = lastTrainingDurationInSeconds;
            ModelExpirationDate = modelExpirationDate;
            ModelTrainingConfigVersion = modelTrainingConfigVersion;
            HasSnapshot = hasSnapshot;
        }

        /// <summary> Initializes a new instance of <see cref="ProjectTrainedModel"/>. </summary>
        /// <param name="label"> The trained model label. </param>
        /// <param name="modelId"> The model ID. </param>
        /// <param name="lastTrainedDateTime"> The last trained date time of the model. </param>
        /// <param name="lastTrainingDurationInSeconds"> The duration of the model's last training request in seconds. </param>
        /// <param name="modelExpirationDate"> The model expiration date. </param>
        /// <param name="modelTrainingConfigVersion"> The model training config version. </param>
        /// <param name="hasSnapshot"> The flag to indicate if the trained model has a snapshot ready. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProjectTrainedModel(string label, string modelId, DateTimeOffset lastTrainedDateTime, int lastTrainingDurationInSeconds, DateTimeOffset modelExpirationDate, string modelTrainingConfigVersion, bool hasSnapshot, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Label = label;
            ModelId = modelId;
            LastTrainedDateTime = lastTrainedDateTime;
            LastTrainingDurationInSeconds = lastTrainingDurationInSeconds;
            ModelExpirationDate = modelExpirationDate;
            ModelTrainingConfigVersion = modelTrainingConfigVersion;
            HasSnapshot = hasSnapshot;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ProjectTrainedModel"/> for deserialization. </summary>
        internal ProjectTrainedModel()
        {
        }

        /// <summary> The trained model label. </summary>
        public string Label { get; }
        /// <summary> The model ID. </summary>
        public string ModelId { get; }
        /// <summary> The last trained date time of the model. </summary>
        public DateTimeOffset LastTrainedDateTime { get; }
        /// <summary> The duration of the model's last training request in seconds. </summary>
        public int LastTrainingDurationInSeconds { get; }
        /// <summary> The model expiration date. </summary>
        public DateTimeOffset ModelExpirationDate { get; }
        /// <summary> The model training config version. </summary>
        public string ModelTrainingConfigVersion { get; }
        /// <summary> The flag to indicate if the trained model has a snapshot ready. </summary>
        public bool HasSnapshot { get; }
    }
}
