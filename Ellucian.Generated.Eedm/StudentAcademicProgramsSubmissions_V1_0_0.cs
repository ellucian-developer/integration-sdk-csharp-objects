//Copyright 2018-2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The academic programs in the home institution in which a student has beed enrolled. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentAcademicProgramsSubmissions_V1_0_0 : BaseModel2
    {
        /// <summary>
        /// The student who is enrolled in an academic program.
        /// </summary>
        [JsonProperty("student", DefaultValueHandling = DefaultValueHandling.Ignore)]
         public GuidObject2 Student { get; set; }

        /// <summary>
        /// The academic program in which a student is enrolled.
        /// </summary>
        [JsonProperty("program", DefaultValueHandling = DefaultValueHandling.Ignore)]
         public GuidObject2 AcademicProgram { get; set; }

        /// <summary>
        /// The curriculum objective associated with the student's academic program.
        /// </summary>
        [JsonProperty("curriculumObjective", DefaultValueHandling = DefaultValueHandling.Ignore)]        
        public StudentAcademicProgramsCurriculumObjective2? CurriculumObjective { get; set; }

        /// <summary>
        /// Indicates the primary academic program of the student.  Only one academic program should be set to preferred for a student.
        /// </summary>
        [JsonProperty("preference", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentAcademicProgramsPreference? Preference { get; set; }

        /// <summary>
        /// The owner of the academic program.
        /// </summary>
        [JsonProperty("programOwner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ProgramOwner { get; set; }

        /// <summary>
        /// The site (campus) the student enrolls for the program at
        /// </summary>
        [JsonProperty("site", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Site { get; set; }

        /// <summary>
        /// The academic catalog that defines the requirements for a student's enrollment in a program.
        /// </summary>
        [JsonProperty("catalog", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AcademicCatalog { get; set; }

        /// <summary>
        /// The academic level associated with the enrollment of the student in the academic program.
        /// </summary>
        [JsonProperty("academicLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AcademicLevel { get; set; }

        /// <summary>
        /// The academic credentials that can be awarded for completing an academic program.
        /// </summary>
        [JsonProperty("credentials", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(ArrayGuidObject2FilterConverter))]
        public List<GuidObject2> Credentials { get; set; }

        /// <summary>
        /// The academic disciplines offered as part of the academic program.
        /// </summary>
        [JsonProperty("disciplines", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<StudentAcademicProgramDisciplines2> Disciplines { get; set; }

        /// <summary>
        /// The date on which an academic program begins.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
         public DateTime? StartOn { get; set; }

        /// <summary>
        /// The date on which an academic program ends.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
         public DateTime? EndOn { get; set; }

        /// <summary>
        /// Various academic periods related to a student's progression in a program.
        /// </summary>
        [JsonProperty("academicPeriods", DefaultValueHandling = DefaultValueHandling.Ignore)]      
        public StudentAcademicProgramsAcademicPeriods2 AcademicPeriods { get; set; }

        /// <summary>
        /// The current state of a student's academic program enrollment.
        /// </summary>
        [JsonProperty("enrollmentStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public EnrollmentStatusDetail EnrollmentStatus { get; set; }
        
        /// <summary>
        /// The date on which the student is expected to graduate from the academic program.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("expectedGraduationDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? ExpectedGraduationDate { get; set; }
        
        /// <summary>
        /// The admission category and/or type typically captured upon admission to the program 
        /// </summary>
        [JsonProperty("admissionClassification", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AdmissionClassificationDtoProperty AdmissionClassification { get; set; }

        
    }
}