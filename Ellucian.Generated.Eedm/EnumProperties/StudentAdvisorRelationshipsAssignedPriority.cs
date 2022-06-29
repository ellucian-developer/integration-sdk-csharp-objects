// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The prioritization (e.g. primary) of the advisor as the source of guidance for the student.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentAdvisorRelationshipsAssignedPriority
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
    }
}