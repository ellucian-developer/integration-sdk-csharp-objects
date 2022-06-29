// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Specifies the day of the week in proper HEDM case
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HedmDayOfWeek
    {
        /// <summary>
        /// Indicates Sunday.
        /// </summary>
        [EnumMember(Value = "sunday")]
        Sunday = 0,
        /// <summary>
        /// Indicates Monday.
        /// </summary>
        [EnumMember(Value = "monday")]
        Monday = 1,
        /// <summary>
        /// Indicates Tuesday.
        /// </summary>
        [EnumMember(Value = "tuesday")]
        Tuesday = 2,
        /// <summary>
        /// Indicates Wednesday.
        /// </summary>
        [EnumMember(Value = "wednesday")]
        Wednesday = 3,
        /// <summary>
        /// Indicates Thursday.
        /// </summary>
        [EnumMember(Value = "thursday")]
        Thursday = 4,
        /// <summary>
        /// Indicates Friday.
        /// </summary>
        [EnumMember(Value = "friday")]
        Friday = 5,
        /// <summary>
        /// Indicates Saturday
        /// </summary>
        [EnumMember(Value = "saturday")]
        Saturday = 6
    }
}
