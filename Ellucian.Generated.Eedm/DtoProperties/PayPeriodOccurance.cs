// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The target towards which payroll deductions are requested.
    /// </summary>
    [DataContract]
    public class PayPeriodOccurance
    {
        /// <summary>
        /// The number of pay periods between deductions, e.g 1 = every pay period, 2 = every other pay period).
        /// </summary>
        [JsonProperty("interval", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// A list of pay periods during a month when deductions should occur. Use a positive number to count
        /// from the start of the month (e.g., 1 = first pay period of the month, 2 = second pay period of the month),
        /// and a negative number to count from the end of the month (e.g. -1 = last pay period of the month).
        /// </summary>
        [JsonProperty("monthlyPayPeriods", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<int> MonthlyPayPeriods { get; set; }
    }
}