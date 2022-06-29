// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible unit types of a meal plan
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MealPlansUnitType
    {
        /// <summary>
        /// Meal
        /// </summary>
        [EnumMember(Value = "meal")]
        Meal,

        /// <summary>
        /// Swipe
        /// </summary>
        [EnumMember(Value = "swipe")]
        Swipe,

        /// <summary>
        /// MealPoint
        /// </summary>
        [EnumMember(Value = "mealPoint")]
        MealPoint,

        /// <summary>
        /// Money
        /// </summary>
        [EnumMember(Value = "money")]
        Money

    }
}