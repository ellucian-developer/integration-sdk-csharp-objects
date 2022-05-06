// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The category associated with the course status (active or ended).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CourseStatusesCategory
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// active
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// ended
        /// </summary>
        [EnumMember(Value = "ended")]
        Ended,
    }
}


