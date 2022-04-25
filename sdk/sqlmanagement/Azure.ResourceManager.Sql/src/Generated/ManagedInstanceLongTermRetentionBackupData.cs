// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ManagedInstanceLongTermRetentionBackup data model. </summary>
    public partial class ManagedInstanceLongTermRetentionBackupData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagedInstanceLongTermRetentionBackupData. </summary>
        public ManagedInstanceLongTermRetentionBackupData()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstanceLongTermRetentionBackupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="managedInstanceName"> The managed instance that the backup database belongs to. </param>
        /// <param name="managedInstanceCreateOn"> The create time of the instance. </param>
        /// <param name="databaseName"> The name of the database the backup belong to. </param>
        /// <param name="databaseDeletionOn"> The delete time of the database. </param>
        /// <param name="backupOn"> The time the backup was taken. </param>
        /// <param name="backupExpirationOn"> The time the long term retention backup will expire. </param>
        /// <param name="backupStorageRedundancy"> The storage redundancy type of the backup. </param>
        internal ManagedInstanceLongTermRetentionBackupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string managedInstanceName, DateTimeOffset? managedInstanceCreateOn, string databaseName, DateTimeOffset? databaseDeletionOn, DateTimeOffset? backupOn, DateTimeOffset? backupExpirationOn, BackupStorageRedundancy? backupStorageRedundancy) : base(id, name, resourceType, systemData)
        {
            ManagedInstanceName = managedInstanceName;
            ManagedInstanceCreateOn = managedInstanceCreateOn;
            DatabaseName = databaseName;
            DatabaseDeletionOn = databaseDeletionOn;
            BackupOn = backupOn;
            BackupExpirationOn = backupExpirationOn;
            BackupStorageRedundancy = backupStorageRedundancy;
        }

        /// <summary> The managed instance that the backup database belongs to. </summary>
        public string ManagedInstanceName { get; }
        /// <summary> The create time of the instance. </summary>
        public DateTimeOffset? ManagedInstanceCreateOn { get; }
        /// <summary> The name of the database the backup belong to. </summary>
        public string DatabaseName { get; }
        /// <summary> The delete time of the database. </summary>
        public DateTimeOffset? DatabaseDeletionOn { get; }
        /// <summary> The time the backup was taken. </summary>
        public DateTimeOffset? BackupOn { get; }
        /// <summary> The time the long term retention backup will expire. </summary>
        public DateTimeOffset? BackupExpirationOn { get; }
        /// <summary> The storage redundancy type of the backup. </summary>
        public BackupStorageRedundancy? BackupStorageRedundancy { get; }
    }
}
