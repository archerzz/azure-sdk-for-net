// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Create or update a connection monitor. </summary>
    public partial class ConnectionMonitorsCreateOrUpdateOperation : Operation<ConnectionMonitor>, IOperationSource<ConnectionMonitor>
    {
        private readonly OperationInternals<ConnectionMonitor> _operation;

        private readonly OperationsBase _operationBase;

        /// <summary> Initializes a new instance of ConnectionMonitorsCreateOrUpdateOperation for mocking. </summary>
        protected ConnectionMonitorsCreateOrUpdateOperation()
        {
        }

        internal ConnectionMonitorsCreateOrUpdateOperation(OperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ConnectionMonitor>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "ConnectionMonitorsCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ConnectionMonitor Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ConnectionMonitor>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ConnectionMonitor>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ConnectionMonitor IOperationSource<ConnectionMonitor>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new ConnectionMonitor(_operationBase, ConnectionMonitorData.DeserializeConnectionMonitorData(document.RootElement));
        }

        async ValueTask<ConnectionMonitor> IOperationSource<ConnectionMonitor>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new ConnectionMonitor(_operationBase, ConnectionMonitorData.DeserializeConnectionMonitorData(document.RootElement));
        }
    }
}
