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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Gets the route table summary associated with the express route cross connection in a resource group. </summary>
    public partial class ExpressRouteCrossConnectionsListRoutesTableSummaryOperation : Operation<ExpressRouteCrossConnectionsRoutesTableSummaryListResult>, IOperationSource<ExpressRouteCrossConnectionsRoutesTableSummaryListResult>
    {
        private readonly OperationInternals<ExpressRouteCrossConnectionsRoutesTableSummaryListResult> _operation;

        /// <summary> Initializes a new instance of ExpressRouteCrossConnectionsListRoutesTableSummaryOperation for mocking. </summary>
        protected ExpressRouteCrossConnectionsListRoutesTableSummaryOperation()
        {
        }

        internal ExpressRouteCrossConnectionsListRoutesTableSummaryOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ExpressRouteCrossConnectionsRoutesTableSummaryListResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ExpressRouteCrossConnectionsListRoutesTableSummaryOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ExpressRouteCrossConnectionsRoutesTableSummaryListResult Value => _operation.Value;

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
        public override ValueTask<Response<ExpressRouteCrossConnectionsRoutesTableSummaryListResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ExpressRouteCrossConnectionsRoutesTableSummaryListResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ExpressRouteCrossConnectionsRoutesTableSummaryListResult IOperationSource<ExpressRouteCrossConnectionsRoutesTableSummaryListResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ExpressRouteCrossConnectionsRoutesTableSummaryListResult.DeserializeExpressRouteCrossConnectionsRoutesTableSummaryListResult(document.RootElement);
        }

        async ValueTask<ExpressRouteCrossConnectionsRoutesTableSummaryListResult> IOperationSource<ExpressRouteCrossConnectionsRoutesTableSummaryListResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ExpressRouteCrossConnectionsRoutesTableSummaryListResult.DeserializeExpressRouteCrossConnectionsRoutesTableSummaryListResult(document.RootElement);
        }
    }
}
