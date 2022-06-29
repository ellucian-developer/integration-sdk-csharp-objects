// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The indication that the requirements for the simplified needs test has been met for a financial aid application.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidApplicationOutcomesSimplifiedNeedsTest
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
        
        /// <summary>
        /// met
        /// </summary>
        [EnumMember(Value = "met")]
        Met,

        /// <summary>
        /// not met
        /// </summary>
        [EnumMember(Value = "notMet")]
        NotMet,

    }
}
