// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Detailed information concerning student financial aid need summaries.
    /// </summary>
    [DataContract]
    public class StudentFinancialAidNeedSummaries_V9_0 : BaseModel2
    {

        /// <summary>
        /// The person associated with the financial aid need summary
        /// </summary>
        //[JsonProperty("applicant")]
        [DataMember(Name = "applicant", EmitDefaultValue = false)]
        //public FinancialAidApplicationApplicant Applicant { get; set; }
        public GuidObject2 Applicant { get; set; }
        
        /// <summary>
        /// The financial aid year for student need
        /// </summary>
        [JsonProperty("aidYear", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 AidYear { get; set; }

        /// <summary>
        /// The student financial aid needs by methodology
        /// </summary>
        [DataMember(Name = "needsByMethodology", EmitDefaultValue = false)]
        public List<StudentFinancialAidNeedsByMethodologyDtoProperty> NeedsByMethodology { get; set; }

        /// <summary>
        /// The additional financial resources available to the applicant which are not managed by the financial aid office
        /// </summary>
        [DataMember(Name = "outsideResources", EmitDefaultValue = false)]
        public AmountDtoProperty OutsideResources { get; set; }

        ///// <summary>
        ///// The financial aid resources managed by the financial aid office which are available to the applicant.
        ///// </summary>
        //[DataMember(Name = "totalNeedReduction", EmitDefaultValue = false)]
        //public AmountDtoProperty TotalNeedReduction { get; set; }        
    }
}
