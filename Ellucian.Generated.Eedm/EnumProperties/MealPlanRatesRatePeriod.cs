// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The time period for the rate.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MealPlanRatesRatePeriod
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// day
        /// </summary>
        [EnumMember(Value = "day")]
        Day,

        /// <summary>
        /// week
        /// </summary>
        [EnumMember(Value = "week")]
        Week,

        /// <summary>
        /// term
        /// </summary>
        [EnumMember(Value = "term")]
        Term,

        /// <summary>
        /// meal
        /// </summary>
        [EnumMember(Value = "meal")]
        Meal,

        /// <summary>
        /// month
        /// </summary>
        [EnumMember(Value = "month")]
        Month,

        /// <summary>
        /// year
        /// </summary>
        [EnumMember(Value = "year")]
        Year,
    }
}


