//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The last date or status of attendance associated with the unverified grade
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentUnverifiedGradesLastAttendanceDtoProperty
    {
        /// <summary>
        /// The last date of attendance associated with the unverified grade
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The status of attendance
        /// </summary>
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentUnverifiedGradesStatus Status { get; set; }
    }
}