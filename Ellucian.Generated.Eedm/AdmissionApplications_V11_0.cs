//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Higher education institution admission applications.
    /// </summary>
    [DataContract]
    public class AdmissionApplications_V11_0 : BaseModel2
    {
        /// <summary>
        /// The person applying for the admission
        /// </summary>
        [DataMember(Name = "applicant", EmitDefaultValue = false)]
        public GuidObject2 Applicant { get; set; }

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
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// The statuses of the application through the admission process stages
        /// </summary>
        //[DataMember(Name = "statuses", EmitDefaultValue = false)]
        //public List<AdmissionApplicationsStatus2> Statuses { get; set; }
        
        /// <summary>
        /// The institution representative assigned to manage the application
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public GuidObject2 Owner { get; set; }

        /// <summary>
        /// The source of information associated with the application
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Source { get; set; }        

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
        /// The academic program applied for
        /// </summary>
        [DataMember(Name = "program", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Program { get; set; }

        /// <summary>
        /// Academic level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Level { get; set; }

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
        /// The school or college of the institution the application is associated with
        /// </summary>
        [DataMember(Name = "school", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 School { get; set; }

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
        public AdmissionApplicationsWithdrawal2 Withdrawal { get; set; }

        /// <summary>
        /// The comment associated with the application
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

    }
}