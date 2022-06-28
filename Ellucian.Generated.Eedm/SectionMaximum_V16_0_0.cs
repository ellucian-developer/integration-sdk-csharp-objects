// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// This is an instance of a course full representation, offered once
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SectionMaximum_V16_0_0
    {
        /// <summary>
        /// A Globally Unique ID (GUID)
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Section number
        /// </summary>
        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Number { get; set; }

        /// <summary>
        /// Identifier of a section (Section Name)
        /// </summary>
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Code { get; set; }
        /// <summary>
        /// The section title.
        /// </summary>

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Title { get; set; }

        /// <summary>
        /// The section descriptions details.
        /// </summary>

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Section start date
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// Section end date
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// Instructional Platform for the section
        /// </summary>
        [JsonProperty("instructionalPlatform", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InstructionalPlatformDtoProperty InstructionalPlatform { get; set; }

        /// <summary>
        /// Academic Period for the section
        /// </summary>
        [JsonProperty("academicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AcademicPeriodDtoProperty3 AcademicPeriod { get; set; }

        /// <summary>
        /// Reporting Academic Period for the section
        /// </summary>
        [JsonProperty("reportingAcademicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 ReportingAcademicPeriod { get; set; }

        /// <summary>
        /// Schedule Academic Period for the section
        /// </summary>
        [JsonProperty("scheduleAcademicPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AcademicPeriodDtoProperty3 ScheduleAcademicPeriod { get; set; }

        /// <summary>
        /// cenus date list
        /// </summary>
        [JsonProperty("censusDates", ItemConverterType = typeof(DateOnlyConverter), DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<DateTime?> CensusDates { get; set; }

        /// <summary>
        /// The duration of the section
        /// </summary>
        [JsonProperty("course", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CourseDtoProperty2 Course { get; set; }

        /// <summary>
        /// Owning Organizations for the section
        /// </summary>
        [JsonProperty("credits", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<Credit2DtoProperty> Credits { get; set; }

        /// <summary>
        /// Site for the section
        /// </summary>
        [JsonProperty("site", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SiteDtoProperty Site { get; set; }

        /// <summary>
        /// Academic Levels for the section
        /// </summary>
        [JsonProperty("academicLevels", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<AcademicLevelDtoProperty> AcademicLevels { get; set; }

        /// <summary>
        /// Owning Organizations for the section
        /// </summary>
        [JsonProperty("gradeSchemes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<GradeSchemeDtoProperty2> GradeSchemes { get; set; }

        /// <summary>
        /// Course Levels for the section
        /// </summary>
        [JsonProperty("courseLevels", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<CourseLevelDtoProperty> CourseLevels { get; set; }

        /// <summary>
        /// The current status of the section
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StatusCategoryFilterConverter))]
        public SectionStatusDtoProperty Status { get; set; }

        /// <summary>
        /// The duration of the section
        /// </summary>
        [JsonProperty("duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SectionDuration2 Duration { get; set; }

        /// <summary>
        /// The maximum enrollment for the section
        /// </summary>
        [JsonProperty("maxEnrollment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? MaximumEnrollment { get; set; }

        /// <summary>
        /// The method, style, or format in which the section of a course is taught (for example, 'Lecture', 'Lab').
        /// </summary>
        [JsonProperty("instructionalMethodDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> InstructionalMethods { get; set; }

        /// <summary>
        /// The hours that may be assigned to the section by instructional method.
        /// </summary>
        [JsonProperty("hours", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<CoursesHoursDtoProperty> Hours { get; set; }

        /// <summary>
        /// InstructionalEvents for the section
        /// </summary>
        [JsonProperty("instructionalEvents", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<InstructionalEventDtoProperty3> InstructionalEvents { get; set; }

        /// <summary>
        /// The instructors teaching this section
        /// </summary>
        [JsonProperty("instructorRosterDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<InstructorRosterDtoProperty3> InstructorRoster { get; set; }

        /// <summary>
        /// Owning Organizations for the section
        /// </summary>
        [JsonProperty("owningInstitutionUnits", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<OwningOrganizationDtoProperty> OwningOrganizations { get; set; }

        /// <summary>
        /// The method used to assess the charge for the section.
        /// </summary>
        [DataMember(Name = "chargeAssessmentMethod", EmitDefaultValue = false)]
        [JsonProperty("chargeAssessmentMethod", NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 ChargeAssessmentMethod { get; set; }

        /// <summary>
        /// Additional unique identifiers assigned to sections to support non-Ethos integrations.
        /// </summary>
        [JsonProperty("alternateIds", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<SectionsAlternateIdsDtoProperty> AlternateIds { get; set; }

        /// <summary>
        /// Contructor
        /// </summary>
        [JsonConstructor]
        public SectionMaximum_V16_0_0() : base()
        {

        }

    }
}
