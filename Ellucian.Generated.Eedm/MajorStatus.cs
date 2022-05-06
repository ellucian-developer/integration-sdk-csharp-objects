// Copyright 2018 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Major Status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MajorStatus
    {

        /// <summary>
        /// Not Set
        /// </summary>
        NotSet,

        /// <summary>
        /// Active
         /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Inactive
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive,

    }
}
