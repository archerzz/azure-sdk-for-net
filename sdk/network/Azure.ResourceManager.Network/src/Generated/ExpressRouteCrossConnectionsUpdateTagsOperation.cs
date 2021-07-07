// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Updates an express route cross connection tags. </summary>
    public partial class ExpressRouteCrossConnectionsUpdateTagsOperation : Operation<ExpressRouteCrossConnection>
    {
        private readonly OperationOrResponseInternals<ExpressRouteCrossConnection> _operation;

        /// <summary> Initializes a new instance of ExpressRouteCrossConnectionsUpdateTagsOperation for mocking. </summary>
        protected ExpressRouteCrossConnectionsUpdateTagsOperation()
        {
        }

        internal ExpressRouteCrossConnectionsUpdateTagsOperation(OperationsBase operationsBase, Response<ExpressRouteCrossConnectionData> response)
        {
            _operation = new OperationOrResponseInternals<ExpressRouteCrossConnection>(Response.FromValue(new ExpressRouteCrossConnection(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ExpressRouteCrossConnection Value => _operation.Value;

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
        public override ValueTask<Response<ExpressRouteCrossConnection>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ExpressRouteCrossConnection>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
