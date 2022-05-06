// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The Pell eligibility of a financial aid applicant.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidApplicationOutcomesPellEligibility
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
        
        /// <summary>
        /// eligible
        /// </summary>
        [EnumMember(Value = "eligible")]
        Eligible,

        /// <summary>
        /// not eligible
        /// </summary>
        [EnumMember(Value = "notEligible")]
        NotEligible,

    }
}
