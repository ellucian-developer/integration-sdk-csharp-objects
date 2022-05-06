// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A type of Academic Discipline
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AcademicDisciplineType2
    {
        /// <summary>
        /// A Minor.
        /// </summary>
        NotSet,

        /// <summary>
        /// A Minor.
        /// </summary>
        [EnumMember(Value = "minor")]
        Minor,

        /// <summary>
        /// A Major.
        /// </summary>
        [EnumMember(Value = "major")]
        Major,

        /// <summary>
        /// A Concentration.
        /// </summary>
        [EnumMember(Value = "concentration")]
        Concentration
    }
}