// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an Employment Proficiency Type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EmploymentProficiencyType
    {
        /// <summary>
        /// Skill
        /// </summary>
        [EnumMember(Value = "skill")]
        Skill,

        /// <summary>
        /// Certification
        /// </summary>
        [EnumMember(Value = "certification")]
        Certification,

        /// <summary>
        /// Examination
        /// </summary>
        [EnumMember(Value = "examination")]
        Examination,
    }
}