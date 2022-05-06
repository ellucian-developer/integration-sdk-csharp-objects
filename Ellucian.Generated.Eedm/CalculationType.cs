// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of calculation to be applied the assessment score.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CalculationType
    {
        /// <summary>
        /// Default
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Raw
        /// </summary>
        [EnumMember(Value = "raw")]
        Raw,

        /// <summary>
        /// calculated
        /// </summary>
        [EnumMember(Value = "calculated")]
        Calculated
    }
}