// Copyright 2017=2020 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Detailed information concerning financial aid application outcomes. 
    /// </summary>
    [DataContract]
    public class FinancialAidApplicationOutcomes_V9_0 : BaseModel2
    {

        /// <summary>
        /// The person associated with the financial aid application.
        /// </summary>
        //[JsonProperty("applicant")]
        [DataMember(Name = "applicant", EmitDefaultValue = false)]
        public FinancialAidApplicationApplicant Applicant { get; set; }
        
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
        [FilterProperty("criteria")]
        public FinancialAidApplicationsMethodology Methodology { get; set; }

        /// <summary>
        /// The financial aid application.
        /// </summary>
        [JsonProperty("application", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Application { get; set; }

        /// <summary>
        /// The application's rejection status.
        /// </summary>
        [DataMember(Name = "rejectionStatus", EmitDefaultValue = false)]
        public FinancialAidApplicationOutcomesRejectionStatus RejectionStatus { get; set; }

        /// <summary>
        /// An indication that the SAR C flag has been set and requires resolution
        /// </summary>
        [DataMember(Name = "studentAidReportResolution", EmitDefaultValue = false)]
        public FinancialAidApplicationOutcomesStudentAidReportResolution StudentAidReportC { get; set; }

        /// <summary>
        /// An indication of the applicant's dependency status.
        /// </summary>
        [DataMember(Name = "dependency", EmitDefaultValue = false)]
        public FinancialAidApplicationOutcomesDependency Dependency { get; set; }

        /// <summary>
        /// An indication that the applicant's dependency status has been overridden.
        /// </summary>
        [DataMember(Name = "dependencyOverride", EmitDefaultValue = false)]
        public FinancialAidApplicationOutcomesDependencyOverride DependencyOverride { get; set; }

        /// <summary>
        /// An indication that the applicant may be eligible to receive a Pell grant.
        /// </summary>
        [DataMember(Name = "pellEligibility", EmitDefaultValue = false)]
        public FinancialAidApplicationOutcomesPellEligibility PellEligibility { get; set; }

        /// <summary>
        /// An indication that automatic zero contribution has been applied.
        /// </summary>
        [DataMember(Name = "automaticZeroContribution", EmitDefaultValue = false)]
        public FinancialAidApplicationOutcomesAutomaticZeroContribution AutomaticZeroContribution { get; set; }

        /// <summary>
        /// An indication that the requirements for the simplified needs test have been met.
        /// </summary>
        [DataMember(Name = "simplifiedNeedsTest", EmitDefaultValue = false)]
        public FinancialAidApplicationOutcomesSimplifiedNeedsTest SimplifiedNeedsTest { get; set; }

        /// <summary>
        /// The response to a professional judgement request for the application
        /// </summary>
        [DataMember(Name = "professionalJudgement", EmitDefaultValue = false)]
        public FinancialAidApplicationOutcomesProfessionalJudgement ProfessionalJudgement { get; set; }

        /// <summary>
        /// An indication if the application has been selected for information verification
        /// </summary>
        [DataMember(Name = "verificationStatus", EmitDefaultValue = false)]
        public FinancialAidApplicationOutcomesVerificationStatus VerificationStatus { get; set; }

        /// <summary>
        /// The verification category applied to the application.
        /// </summary>
        [DataMember(Name = "verificationCategory", EmitDefaultValue = false)]
        public string VerificationCategory { get; set; }

        /// <summary>
        /// The expected contribution from the family.
        /// </summary>
        [DataMember(Name = "expectedFamilyContribution", EmitDefaultValue = false)]
        public AmountDtoProperty ExpectedFamilyContribution { get; set; }

        /// <summary>
        /// The expected contribution from the student.
        /// </summary>
        [DataMember(Name = "expectedStudentContribution", EmitDefaultValue = false)]
        public AmountDtoProperty ExpectedStudentContribution { get; set; }

        /// <summary>
        /// The expected total contribution from the parent(s).
        /// </summary>
        [DataMember(Name = "expectedTotalParentContribution", EmitDefaultValue = false)]
        public AmountDtoProperty ExpectedTotalParentContribution { get; set; }

        /// <summary>
        /// The subset of the total parental contribution provided by a noncustodial parent.
        /// </summary>
        [DataMember(Name = "expectedNoncustodialParentContribution", EmitDefaultValue = false)]
        public AmountDtoProperty ExpectedNoncustodialParentContribution { get; set; }

        /// <summary>
        /// The derived equity of the applicant's home.
        /// </summary>
        [DataMember(Name = "applicantHomeEquity", EmitDefaultValue = false)]
        public AmountDtoProperty ApplicantHomeEquity { get; set; }

        /// <summary>
        /// The derived equity of the custodial parent's home.
        /// </summary>
        [DataMember(Name = "custodialParentHomeEquity", EmitDefaultValue = false)]
        public AmountDtoProperty CustodialParentHomeEquity { get; set; }

        /// <summary>
        /// The derived equity of the non custodial parent's home.
        /// </summary>
        [DataMember(Name = "nonCustodialParentHomeEquity", EmitDefaultValue = false)]
        public AmountDtoProperty NonCustodialParentHomeEquity { get; set; }

        /// <summary>
        /// The FISAP total income.
        /// </summary>
        [DataMember(Name = "totalIncome", EmitDefaultValue = false)]
        public AmountDtoProperty TotalIncome { get; set; }
        
    }
}
