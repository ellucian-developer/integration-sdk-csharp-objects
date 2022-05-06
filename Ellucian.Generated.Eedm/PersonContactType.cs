// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The types of the contact
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonContactType
    {
        /// <summary>
        /// Emergency
        /// </summary>
        [EnumMember(Value = "emergency")]
        Emergency,

        /// <summary>
        /// MissingPerson
        /// </summary>
        [EnumMember(Value = "missingPerson")]
        MissingPerson
    }
}