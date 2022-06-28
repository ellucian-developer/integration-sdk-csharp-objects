// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible gender types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GenderType
    {
        /// <summary>
        /// Male
        /// </summary>
        Male,

        /// <summary>
        /// Female
        /// </summary>
        Female,

        /// <summary>
        /// Unknown
        /// </summary>
        Unknown
    }
}