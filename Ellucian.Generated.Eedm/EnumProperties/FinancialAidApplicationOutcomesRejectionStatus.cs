// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The rejection state of a financial aid application.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidApplicationOutcomesRejectionStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
        
        /// <summary>
        /// not rejected
        /// </summary>
        [EnumMember(Value = "notRejected")]
        NotRejected,

        /// <summary>
        /// rejected
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected,

    }
}
