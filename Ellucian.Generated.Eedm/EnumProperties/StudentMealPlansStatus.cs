// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The status of the meal plan assignment.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentMealPlansStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// assigned
        /// </summary>
        [EnumMember(Value = "assigned")]
        Assigned,

        /// <summary>
        /// cancelled
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled,

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


