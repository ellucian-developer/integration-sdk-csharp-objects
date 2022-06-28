// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Properties related to the submission of the section grade.
    /// </summary>
    [DataContract]
    public class Submission
    {
        /// <summary>
        /// The person who submitted the section grade.
        /// </summary>
        [DataMember(Name="submittedBy", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 SubmittedBy { get; set; }

        /// <summary>
        /// The date the section grade was submitted.
        /// </summary>
        [DataMember(Name = "submittedOn")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SubmittedOn { get; set; }

        /// <summary>
        /// The method by which the section grade was submitted.
        /// </summary>
        [DataMember(Name="method")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SubmissionMethodType? SubmissionMethod { get; set; }

        /// <summary>
        /// The reason for the section grade submission.
        /// </summary>
        [DataMember(Name="reason")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 SubmissionReason { get; set; }
    }
}
