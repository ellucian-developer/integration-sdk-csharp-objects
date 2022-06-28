// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A record of a person's registration in a section..
    /// </summary>
    [DataContract]
    public class SectionRegistrations_V6_0 : BaseModel2
    {
        /// <summary>
        /// A person registering for a section represented by the GUID (required).
        /// </summary>
        [DataMember(Name = "registrant")]
        public GuidObject2 Registrant { get; set; }

        /// <summary>
        /// An instance of a Section represented by the GUID (required).
        /// </summary>
        [DataMember(Name = "section")]
        public GuidObject2 Section { get; set; }

        /// <summary>
        /// Approval type and agent of approval (required).
        /// </summary>
        [DataMember(Name = "approvals")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Approval2> Approvals { get; set; }

        /// <summary>
        /// The Registration Action to perform or status to assign (required).
        /// </summary>
        [DataMember(Name = "status")]
        public SectionRegistrationStatus2 Status { get; set; }

        /// <summary>
        /// The grading scheme that will be used to award the student a grade for the section.
        /// </summary>
        [DataMember(Name = "awardGradeScheme")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 AwardGradeScheme { get; set; }

        /// <summary>
        /// The grading scheme that will be used to award the student a grade for the section.
        /// </summary>
        [DataMember(Name = "transcript", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SectionRegistrationTranscript Transcript { get; set; }

        /// <summary>
        /// Grades that have been assigned to this section registration.
        /// </summary>
        [DataMember(Name = "grades", EmitDefaultValue = false)]        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SectionRegistrationGrade> SectionRegistrationGrades { get; set; }

        /// <summary>
        /// Properties associated with the processing of section grades.
        /// </summary>
        [DataMember(Name = "process", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SectionRegistrationProcess Process { get; set; }

        /// <summary>
        /// The range of dates between which a student was involved with a section.
        /// </summary>
        [DataMember(Name = "involvement", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SectionRegistrationInvolvement Involvement { get; set; }

        /// <summary>
        /// Properties required for governmental or other reporting.
        /// </summary>
        [DataMember(Name = "reporting", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SectionRegistrationReporting SectionRegistrationReporting { get; set; }

        /// <summary>
        /// SectionRegistration constructor.
        /// </summary>
        public SectionRegistrations_V6_0() : base()
        {
            Registrant = new GuidObject2();
            Section = new GuidObject2();
            Approvals = new List<Approval2>();
            Status = new SectionRegistrationStatus2();
            AwardGradeScheme = new GuidObject2();
        }
    }
}