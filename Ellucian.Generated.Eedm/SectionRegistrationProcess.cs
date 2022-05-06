// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Properties associated with the processing of section grades.
    /// </summary>
    [DataContract]
    public class SectionRegistrationProcess
    {
        /// <summary>
        /// Default grade and expiration date for incomplete grades.
        /// </summary>
        [DataMember(Name = "gradeExtension", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GradeExtension GradeExtension { get; set; }

        /// <summary>
        /// Properties dealing with the transcript processing of the grade.
        /// </summary>
        [DataMember(Name = "transcript", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Transcript Transcript { get; set; }
    }
}