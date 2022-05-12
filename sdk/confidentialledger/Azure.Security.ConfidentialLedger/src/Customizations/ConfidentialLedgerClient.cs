// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Security.ConfidentialLedger.Models;

namespace Azure.Security.ConfidentialLedger
{
    /// <summary> The ConfidentialLedger service client. </summary>
    public partial class ConfidentialLedgerClient
    {
        /// <summary> LedgerCollection ids are user-created collections of ledger entries. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<LedgerCollection>>> GetCollectionsValueAsync(CancellationToken cancellationToken = default)
        {
            Response response = await GetCollectionsAsync(new RequestContext { CancellationToken = cancellationToken }).ConfigureAwait(false);
            using var document = JsonDocument.Parse(response.ContentStream);

            IReadOnlyList<LedgerCollection> value = default;
            List<LedgerCollection> array = new List<LedgerCollection>();

            foreach (var item in document.RootElement.EnumerateArray())
            {
                array.Add(LedgerCollection.DeserializeCollection(item));
            }

            value = array;
            return Response.FromValue(value, response);
        }

        /// <summary> LedgerCollection ids are user-created collections of ledger entries. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<LedgerCollection>> GetCollectionsValue(CancellationToken cancellationToken = default)
        {
            Response response = GetCollections(new RequestContext { CancellationToken = cancellationToken });
            using var document = JsonDocument.Parse(response.ContentStream);

            IReadOnlyList<LedgerCollection> value = default;
            List<LedgerCollection> array = new List<LedgerCollection>();

            foreach (var item in document.RootElement.EnumerateArray())
            {
                array.Add(LedgerCollection.DeserializeCollection(item));
            }

            value = array;
            return Response.FromValue(value, response);
        }

        /// <summary> The constitution is a script that assesses and applies proposals from consortium members. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LedgerConstitution>> GetConstitutionValueAsync(CancellationToken cancellationToken = default)
        {
            Response response = await GetConstitutionAsync(new RequestContext { CancellationToken = cancellationToken }).ConfigureAwait(false);

            LedgerConstitution constitution = LedgerConstitution.FromResponse(response);

            return Response.FromValue(constitution, response);
        }

        /// <summary> The constitution is a script that assesses and applies proposals from consortium members. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LedgerConstitution> GetConstitutionValue(CancellationToken cancellationToken = default)
        {
            Response response = GetConstitution(new RequestContext { CancellationToken = cancellationToken });

            LedgerConstitution constitution = LedgerConstitution.FromResponse(response);

            return Response.FromValue(constitution, response);
        }

        /// <summary> Gets the status of an entry identified by a transaction id. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="transactionId"/> is null. </exception>

        public virtual async Task<Response<TransactionReceipt>> GetReceiptValueAsync(string transactionId, CancellationToken cancellationToken = default)
        {
            Response response = await GetReceiptAsync(transactionId, new RequestContext { CancellationToken = cancellationToken }).ConfigureAwait(false);

            TransactionReceipt value = TransactionReceipt.FromResponse(response);

            return Response.FromValue(value, response);
        }

        /// <summary> Gets the status of an entry identified by a transaction id. </summary>
        /// <param name="transactionId"> Identifies a write transaction. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="transactionId"/> is null. </exception>
        public virtual Response<TransactionReceipt> GetReceiptValue(string transactionId, CancellationToken cancellationToken = default)
        {
            Response response = GetReceipt(transactionId, new RequestContext { CancellationToken = cancellationToken });

            TransactionReceipt value = TransactionReceipt.FromResponse(response);

            return Response.FromValue(value, response);
        }
    }
}
