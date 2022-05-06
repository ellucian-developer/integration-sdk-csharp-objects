// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// This is an instance of a course, offered once
    /// </summary>
    [DataContract]
    public class Sections_V6_0 : BaseModel2
    {
        /// <summary>
        /// Section number
        /// </summary>
        [DataMember(Name = "number")]
        public string Number { get; set; }

        /// <summary>
        /// Identifier of a section (Section Name)
        /// </summary>
        [DataMember(Name = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Title of section
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Long description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Section start date
        /// </summary>
        [DataMember(Name = "startOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// Section end date
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndOn { get; set; }

        /// <summary>
        /// A technology platform used to manage the administration of an InstructionalEvent.
        /// </summary>
        [DataMember(Name = "instructionalPlatform", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 InstructionalPlatform { get; set; }

        /// <summary>
        /// Academic Time Period or Term
        /// </summary>
        [DataMember(Name = "academicPeriod", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// Course being offered
        /// </summary>
        [DataMember(Name = "course")]
        public GuidObject2 Course { get; set; }

        /// <summary>
        /// Credit information for the section
        /// </summary>
        [DataMember(Name = "credits", EmitDefaultValue = false)]        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<SectionCreditDtoProperty> Credits { get; set; }

        /// <summary>
        /// The site where the section is held
        /// </summary>
        [DataMember(Name = "site", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Site { get; set; }

        /// <summary>
        /// A list of academic levels at which this section is offered
        /// </summary>
        [DataMember(Name = "academicLevels", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<GuidObject2> AcademicLevels { get; set; }

        /// <summary>
        /// The grade scheme that applies to this section
        /// </summary>
        [DataMember(Name = "gradeSchemes", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<GuidObject2> GradeSchemes { get; set; }

        /// <summary>
        /// A list of course levels associated with this section
        /// </summary>
        [DataMember(Name = "courseLevels", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<GuidObject2> CourseLevels { get; set; }

        /// <summary>
        /// The current status of the section
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SectionStatus2? Status { get; set; }

        /// <summary>
        /// The duration of the section
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SectionDuration2 Duration { get; set; }

        /// <summary>
        /// The maximum enrollment for the section
        /// </summary>
        [DataMember(Name = "maxEnrollment", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumEnrollment { get; set; }

        /// <summary>
        /// Information about the organizations who own this section
        /// </summary>
        [DataMember(Name = "owningInstitutionUnits", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<OwningInstitutionUnit> OwningInstitutionUnits { get; set; }
 
        /// <summary>
        /// Section constructor
        /// </summary>
        public Sections_V6_0() : base()
        {
            Credits = new List<SectionCreditDtoProperty>();
            AcademicLevels = new List<GuidObject2>();
            GradeSchemes = new List<GuidObject2>();
            CourseLevels = new List<GuidObject2>();
            OwningInstitutionUnits = new List<OwningInstitutionUnit>();
        }
    }
}
