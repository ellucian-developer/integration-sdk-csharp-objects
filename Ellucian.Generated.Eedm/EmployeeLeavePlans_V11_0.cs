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
    /// Information on employees' leave plans. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class EmployeeLeavePlans_V11_0 : BaseModel2
    {
        /// <summary>
        /// The person associated with the leave plan.
        /// </summary>

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// The leave plan assigned to the employee.
        /// </summary>

        [JsonProperty("plan", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Plan { get; set; }

        /// <summary>
        /// The start date of the plan.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The end date of the plan.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? EndOn { get; set; }

    }
}
