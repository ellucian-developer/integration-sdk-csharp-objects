// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Properties dealing with the transcript processing of the grade.
    /// </summary>
    [DataContract]
    public class Transcript
    {
        /// <summary>
        /// The date the grade was verified and rolled into a student's transcript.
        /// </summary>
        [DataMember(Name = "verifiedOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? VerifiedOn { get; set; }

        /// <summary>
        /// The person who verified the grade and rolled it into the student's transcript.
        /// </summary>
        [DataMember(Name = "verifiedBy", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 VerifiedBy { get; set; }
    }
}
