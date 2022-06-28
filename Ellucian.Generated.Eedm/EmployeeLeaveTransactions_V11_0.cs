//Copyright 2017 Ellucian Company L.P.and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information on recorded transactions for leaves taken by employees. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class EmployeeLeaveTransactions_V11_0 : BaseModel2
    {
        /// <summary>
        /// The leave plan for which the transaction occurred.
        /// </summary>

        [JsonProperty("employeeLeave", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 EmployeeLeave { get; set; }

        /// <summary>
        /// The date of the transaction.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("transactionDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// The number of hours accrued for leave.
        /// </summary>

        [JsonProperty("accrued", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Accrued { get; set; }

        /// <summary>
        /// The number of hours taken for leave.
        /// </summary>

        [JsonProperty("taken", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Taken { get; set; }

        /// <summary>
        /// The number of hours available for leave.
        /// </summary>

        [JsonProperty("available", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Available { get; set; }

    }
}
