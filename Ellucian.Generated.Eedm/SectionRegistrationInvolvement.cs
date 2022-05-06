// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The range of dates between which a student was involved with a section.
    /// </summary>
    [DataContract]
    public class SectionRegistrationInvolvement
    {
        /// <summary>
        /// The date when the section was first attended or accessed online.
        /// </summary>
        [DataMember(Name = "startOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// The date when the section was last attended or accessed online.
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndOn { get; set; }
    }
}
