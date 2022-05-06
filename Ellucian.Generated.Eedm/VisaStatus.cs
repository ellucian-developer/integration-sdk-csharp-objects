// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Visa status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VisaStatus
    {
        /// <summary>
        /// current
        /// </summary>
        [EnumMember(Value = "current")]
        Current,

        /// <summary>
        /// expired
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired
    }
}
