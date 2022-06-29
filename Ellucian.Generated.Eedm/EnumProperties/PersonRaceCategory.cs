// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible races to which a person belongs.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonRaceCategory
    {
        /// <summary>
        /// Native American or Alaskan Native
        /// </summary>
        [EnumMember(Value = "americanIndianOrAlaskaNative")]
        AmericanIndianOrAlaskaNative,
        /// <summary>
        /// Asian.
        /// </summary>
        [EnumMember(Value = "asian")]
        Asian,
        /// <summary>
        /// Black or African American.
        /// </summary>
        [EnumMember(Value = "blackOrAfricanAmerican")]
        BlackOrAfricanAmerican,
        /// <summary>
        /// Hawaiian or Pacific Islander
        /// </summary>
        [EnumMember(Value = "hawaiianOrPacificIslander")]
        HawaiianOrPacificIslander,
        /// <summary>
        /// White
        /// </summary>
        [EnumMember(Value = "white")]
        White
    }
}