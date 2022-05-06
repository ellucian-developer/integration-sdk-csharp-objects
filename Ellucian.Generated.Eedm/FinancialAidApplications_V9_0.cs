// Copyright 2017-2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Detailed information concerning financial aid applications. 
    /// </summary>
    [DataContract]
    public class FinancialAidApplicationsV90 : BaseModel2
    {

        /// <summary>
        /// The person associated with the financial aid application.
        /// </summary>
        //[JsonProperty("applicant")]
        [DataMember(Name = "applicant", EmitDefaultValue = false)]
        public FinancialAidApplicationApplicant Applicant { get; set; }

        /// <summary>
        /// The date the application was completed.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("applicationCompletedOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? ApplicationCompletedOn { get; set; }

        /// <summary>
        /// The financial aid year for which the applicant applied.
        /// </summary>
        [JsonProperty("aidYear", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 AidYear { get; set; }

        /// <summary>
        /// The methodology for which the application is applicable.
        /// </summary>

        [DataMember(Name = "methodology", EmitDefaultValue = false)]
        [FilterProperty( "criteria" )]
        public FinancialAidApplicationsMethodology Methodology { get; set; }

        /// <summary>
        /// The source of the financial aid application.
        /// </summary>

        [DataMember(Name = "source", EmitDefaultValue = false)]
        [FilterProperty( "criteria" )]
        public FinancialAidApplicationsSource Source { get; set; }

        /// <summary>
        /// The applicant's state of legal residence.
        /// </summary>
        [DataMember(Name = "stateOfLegalResidence", EmitDefaultValue = false)]
        public string StateOfLegalResidence { get; set; }

        /// <summary>
        /// The criteria for determining the applicant's dependency status.
        /// </summary>

        [DataMember(Name = "independenceCriteria", EmitDefaultValue = false)]
        //public FinancialAidApplicationsIndependenceCriteria IndependenceCriteria { get; set; }
        public IEnumerable<FinancialAidApplicationsIndependenceCriteria> IndependenceCriteria { get; set; }

        /// <summary>
        /// An indication of the applicant's interest in a work study program.
        /// </summary>
        [DataMember(Name = "workStudy", EmitDefaultValue = false)]
        public FinancialAidApplicationsInterest WorkStudy { get; set; }

        /// <summary>
        /// The applicant's housing preference.
        /// </summary>
        [DataMember(Name = "housingPreference", EmitDefaultValue = false)]
        public FinancialAidApplicationsHousingPreference HousingPreference { get; set; }

        /// <summary>
        /// The applicant's income information.
        /// </summary>
        [DataMember(Name = "applicantIncome", EmitDefaultValue = false)]
        public FinancialAidApplicationApplicantIncomeDtoProperty ApplicantIncome { get; set; }

        /// <summary>
        /// The custodial parent(s) income information.
        /// </summary>
        [DataMember(Name = "custodialParentsIncome", EmitDefaultValue = false)]
        public FinancialAidApplicationCustodialParentsIncomeDtoProperty CustodialParentsIncome { get; set; }

        /// <summary>
        /// The noncustodial parent(s) income information.
        /// </summary>
        [DataMember(Name = "noncustodialParentsIncome", EmitDefaultValue = false)]
        public FinancialAidApplicationNoncustodialParentsIncomeDtoProperty NoncustodialParentsIncome { get; set; }

        /// <summary>
        /// The applicant's marital status.
        /// </summary>
        [DataMember( Name = "maritalStatus", EmitDefaultValue = false )]
        public MaritalStatusDtoProperty MaritalStatus { get; set; }

        /// <summary>
        /// Number of people in the applicant's household (only applicable for an applicant that meets independence criteria).
        /// </summary>
        [DataMember( Name = "applicantFamilySize", EmitDefaultValue = false )]
        public int? ApplicantFamilySize { get; set; }

        /// <summary>
        /// Number of people in the applicant’s parents’ household.
        /// </summary>
        [DataMember( Name = "parentFamilySize", EmitDefaultValue = false )]
        public int? ParentFamilySize { get; set; }

        /// <summary>
        /// Number of people in applicant’s household that will be in college during the academic year (only applicable for an applicant that meets independence criteria).
        /// </summary>
        [DataMember( Name = "applicantNumberInCollege", EmitDefaultValue = false )]
        public int? ApplicantNumberInCollege { get; set; }

        /// <summary>
        /// Number of people in applicant’s parents’ household that will be in college during the academic year.
        /// </summary>
        [DataMember( Name = "parentNumberInCollege", EmitDefaultValue = false )]
        public int? ParentNumberInCollege { get; set; }

        /// <summary>
        /// The highest education level completed by the applicant's parents.
        /// </summary>
        [DataMember( Name = "parentsEducationLevel", EmitDefaultValue = false )]
        public FinancialAidEducationLevelDtoProperty ParentsEducationLevel { get; set; }

    }
}