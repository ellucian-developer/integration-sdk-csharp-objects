// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indication whether the position was considered as primary for the employee.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExternalEmploymentsPriority
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// primary
        /// </summary>
        [EnumMember(Value = "primary")]
        Primary,

        /// <summary>
        /// secondary
        /// </summary>
        [EnumMember(Value = "secondary")]
        Secondary,
    }
}

