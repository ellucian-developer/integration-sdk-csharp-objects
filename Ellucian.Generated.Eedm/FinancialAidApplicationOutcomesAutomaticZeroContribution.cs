// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The application state of automatic zero contribution of a financial aid application.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidApplicationOutcomesAutomaticZeroContribution
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
        
        /// <summary>
        /// applied
        /// </summary>
        [EnumMember(Value = "applied")]
        Applied,

        /// <summary>
        /// not applied
        /// </summary>
        [EnumMember(Value = "notApplied")]
        NotApplied,

    }
}
