// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Subject named query
    /// </summary>
    public class PayrollDeductionArrangementsFilter
    {
        /// <summary>
        /// The employee for whom the payroll deduction is requested.
        /// </summary>
        [JsonProperty("person")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The target towards which payroll deductions are requested.
        /// </summary>
        [JsonProperty("paymentTarget")]
        public PaymentTargetDtoProperty PaymentTarget { get; set; }

        /// <summary>
        /// The contribution (pledge/recurring donation) for which the payroll deduction is requested
        /// </summary>
        [JsonProperty("contribution")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Contribution { get; set; }

        /// <summary>
        /// Payroll deduction for HSA, dining, parking, wage garnishments, etc.
        /// </summary>
        [JsonProperty("deductionType")]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 DeductionType { get; set; }

        /// <summary>
        /// The status of a payroll deduction request.
        /// </summary>
        [JsonProperty("status")]
        [FilterProperty("criteria")]
        public PayrollDeductionArrangementStatuses? Status { get; set; }
    }
}
