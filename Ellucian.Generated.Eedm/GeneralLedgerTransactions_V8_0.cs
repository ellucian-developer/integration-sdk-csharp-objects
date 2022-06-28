// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details of transactions to be entered into the general ledger.
    /// </summary>
    [DataContract]
    public class GeneralLedgerTransactions_V8_0 : BaseModel2
    {
        /////<summary>
        ///// The global identifier of the general ledger transaction.
        /////</summary>
        //[JsonProperty("id")]
        //public string Id { get; set; }

        /// <summary>
        /// An indicator that specifies if the authoritative source should just validate
        /// the accounting string or if it should post/update a general ledger transaction.
        /// </summary>
        [JsonProperty("processMode")]
        public ProcessMode? ProcessMode { get; set; }

        /// <summary>
        /// The person submitting the general ledger transactions.
        /// </summary>
        [DataMember(Name = "submittedBy", EmitDefaultValue = false)]
        public GuidObject2 SubmittedBy { get; set; }
        
        /// <summary>
        /// A list of associated general ledger transactions.
        /// </summary>
        [JsonProperty("transactions")]
        public List<GeneralLedgerTransactionDtoProperty2> Transactions { get; set; }

        /// <summary>
        /// General Ledger Transactions constructor
        /// </summary>
        public GeneralLedgerTransactions_V8_0()
        {
        }
    }
}