// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Credit DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    [DataContract]
    public class Credit3DtoProperty
    {
        /// <summary>
        /// Credit Category for credit.
        /// </summary>
        [DataMember(Name = "creditCategory", EmitDefaultValue = false)]
        [JsonProperty("creditCategory", NullValueHandling = NullValueHandling.Ignore)]
        public CreditIdAndTypeProperty2 CreditCategory { get; set; }

        /// <summary>
        /// The type of credit earned for the course or section.
        /// </summary>
        [DataMember(Name = "measure", EmitDefaultValue = false)]
        [JsonProperty("measure", NullValueHandling = NullValueHandling.Ignore)]
        public CreditMeasure2? Measure { get; set; }

        /// <summary>
        /// The academic credit for the section assessed at the registration.
        /// </summary>
        [DataMember(Name = "attemptedCredit", EmitDefaultValue = false)]
        [JsonProperty("attemptedCredit", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AttemptedCredit { get; set; }

        /// <summary>
        /// The credit the student actually earned by completing the section.
        /// </summary>
        [DataMember(Name = "earnedCredit", EmitDefaultValue = false)]
        [JsonProperty("earnedCredit", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? EarnedCredit { get; set; }       
    }
}
