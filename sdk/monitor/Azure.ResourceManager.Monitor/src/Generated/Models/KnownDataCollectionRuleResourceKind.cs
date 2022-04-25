// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The kind of the resource. </summary>
    public readonly partial struct KnownDataCollectionRuleResourceKind : IEquatable<KnownDataCollectionRuleResourceKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KnownDataCollectionRuleResourceKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KnownDataCollectionRuleResourceKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LinuxValue = "Linux";
        private const string WindowsValue = "Windows";

        /// <summary> Linux. </summary>
        public static KnownDataCollectionRuleResourceKind Linux { get; } = new KnownDataCollectionRuleResourceKind(LinuxValue);
        /// <summary> Windows. </summary>
        public static KnownDataCollectionRuleResourceKind Windows { get; } = new KnownDataCollectionRuleResourceKind(WindowsValue);
        /// <summary> Determines if two <see cref="KnownDataCollectionRuleResourceKind"/> values are the same. </summary>
        public static bool operator ==(KnownDataCollectionRuleResourceKind left, KnownDataCollectionRuleResourceKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KnownDataCollectionRuleResourceKind"/> values are not the same. </summary>
        public static bool operator !=(KnownDataCollectionRuleResourceKind left, KnownDataCollectionRuleResourceKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KnownDataCollectionRuleResourceKind"/>. </summary>
        public static implicit operator KnownDataCollectionRuleResourceKind(string value) => new KnownDataCollectionRuleResourceKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KnownDataCollectionRuleResourceKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KnownDataCollectionRuleResourceKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
