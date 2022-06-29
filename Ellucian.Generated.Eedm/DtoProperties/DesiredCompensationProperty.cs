//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The applicant's desired compensation.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DesiredCompensationProperty
    {
        /// <summary>
        /// The time period of the salary.
        /// </summary>

        [JsonProperty("period")]
        public SalaryPeriod Period { get; set; }

        /// <summary>
        /// The ISO 4217 currency code.
        /// </summary>
        [JsonProperty("rate")]
        public JobApplicationsRateDtoProperty Rate { get; set; }
    }
}
