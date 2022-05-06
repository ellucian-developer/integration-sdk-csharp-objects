// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// This is an instance of a course, offered once
    /// </summary>
    [DataContract]
    public class Sections_V16_1_0 : BaseModel2
    {
        /// <summary>
        /// The section titles details.
        /// </summary>
        [JsonProperty("titles", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<CoursesTitlesDtoProperty> Titles { get; set; }

        /// <summary>
        /// The section descriptions details.
        /// </summary>
        [JsonProperty("descriptions", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<SectionDescriptionDtoProperty> Descriptions { get; set; }

        /// <summary>
        /// The starting date at which a section may be scheduled to be taken.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTime? StartOn { get; set; }

        /// <summary>
        /// The ending date at which a section may no longer be scheduled to be taken.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTime? EndOn { get; set; }

        /// <summary>
        /// The human-readable identifier of a section. It is generally unique within an academic period.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Code { get; set; }

        /// <summary>
        /// A numbering scheme or other mark that distinguishes between multiple sections.  It is generally unique within an academic period and course.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Number { get; set; }

        /// <summary>
        /// A technology platform used to manage the administration of an InstructionalEvent.
        /// </summary>
        [JsonProperty("instructionalPlatform", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 InstructionalPlatform { get; set; }

        /// <summary>
        /// The academic time period associated with a section.
        /// </summary>
        [JsonProperty("academicPeriod", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// The reporting academic time period associated with a section.
        /// </summary>
        [JsonProperty("reportingAcademicPeriod", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 ReportingAcademicPeriod { get; set; }

        /// <summary>
        /// The dates at which the section's enrollment/headcount is determined. These dates override the census dates for the academic period, if they are different.
        /// </summary>
        [JsonProperty("censusDates", ItemConverterType = typeof(DateOnlyConverter), DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<DateTime?> CensusDates { get; set; }

        /// <summary>
        /// The smallest unit of instruction for which an organization grants credits.
        /// </summary>
        [JsonProperty("course", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Course { get; set; }

        /// <summary>
        /// The categories to which the course may belong (for example - Vocational, Co-op Work Experience, Lab, Music, etc.)
        /// </summary>
        [JsonProperty("courseCategories", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> CourseCategories { get; set; }

        /// <summary>
        /// Unit specification that can be awarded for completing a section.
        /// </summary>
        [JsonProperty("credits", NullValueHandling = NullValueHandling.Ignore)]
        public List<SectionCreditDtoProperty> Credits { get; set; }

        /// <summary>
        /// The primary location within the organization where a section's meetings will be held.
        /// </summary>
        [JsonProperty("site", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Site { get; set; }

        /// <summary>
        /// The levels of academic progress that can be associated with a section.
        /// </summary>
        [JsonProperty("academicLevels", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public List<GuidObject2> AcademicLevels { get; set; }

        /// <summary>
        /// The grading schemes that may be used to award a grade to a student in this section of the course. Must be a subset of the grade schemes of the course.
        /// </summary>
        [JsonProperty("gradeSchemes", NullValueHandling = NullValueHandling.Ignore)]
        public List<GuidObject2> GradeSchemes { get; set; }

        /// <summary>
        /// A list of course levels associated with this section
        /// </summary>
        [DataMember(Name = "courseLevels", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<GuidObject2> CourseLevels { get; set; }

        /// <summary>
        /// The method, style, or format in which the section of a course is taught (for example, 'Lecture', 'Lab').
        /// </summary>
        [JsonProperty("instructionalMethods", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> InstructionalMethods { get; set; }

        /// <summary>
        /// The hours that may be assigned to the section by instructional method.
        /// </summary>
        [JsonProperty("hours", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<CoursesHoursDtoProperty> Hours { get; set; }

        /// <summary>
        /// The delivery method of instruction for the section (for example: 'Face to face', 'Web', etc.)
        /// </summary>
        [JsonProperty("instructionalDeliveryMethod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 InstructionalDeliveryMethod { get; set; }

        /// <summary>
        /// The status of a section (for example, open, closed, pending, cancelled).
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public SectionStatusDtoProperty Status { get; set; }

        /// <summary>
        /// The scheme for calculating the duration of a section
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public SectionDuration2 Duration { get; set; }

        /// <summary>
        /// The maximum number of persons who are allowed to enroll for a section.
        /// </summary>
        [JsonProperty("maxEnrollment", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaximumEnrollment { get; set; }

        /// <summary>
        /// The maximum enrollment for the section
        /// </summary>
        [JsonProperty("reservedSeatsMaximum", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReservedSeatsMaximum { get; set; }

        /// <summary>
        /// Waitlist information for the section.
        /// </summary>
        [JsonProperty("waitlist", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SectionWaitlistDtoProperty Waitlist { get; set; }

        /// <summary>
        /// An indication if the section is cross listed.
        /// </summary>
        [JsonProperty("crossListed", NullValueHandling = NullValueHandling.Ignore)]
        public CrossListed CrossListed { get; set; }

        /// <summary>
        /// The units (departments) of the educational institution which own, or are responsible for, a course
        /// </summary>
        [JsonProperty("owningInstitutionUnits", NullValueHandling = NullValueHandling.Ignore)]
        public List<OwningInstitutionUnit> OwningInstitutionUnits { get; set; }

        /// <summary>
        /// The number of units that may be used to calculate the charge for the section as part of registration processing.
        /// </summary>
        [JsonProperty("billing", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Billing { get; set; }

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
        /// Describes whether the section is visible in the course catalog.
        /// </summary>
        [JsonProperty("catalogDisplay", NullValueHandling = NullValueHandling.Ignore)]
        public SectionCatalogDisplay? CatalogDisplay { get; set; }

        /// <summary>
        /// Section constructor
        /// </summary>
        public Sections_V16_1_0() : base()
        {
        }
    }
}
