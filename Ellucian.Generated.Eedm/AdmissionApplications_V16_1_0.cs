//Copyright 2017-2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Higher education institution admission applications.
    /// </summary>
    [DataContract]
    public class AdmissionApplications_V16_1_0 : BaseModel2
    {
        /// <summary>
        /// The person applying for the admission
        /// </summary>
        [DataMember(Name = "applicant", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Applicant { get; set; }

        /// <summary>
        /// The identifier of the applicant and the academic program for which they have applied
        /// </summary>
        [DataMember(Name = "applicationAcademicPrograms", EmitDefaultValue = false)]
        public List<GuidObject2> ApplicationAcademicPrograms { get; set; }

        /// <summary>
        /// The identifier of the application at its origin
        /// </summary>
        [DataMember(Name = "referenceId", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceID { get; set; } 

        /// <summary>
        /// The type of the application
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// The starting academic period for the admission
        /// </summary>
        [DataMember(Name = "academicPeriod", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 AcademicPeriod { get; set; }
        
        /// <summary>
        /// The institution representative assigned to manage the application
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public GuidObject2 Owner { get; set; }

        /// <summary>
        /// The source of information associated with the application
        /// </summary>
        [DataMember(Name = "applicationSource", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 ApplicationSource { get; set; }        

        /// <summary>
        /// The type of admission populations the applicant belongs to
        /// </summary>
        [DataMember(Name = "admissionPopulation", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 AdmissionPopulation { get; set; }

        /// <summary>
        /// The institution site (campus) selected by the applicant
        /// </summary>
        [DataMember(Name = "site", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Site { get; set; }

        /// <summary>
        /// The residency type of the applicant, e.g., "international".
        /// </summary>
        [DataMember(Name = "residencyType", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 ResidencyType { get; set; }

        /// <summary>
        /// The academic load selection, e.g., full- or part-time
        /// </summary>
        [DataMember(Name = "academicLoad", EmitDefaultValue = false)]
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AdmissionApplicationsAcademicLoadType AcademicLoad { get; set; }

        /// <summary>
        /// The list of academic disciplines the applicant chose
        /// </summary>
        [DataMember(Name = "disciplines", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<AdmissionApplicationDiscipline> Disciplines { get; set; }

        /// <summary>
        /// The academic credential (degree, diploma, etc.) to be earned on completion of the study
        /// </summary>
        [DataMember(Name = "credential", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Credential { get; set; }

        /// <summary>
        /// The date the application was submitted
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "appliedOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AppliedOn { get; set; }

        /// <summary>
        /// The earliest admit date for the application
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "admittedOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AdmittedOn { get; set; }

        /// <summary>
        /// The earliest date for a decision/status that would trigger a move to student for this application
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [DataMember(Name = "matriculatedOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? MatriculatedOn { get; set; }

        /// <summary>
        /// Application withdrawal related information
        /// </summary>
        [DataMember(Name = "withdrawal", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AdmissionApplicationsWithdrawal3 Withdrawal { get; set; }

        /// <summary>
        /// The comment associated with the application
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// The education goal associated with the application
        /// </summary>
        [DataMember(Name = "educationalGoal", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 EducationalGoal { get; set; }

        /// <summary>
        /// The career goals associated with the application
        /// </summary>
        [DataMember(Name = "careerGoals", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<GuidObject2> CareerGoals { get; set; }

        /// <summary>
        /// The influences associated with the application
        /// </summary>
        [DataMember(Name = "influences", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<GuidObject2> Influences { get; set; }
    }
}