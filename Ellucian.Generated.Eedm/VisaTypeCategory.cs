// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an visa category
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VisaTypeCategory
    {
        /// <summary>
        /// immigrant
        /// </summary>
        [EnumMember(Value = "immigrant")]
        Immigrant,

        /// <summary>
        /// nonImmigrant
        /// </summary>
        [EnumMember(Value = "nonImmigrant")]
        NonImmigrant,

        /// <summary>
        /// Default
        /// </summary>
        NotSet = 0
    }
}
