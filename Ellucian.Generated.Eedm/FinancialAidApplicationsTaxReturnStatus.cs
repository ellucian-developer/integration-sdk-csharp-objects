// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The tax return state of a financial aid applicant.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidApplicationsTaxReturnStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
        
        /// <summary>
        /// filed
        /// </summary>
        [EnumMember(Value = "filed")]
        Filed,

        /// <summary>
        /// will file
        /// </summary>
        [EnumMember(Value = "willFile")]
        WillFile,

        /// <summary>
        /// will not file
        /// </summary>
        [EnumMember(Value = "willNotFile")]
        WillNotFile,
    }
}
