// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Properties required for governmental or other reporting.
    /// </summary>
    [DataContract]
    public class SectionRegistrationReporting
    {
        /// <summary>
        /// The country code for the USA
        /// </summary>
        [DataMember(Name = "countryCode")]
        public CountryCodeType? CountryCode { get; set; }

        /// <summary>
        /// Information about the last day of attendance
        /// </summary>
        [DataMember(Name = "lastDayOfAttendance", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public LastDayOfAttendance LastDayOfAttendance { get; set; }
    }
}
