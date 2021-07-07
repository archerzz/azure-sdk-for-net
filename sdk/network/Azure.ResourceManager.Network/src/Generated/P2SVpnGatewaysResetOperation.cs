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
    /// <summary> Resets the primary of the p2s vpn gateway in the specified resource group. </summary>
    public partial class P2SVpnGatewaysResetOperation : Operation<P2SVpnGatewayData>, IOperationSource<P2SVpnGatewayData>
    {
        private readonly OperationInternals<P2SVpnGatewayData> _operation;

        /// <summary> Initializes a new instance of P2SVpnGatewaysResetOperation for mocking. </summary>
        protected P2SVpnGatewaysResetOperation()
        {
        }

        internal P2SVpnGatewaysResetOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<P2SVpnGatewayData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "P2SVpnGatewaysResetOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override P2SVpnGatewayData Value => _operation.Value;

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
        public override ValueTask<Response<P2SVpnGatewayData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<P2SVpnGatewayData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        P2SVpnGatewayData IOperationSource<P2SVpnGatewayData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return P2SVpnGatewayData.DeserializeP2SVpnGatewayData(document.RootElement);
        }

        async ValueTask<P2SVpnGatewayData> IOperationSource<P2SVpnGatewayData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return P2SVpnGatewayData.DeserializeP2SVpnGatewayData(document.RootElement);
        }
    }
}
