 
//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The unit specification that was awarded to the articulated/equivalent course. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StudentCourseTransferCreditDtoProperty
    {
        /// <summary>
        /// The category of credit associated with the articulated/equivalent course.
        /// </summary>

        [JsonProperty("creditCategory", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentCourseTransferCreditCategoryDtoProperty CreditCategory { get; set; }

        /// <summary>
        /// A unit or standard of measurement for the credit.
        /// </summary>

        [JsonProperty("measure", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public StudentCourseTransferMeasure Measure { get; set; }

        /// <summary>
        /// The credit awarded for the articulated/equivalent course.
        /// </summary>

        [JsonProperty("awardedCredit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? AwardedCredit { get; set; }




    }
}

