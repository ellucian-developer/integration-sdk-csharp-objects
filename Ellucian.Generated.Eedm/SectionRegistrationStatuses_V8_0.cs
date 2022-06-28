using Newtonsoft.Json;
// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A designation of a student's status within a course
    /// </summary>
    [DataContract]
    public class SectionRegistrationStatuses_V8_0 : CodeItem2
    {
        /// <summary>
        /// The current status of the registration for the section.
        /// </summary>
        [DataMember(Name = "status")]
        public SectionRegistrationStatusItemStatus Status { get; set; }

        /// <summary>
        /// Indicates whether to include the registration of a section towards the head count.
        /// </summary>
        [DataMember(Name = "headcountStatus", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public HeadCountStatus? HeadCountStatus { get; set; }
    }
}