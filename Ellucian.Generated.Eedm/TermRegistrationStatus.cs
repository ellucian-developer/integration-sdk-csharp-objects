// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Term registration status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TermRegistrationStatus
    {
        /// <summary>
        /// default value to use in the cases where the property is not set correctly or not specrified
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// open
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// closed
        /// </summary>
        [EnumMember(Value = "closed")]
        Closed
    }
}
