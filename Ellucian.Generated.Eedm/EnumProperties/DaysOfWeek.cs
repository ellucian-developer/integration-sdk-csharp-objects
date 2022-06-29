// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of days of week
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DaysOfWeek
    {
        /// <summary>
        /// Sunday
        /// </summary>
        [EnumMember(Value = "sunday")]
        Sunday,

        /// <summary>
        /// Monday
        /// </summary>
        [EnumMember(Value = "monday")]
        Monday,

        /// <summary>
        /// Tuesday
        /// </summary>
        [EnumMember(Value = "tuesday")]
        Tuesday,

        /// <summary>
        /// Wednesday
        /// </summary>
        [EnumMember(Value = "wednesday")]
        Wednesday,

        /// <summary>
        /// Thursday
        /// </summary>
        [EnumMember(Value = "thursday")]
        Thursday,

        /// <summary>
        /// Friday
        /// </summary>
        [EnumMember(Value = "friday")]
        Friday,

        /// <summary>
        /// Saturday
        /// </summary>
        [EnumMember(Value = "saturday")]
        Saturday,

        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "other")]
        Other,

    }
}