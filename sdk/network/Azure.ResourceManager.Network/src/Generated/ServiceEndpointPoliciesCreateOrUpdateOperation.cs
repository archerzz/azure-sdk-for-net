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
    /// <summary> Creates or updates a service Endpoint Policies. </summary>
    public partial class ServiceEndpointPoliciesCreateOrUpdateOperation : Operation<ServiceEndpointPolicy>, IOperationSource<ServiceEndpointPolicy>
    {
        private readonly OperationInternals<ServiceEndpointPolicy> _operation;

        private readonly OperationsBase _operationBase;

        /// <summary> Initializes a new instance of ServiceEndpointPoliciesCreateOrUpdateOperation for mocking. </summary>
        protected ServiceEndpointPoliciesCreateOrUpdateOperation()
        {
        }

        internal ServiceEndpointPoliciesCreateOrUpdateOperation(OperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ServiceEndpointPolicy>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "ServiceEndpointPoliciesCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ServiceEndpointPolicy Value => _operation.Value;

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
        public override ValueTask<Response<ServiceEndpointPolicy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServiceEndpointPolicy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ServiceEndpointPolicy IOperationSource<ServiceEndpointPolicy>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new ServiceEndpointPolicy(_operationBase, ServiceEndpointPolicyData.DeserializeServiceEndpointPolicyData(document.RootElement));
        }

        async ValueTask<ServiceEndpointPolicy> IOperationSource<ServiceEndpointPolicy>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new ServiceEndpointPolicy(_operationBase, ServiceEndpointPolicyData.DeserializeServiceEndpointPolicyData(document.RootElement));
        }
    }
}
