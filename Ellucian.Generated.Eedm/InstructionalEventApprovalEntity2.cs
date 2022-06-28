// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Entities for instructional event approvals
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstructionalEventApprovalEntity2
    {
        /// <summary>
        /// User
        /// </summary>
        [EnumMember(Value = "user")]
        User,

        /// <summary>
        /// System
        /// </summary>
        [EnumMember(Value = "system")]
        System
    }
}
