// Copyright 2016-2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// This is an instance of a course, offered once
    /// </summary>
    [DataContract]
    public class Sections_V11_0 : BaseModel2
    {
        /// <summary>
        /// Section number
        /// </summary>
        [DataMember(Name = "number")]
        [FilterProperty("criteria")]
        public string Number { get; set; }

        /// <summary>
        /// Identifier of a section (Section Name)
        /// </summary>
        [DataMember(Name = "code")]
        [FilterProperty("criteria")]
        public string Code { get; set; }

        /// <summary>
        /// Title of section
        /// </summary>
        [DataMember(Name = "title")]
        [FilterProperty("criteria")]
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
        [FilterProperty("criteria")]
        public DateTimeOffset? StartOn { get; set; }

        /// <summary>
        /// Section end date
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTimeOffset? EndOn { get; set; }

        /// <summary>
        /// A technology platform used to manage the administration of an InstructionalEvent.
        /// </summary>
        [DataMember(Name = "instructionalPlatform", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 InstructionalPlatform { get; set; }

        /// <summary>
        /// Academic Time Period or Term
        /// </summary>
        [DataMember(Name = "academicPeriod", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// Census dates for course being offered
        /// </summary>
        [DataMember(Name = "censusDates", EmitDefaultValue = false)]
        [JsonProperty(ItemConverterType = typeof(DateOnlyConverter), DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<DateTime?> CensusDates { get; set; }

        /// <summary>
        /// Course being offered
        /// </summary>
        [DataMember(Name = "course")]
        [FilterProperty("criteria")]
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
        [FilterProperty("criteria")]
        public GuidObject2 Site { get; set; }

        /// <summary>
        /// A list of academic levels at which this section is offered
        /// </summary>
        [DataMember(Name = "academicLevels", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
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
        [FilterProperty("criteria")]
        public SectionStatusDtoProperty Status { get; set; }

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
        /// The number of units that may be used to calculate the charge for the section as part of registration processing
        /// </summary>
        [DataMember(Name = "billing", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Billing { get; set; }

        /// <summary>
        /// A list of course categories associated with this section
        /// </summary>
        [DataMember(Name = "courseCategories", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<GuidObject2> CourseCategories { get; set; }

        /// <summary>
        /// A list of instructional methods associated with this section
        /// </summary>
        [DataMember(Name = "instructionalMethods", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<GuidObject2> InstructionalMethods { get; set; }

        /// <summary>
        /// The maximum enrollment for the section
        /// </summary>
        [DataMember(Name = "reservedSeatsMaximum", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? ReservedSeatsMaximum { get; set; }
        
        /// <summary>
        /// The maximum enrollment for the section
        /// </summary>
        [DataMember(Name = "waitlist", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public SectionWaitlistDtoProperty Waitlist { get; set; }

        /// <summary>
        /// Section constructor
        /// </summary>
        public Sections_V11_0() : base()
        {
            Credits = new List<SectionCreditDtoProperty>();
            AcademicLevels = new List<GuidObject2>();
            GradeSchemes = new List<GuidObject2>();
            CourseLevels = new List<GuidObject2>();
            CourseCategories = new List<GuidObject2>();
            InstructionalMethods = new List<GuidObject2>();
            OwningInstitutionUnits = new List<OwningInstitutionUnit>();
        }
    }
}
