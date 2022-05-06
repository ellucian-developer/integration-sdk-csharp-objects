// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The higher-level category of race.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RaceType2
    {
        /// <summary>
        /// African American
        /// </summary>
        [EnumMember(Value = "africanAmerican")]
        AfricanAmerican,

        /// <summary>
        /// Alaska Native
        /// </summary>
        [EnumMember(Value = "alaskaNative")]
        AlaskaNative,

        /// <summary>
        /// American Indian
        /// </summary>
        [EnumMember(Value = "americanIndian")]
        AmericanIndian,

        /// <summary>
        /// Asian
        /// </summary>
        [EnumMember(Value = "asian")]
        Asian,

        /// <summary>
        /// Black or African-American
        /// </summary>
        [EnumMember(Value = "black")]
        Black,

        /// <summary>
        /// Native Hawaiian
        /// </summary>
        [EnumMember(Value = "nativeHawaiian")]
        NativeHawaiian,

        /// <summary>
        /// Other Pacific Islander
        /// </summary>
        [EnumMember(Value = "otherPacificIslander")]
        OtherPacificIslander,

        /// <summary>
        /// White
        /// </summary>
        [EnumMember(Value = "white")]
        White

    }
}