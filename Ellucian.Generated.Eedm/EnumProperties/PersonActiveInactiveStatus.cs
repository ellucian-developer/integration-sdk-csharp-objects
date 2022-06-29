// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Person active/inactive status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonActiveInactiveStatus
    {
        /// <summary>
        /// current
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// expired
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive
    }
}
