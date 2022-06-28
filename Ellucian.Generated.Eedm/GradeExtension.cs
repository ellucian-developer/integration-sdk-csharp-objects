// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Default grade and expiration date for incomplete grades.
    /// </summary>
    [DataContract]
    public class GradeExtension
    {
        /// <summary>
        /// The date the incomplete grade expires and is replaced with the default grade.
        /// </summary>
        [DataMember(Name = "expiresOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExpiresOn { get; set; }

        /// <summary>
        /// The grade to which an incomplete will revert if not updated by the expiration date.
        /// </summary>
        [DataMember(Name = "defaultGrade", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 DefaultGrade { get; set; }
    }
}
