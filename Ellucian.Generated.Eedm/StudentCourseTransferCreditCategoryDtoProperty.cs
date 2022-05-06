// Copyright 2015 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The category of credit associated with the articulated/equivalent course
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentCourseTransferCreditCategoryDtoProperty
    {
        /// <summary>
        /// The higher-level category of academic credits
        /// </summary>
        [JsonProperty("creditType")]
        public StudentCourseTransferCreditType CreditType { get; set; }

        /// <summary>
        /// The institutionally defined credit category assigned to the articulated/equivalent course
        /// </summary>
        [JsonProperty("detail")]
        public GuidObject2 Detail { get; set; }


    }
}
