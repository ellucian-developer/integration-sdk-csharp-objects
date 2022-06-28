//Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A record of a student's interaction with a specific section such as registration, grades, involvement. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SectionRegistrations_V16_1_0 : BaseModel2
    {
        /// <summary>
        /// A person registered for a section.
        /// </summary>
        [JsonProperty("registrant", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Registrant { get; set; }
        
        /// <summary>
        /// An instance of a course for which a person is registering.
        /// </summary>
        [JsonProperty("section", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Section { get; set; }

        /// <summary>
        /// The academic level at which the student is registering for the course (The level specified should match one of the levels allowed for the section).
        /// </summary>
        [JsonProperty("academicLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// The date on which the student originally registered for the section.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("originallyRegisteredOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? OriginallyRegisteredOn { get; set; }

        /// <summary>
        /// The status of this person's registration in the section.
        /// </summary>
        [JsonProperty("status")]
        public SectionRegistrationStatusDtoProperty Status { get; set; }

        /// <summary>
        /// The date on which the status was set.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("statusDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? StatusDate { get; set; }

        /// <summary>
        /// The method of approval.
        /// </summary>
        [JsonProperty("approvals", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Approval2> Approval { get; set; }

        /// <summary>
        /// Unit specification that can be awarded for completing a section.
        /// </summary>
        [JsonProperty("credit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Credit4DtoProperty Credit { get; set; }

        /// <summary>
        /// Details on how the student elected to have their grades recorded.
        /// </summary>
        [JsonProperty("gradingOption", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SectionRegistrationTranscript2 GradingOption { get; set; }

        /// <summary>
        /// The range of dates between which a student was involved with a section.
        /// </summary>
        [JsonProperty("involvement", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SectionRegistrationInvolvement Involvement { get; set; }

        /// <summary>
        /// Properties defined for the section that may be overridden for individual registrations.
        /// </summary>
        [JsonProperty("override", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SectionRegistrationsOverrideDtoProperty Override { get; set; }
    }
}