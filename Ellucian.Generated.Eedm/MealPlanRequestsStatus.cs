// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The status of the request
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MealPlanRequestsStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// submitted
        /// </summary>
        [EnumMember(Value = "submitted")]
        Submitted,

        /// <summary>
        /// approved
        /// </summary>
        [EnumMember(Value = "approved")]
        Approved,

        /// <summary>
        /// rejected
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected,

        /// <summary>
        /// withdrawn
        /// </summary>
        [EnumMember(Value = "withdrawn")]
        Withdrawn,
    }
}

