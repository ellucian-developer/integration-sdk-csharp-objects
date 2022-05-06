// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The higher-level category of race.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RaceType
    {
        /// <summary>
        /// African American
        /// </summary>
        [EnumMember(Value = "African American")]
        AfricanAmerican,

        /// <summary>
        /// Alaska Native
        /// </summary>
        [EnumMember(Value = "Alaska Native")]
        AlaskaNative,

        /// <summary>
        /// American Indian
        /// </summary>
        [EnumMember(Value = "American Indian")]
        AmericanIndian,

        /// <summary>
        /// Asian
        /// </summary>
        Asian,

        /// <summary>
        /// Black or African-American
        /// </summary>
        Black,

        /// <summary>
        /// Native Hawaiian
        /// </summary>
        [EnumMember(Value = "Native Hawaiian")]
        NativeHawaiian,

        /// <summary>
        /// Other Pacific Islander
        /// </summary>
        [EnumMember(Value = "Other Pacific Islander")]
        OtherPacificIslander,

        /// <summary>
        /// White
        /// </summary>
        White

    }
}