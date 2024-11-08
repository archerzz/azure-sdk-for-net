// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    internal class PostgreSqlFlexibleServerBackupOperationSource : IOperationSource<PostgreSqlFlexibleServerBackupResource>
    {
        private readonly ArmClient _client;

        internal PostgreSqlFlexibleServerBackupOperationSource(ArmClient client)
        {
            _client = client;
        }

        PostgreSqlFlexibleServerBackupResource IOperationSource<PostgreSqlFlexibleServerBackupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PostgreSqlFlexibleServerBackupData.DeserializePostgreSqlFlexibleServerBackupData(document.RootElement);
            return new PostgreSqlFlexibleServerBackupResource(_client, data);
        }

        async ValueTask<PostgreSqlFlexibleServerBackupResource> IOperationSource<PostgreSqlFlexibleServerBackupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PostgreSqlFlexibleServerBackupData.DeserializePostgreSqlFlexibleServerBackupData(document.RootElement);
            return new PostgreSqlFlexibleServerBackupResource(_client, data);
        }
    }
}
