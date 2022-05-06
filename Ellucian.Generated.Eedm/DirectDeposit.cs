// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of the direct deposit status for the account payable source.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectDeposit
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Enabled
        /// </summary>
        [EnumMember(Value = "enabled")]
        Enabled,

        /// <summary>
        /// Disabled
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled
    }
}