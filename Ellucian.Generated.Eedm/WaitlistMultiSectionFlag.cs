// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Are students allowed to waitlist multiple sections of this course?
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WaitlistMultiSectionFlag
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// Allowed
        /// </summary>
        [EnumMember(Value = "allowed")]
        Allowed,

        /// <summary>
        /// Not allowed
        /// </summary>
        [EnumMember(Value = "notAllowed")]
        NotAllowed
    }
}
