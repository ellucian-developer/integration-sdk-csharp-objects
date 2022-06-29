// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The status of the room assignment.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HousingAssignmentsStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// pending
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// assigned
        /// </summary>
        [EnumMember(Value = "assigned")]
        Assigned,

        /// <summary>
        /// canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled,

        /// <summary>
        /// terminated
        /// </summary>
        [EnumMember(Value = "terminated")]
        Terminated,

        /// <summary>
        /// prorated
        /// </summary>
        [EnumMember(Value = "prorated")]
        Prorated
    }
}