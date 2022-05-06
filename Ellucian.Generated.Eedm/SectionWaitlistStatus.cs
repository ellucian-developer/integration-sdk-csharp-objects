// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of the Buyer status.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SectionWaitlistStatus
    {
        /// <summary>
        /// Open
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// Closed
        /// </summary>
        [EnumMember(Value = "closed")]
        Closed,
    }
}
