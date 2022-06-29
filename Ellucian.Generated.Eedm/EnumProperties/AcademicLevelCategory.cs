// Copyright 2018 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The category of academic level.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AcademicLevelCategory
    {
        /// <summary>
        /// Continuing Education
        /// </summary>
        [EnumMember(Value = "continuingEducation")]
        ContinuingEducation
    }
}