// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of waitlist types for crosslist
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WaitlistForCrosslist
    {
        /// <summary>
        /// Separate waitlists for Section
        /// </summary>
        [EnumMember(Value = "separate")]
        Separate,

        /// <summary>
        /// Combined waitlists Section
        /// </summary>
        [EnumMember(Value = "combined")]
        Combined
    }
}