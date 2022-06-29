// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The selection state of a financial aid applicant for information verification
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidApplicationOutcomesVerificationStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
        
        /// <summary>
        /// selected
        /// </summary>
        [EnumMember(Value = "selected")]
        Selected,

        /// <summary>
        /// not selected
        /// </summary>
        [EnumMember(Value = "notSelected")]
        NotSelected,

    }
}
