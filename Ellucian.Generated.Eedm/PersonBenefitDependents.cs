//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The individuals (e.g. son, wife, mother, etc.) who are dependent on a person for benefits. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PersonBenefitDependents : BaseModel2
    {
        /// <summary>
        /// The deduction agreement associated with the benefit.
        /// </summary>

        [JsonProperty("deductionArrangement")]
        public GuidObject2 DeductionArrangement { get; set; }

        /// <summary>
        /// Dependent associated with the person's benefit.
        /// </summary>

        [JsonProperty("dependent")]
        public PersonBenefitDependentsDependentDtoProperty Dependent { get; set; }

        /// <summary>
        /// The name of the benefit provider.
        /// </summary>

        [JsonProperty("providerName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ProviderName { get; set; }

        /// <summary>
        /// The identification of the benefit provider.
        /// </summary>

        [JsonProperty("providerIdentification", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ProviderIdentification { get; set; }

        /// <summary>
        /// The date when the coverage begins.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("coverageStartOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? CoverageStartOn { get; set; }

        /// <summary>
        /// The date when the coverage ends.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("coverageEndOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? CoverageEndOn { get; set; }

        /// <summary>
        /// An indication whether the dependent is attending an educational institution.
        /// </summary>

        [JsonProperty("studentStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonBenefitDependentsStudentStatus? StudentStatus { get; set; }

    }
}
