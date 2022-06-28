// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The kind of ethnicity associated with an ethnicity.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EthnicityType
    {
        /// <summary>
        /// Hispanic/Latino
        /// </summary>
        Hispanic,

        /// <summary>
        /// Non-Hispanic
        /// </summary>
        [EnumMember(Value = "Non-Hispanic")]
        Nonhispanic
    }
}