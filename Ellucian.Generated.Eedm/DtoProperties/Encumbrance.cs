using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The encumbrance associated with this transaction.
    /// </summary>
    [DataContract]
    public class Encumbrance
    {
        /// <summary>
        /// The line item number.
        /// </summary>
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// The line item number.
        /// </summary>
        [JsonProperty("lineItemNumber", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public int? LineItemNumber { get; set; }

        /// <summary>
        /// The sequence number of the accounting string.
        /// </summary>
        [JsonProperty("sequenceNumber", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// The adjustment type for the encumbrance.
        /// </summary>
        [JsonProperty("adjustmentType", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public AdjustmentType? AdjustmentType { get; set; }

        /// <summary>
        /// The type of commitment (committed or uncommitted).
        /// </summary>
        [JsonProperty("commitmentType", DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public CommitmentType? CommitmentType { get; set; }
    }
}