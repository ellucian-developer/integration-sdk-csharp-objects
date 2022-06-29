// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible time periods of a meal plan
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MealPlansTimePeriod
    {
        /// <summary>
        /// Day
        /// </summary>
        [EnumMember(Value = "day")]
        Day,

        /// <summary>
        /// Week
        /// </summary>
        [EnumMember(Value = "week")]
        Week,

        /// <summary>
        /// Month
        /// </summary>
        [EnumMember(Value = "month")]
        Month,

        /// <summary>
        /// Year
        /// </summary>
        [EnumMember(Value = "year")]
        Year,

        /// <summary>
        /// Term
        /// </summary>
        [EnumMember(Value = "term")]
        Term,

        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "other")]
        Other

    }
}
