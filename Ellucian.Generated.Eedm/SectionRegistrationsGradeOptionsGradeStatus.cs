// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indicator whether the student has a verified grade or the section registration.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SectionRegistrationsGradeOptionsGradeStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// verified
        /// </summary>
        [EnumMember(Value = "verified")]
        Verified,

        /// <summary>
        /// unverified
        /// </summary>
        [EnumMember(Value = "unverified")]
        Unverified,
    }
}