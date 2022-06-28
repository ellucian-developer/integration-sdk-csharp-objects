using Newtonsoft.Json;
// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Details on how the student elected to have their transcript grades recorded.
    /// </summary>
    [DataContract]
    public class SectionRegistrationTranscript
    {
        /// <summary>
        /// The grading scheme that will be used to record the student's grade for the section on a transcript.
        /// </summary>
        [DataMember(Name = "gradeScheme")]
        public GuidObject2 GradeScheme { get; set; }

        /// <summary>
        /// The manner in which a student's transcript grade will be reported.
        /// </summary>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TranscriptMode? Mode { get; set; }

        /// <summary>
        /// SectionRegistration constructor.
        /// </summary>
        public SectionRegistrationTranscript() : base()
        {
            GradeScheme = new GuidObject2();
            Mode = TranscriptMode.Standard;
        }
    }
}