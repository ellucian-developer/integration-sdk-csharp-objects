// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The target towards which payroll deductions are requested.
    /// </summary>
    [DataContract]
    public class PaymentTargetDtoProperty
    {
        /// <summary>
        /// The commitment and type of commitment made.
        /// </summary>
        [JsonProperty("commitment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PaymentTargetCommitment Commitment { get; set; }

        /// <summary>
        /// Payroll deduction for HSA, dining, parking, wage garnishments, etc.
        /// </summary>
        [JsonProperty("deduction", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PaymentTargetDeduction Deduction { get; set; }
    }

    /// <summary>
    /// The commitment and type of commitment made.
    /// </summary>
    [DataContract]
    public class PaymentTargetCommitment
    {
        /// <summary>
        /// The contribution (pledge/recurring donation) for which the payroll deduction is requested
        /// </summary>
        [JsonProperty("contribution", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Contribution { get; set; }

        /// <summary>
        /// The reason for a payroll deduction request.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CommitmentTypes? Type { get; set; }
    }

    /// <summary>
    /// Payroll deduction for HSA, dining, parking, wage garnishments, etc.
    /// </summary>
    [DataContract]
    public class PaymentTargetDeduction
    {
        /// <summary>
        /// Payroll deduction for HSA, dining, parking, wage garnishments, etc.
        /// </summary>
        [JsonProperty("deductionType")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 DeductionType { get; set; }
    }
}