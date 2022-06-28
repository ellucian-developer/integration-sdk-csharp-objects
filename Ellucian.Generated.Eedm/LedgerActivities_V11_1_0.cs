//Copyright 2017-2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The detailed activity that is posted against the ledger. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class LedgerActivities_V11_1_0 : BaseModel2
    {
        /// <summary>
        /// The full name of the ledger activity.
        /// </summary>

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The reporting segment with which the ledger activity is associated (e.g. chart, campus, institution, etc.).
        /// </summary>

        [JsonProperty("reportingSegment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ReportingSegment { get; set; }


        /// <summary>
        /// The ledger type associated with the activity (general or operating)
        /// </summary>

        [JsonProperty("ledgerType", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public LedgerActivityLedgerType? LedgerType { get; set; }


        /// <summary>
        /// The ledger category associated with the activity.
        /// </summary>

        [JsonProperty("ledgerCategory", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LedgerActivityLedgerCategory LedgerCategory { get; set; }

        /// <summary>
        /// The type of financial document associated with the activity.
        /// </summary>

        [JsonProperty("documentType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 DocumentType { get; set; }

        /// <summary>
        /// The type of adjustment (opening balance or year-end adjustment).
        /// </summary>

        [JsonProperty("adjustmentType", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public LedgerActivityAdjustmentType? AdjustmentType { get; set; }

        /// <summary>
        /// The fiscal period during which the activity is posted to the ledger.
        /// </summary>

        [JsonProperty("period", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Period { get; set; }

        /// <summary>
        /// The date the activity is posted to the account in the ledger.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("transactionDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// The date the activity occurred.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("enteredOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime EnteredOn { get; set; }

        /// <summary>
        /// The accounting string associated with the activity.
        /// </summary>

        [JsonProperty("accountingString", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AccountingString { get; set; }

        /// <summary>
        /// The accounting string component values associated with the activity.
        /// </summary>

        [JsonProperty("accountingStringComponentValues", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> AccountingStringComponentValues { get; set; }

        /// <summary>
        /// The reference document number associated with the activity.
        /// </summary>

        [JsonProperty("referenceDocumentNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ReferenceDocumentNumber { get; set; }

        /// <summary>
        /// The person, organization, or institution associated with the activity.
        /// </summary>

        [JsonProperty("reference", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LedgerActivityReference Reference { get; set; }

        /// <summary>
        /// The type of activity.
        /// </summary>

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LedgerActivityType Type { get; set; }

        /// <summary>
        /// The amount associated with the activity.
        /// </summary>

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LedgerActivityAmount Amount { get; set; }

        /// <summary>
        /// The status associated with the activity (posted or pending posting).
        /// </summary>

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public LedgerActivityStatus Status { get; set; }

        /// <summary>
        /// The grant with which the activity is associated.
        /// </summary>

        [JsonProperty("grant", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Grant { get; set; }
    }
}          
