// Copyright 2020 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The ledger type associated with the activity (general or operating)
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LedgerActivityLedgerType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// general
        /// </summary>
        [EnumMember(Value = "general")]
        General,

        /// <summary>
        /// operating
        /// </summary>
        [EnumMember(Value = "operating")]
        Operating,
    }
} 


