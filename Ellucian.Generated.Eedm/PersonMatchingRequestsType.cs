// Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of outcome (initial or final).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonMatchingRequestsType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// initial
        /// </summary>
        [EnumMember(Value = "initial")]
        Initial,

        /// <summary>
        /// final
        /// </summary>
        [EnumMember(Value = "final")]
        Final
    }
}

