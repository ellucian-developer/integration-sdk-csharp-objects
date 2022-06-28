// Copyright 2016-2018 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The smallest unit of instruction for which an organization grants credits. Identifies subject, course number and level, availability dates, instructional method, grading schemes, credits granted, and the granting organization. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Courses_V16_1_0 : BaseModel2
    {
        /// <summary>
        /// The course titles details.
        /// </summary>

        [JsonProperty("titles", DefaultValueHandling = DefaultValueHandling.Ignore)]
        
        public List<CoursesTitlesDtoProperty> Titles { get; set; }

        /// <summary>
        /// A description of the substance and nature of a course as it appears in a course catalog.
        /// </summary>

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The branch of knowledge such as 'Mathematics' or 'Biology' associated with a course.
        /// </summary>

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Subject { get; set; }

        /// <summary>
        /// The topic associated with the course.(for example - Real Estate, Modern Literature, Travel and Leisure, etc.)
        /// </summary>

        [JsonProperty("topic", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Topic { get; set; }

        /// <summary>
        /// The categories to which the course may belong (for example - Vocational, Co-op Work Experience, Lab, Music, etc.)
        /// </summary>

        [JsonProperty("categories", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public List<GuidObject2> Categories { get; set; }

        /// <summary>
        /// The levels of scholarship that apply to a course.
        /// </summary>

        [JsonProperty("courseLevels", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GuidObject2> CourseLevels { get; set; }

        /// <summary>
        /// The methods, styles, or formats in which the course is taught (for example, 'Lecture', 'Lab').
        /// </summary>

        [JsonProperty("instructionalMethodDetails", DefaultValueHandling = DefaultValueHandling.Ignore)]       
        public List<InstructionalMethodDetail> InstructionalMethodDetails { get; set; }

        /// <summary>
        /// The hours that may be assigned to the course by instructional method.
        /// </summary>

        [JsonProperty("hours", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<CoursesHoursDtoProperty> Hours { get; set; }

        /// <summary>
        /// A list of units of the educational institution (optionally, hierarchical) that own or are responsible for a course
        /// </summary>

        [JsonProperty("owningInstitutionUnits", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<OwningInstitutionUnit> OwningInstitutionUnits { get; set; }

        /// <summary>
        /// The starting date on which a course is available to have sections scheduled. When combined with the Course Effective Ending Date, this defines the time period a course is available for scheduling.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("schedulingStartOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTime? EffectiveStartDate { get; set; }

        /// <summary>
        /// The ending date on which a course is no longer available to have sections scheduled. When combined with the Course Effective Starting Date, this defines the time period a course is available for scheduling.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("schedulingEndOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTime? EffectiveEndDate { get; set; }

        /// <summary>
        /// A numbering scheme that distinguishes courses within a subject. Typically, this is an integer.
        /// </summary>

        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public string Number { get; set; }

        /// <summary>
        /// The academic levels (for example, 'Under Graduate' or 'Graduate') associated with a course.
        /// </summary>

        [JsonProperty("academicLevels", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public List<GuidObject2> AcademicLevels { get; set; }

        /// <summary>
        /// The grading schemes that may be used to award a grade to a student taking this course.
        /// </summary>

        [JsonProperty("gradeSchemes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<GradeSchemesDtoProperty> GradeSchemes { get; set; }

        /// <summary>
        /// The credit specifications that apply to a course (for example, 'Regular Credit').
        /// </summary>

        [JsonProperty("credits", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Credit3> Credits { get; set; }

        /// <summary>
        /// The number of units that may be used to calculate the charge for the course.
        /// </summary>

        [JsonProperty("billing", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BillingCreditDtoProperty Billing { get; set; }

        /// <summary>
        /// An indication if a student is allowed to be on the waitlist for multiple sections of the same course simultaneously.
        /// </summary>

        [JsonProperty("waitlistMultipleSections", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public WaitlistMultiSectionFlag? WaitlistMultipleSections { get; set; }

        /// <summary>
        /// Additional properties required for localized reporting.
        /// </summary>

        [JsonProperty("reportingDetail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CourseReportingDtoProperty ReportingDetail { get; set; }

        /// <summary>
        /// The administrative period associated with a course.
        /// </summary>

        [JsonProperty("administrativePeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AdministrativePeriod { get; set; }

        /// <summary>
        /// The status associated with the course.
        /// </summary>

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Status { get; set; }

        /// <summary>
        /// Additional classifications associated with the course.
        /// </summary>

        [JsonProperty("additionalClassifications", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<CourseAdditionalClassifications> AdditionalClassifications { get; set; }
    }
}