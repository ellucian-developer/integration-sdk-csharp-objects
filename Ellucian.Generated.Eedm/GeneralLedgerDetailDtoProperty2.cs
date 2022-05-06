// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The detailed accounting lines associated with the transaction.
    /// </summary>
    [DataContract]
    public class GeneralLedgerDetailDtoProperty2
    {
        /// <summary>
        /// An optional tracking number for the detailed accounting line.
        /// </summary>
        [JsonProperty("sequenceNumber", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// The accounting string associated with the transaction detail line.
        /// </summary>
        [JsonProperty("accountingString")]
        public string AccountingString { get; set; }

        /// <summary>
        /// The description of the detailed accounting line.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The type of detailed accounting line (credit/debit).
        /// </summary>
        [JsonProperty("type")]
        public CreditOrDebit? Type { get; set; }

        /// <summary>
        /// The amount of the credit or debit.
        /// </summary>
        [JsonProperty("amount")]
        public AmountDtoProperty Amount { get; set; }

        /// <summary>
        /// The person submitting the general ledger transactions.
        /// </summary>
        [JsonProperty("submittedBy", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 SubmittedBy { get; set; }
        
    }
}