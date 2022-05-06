// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The name of a higher level veteran status category to which the status belongs.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VeteranStatusesCategory
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// nonVeteran
        /// </summary>
        [EnumMember(Value = "nonVeteran")]
        Nonveteran,

        /// <summary>
        /// activeDuty
        /// </summary>
        [EnumMember(Value = "activeDuty")]
        Activeduty,

        /// <summary>
        /// protectedVeteran
        /// </summary>
        [EnumMember(Value = "protectedVeteran")]
        Protectedveteran,

        /// <summary>
        /// nonProtectedVeteran
        /// </summary>
        [EnumMember(Value = "nonProtectedVeteran")]
        Nonprotectedveteran,
    }
}


