// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about the last day of attendance
    /// </summary>
    [DataContract]
    public class LastDayOfAttendance
    {
        /// <summary>
        /// An indicator of the students involvement in the section.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ReportingStatusType? Status { get; set; }        
        
        /// <summary>
        /// The date the student last attended the section for this registration.
        /// </summary>
        [DataMember(Name = "lastAttendedOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastAttendedOn { get; set; }
    }
}
