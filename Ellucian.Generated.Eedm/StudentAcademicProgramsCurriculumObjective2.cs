// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The curriculum objective associated with the student's academic program.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentAcademicProgramsCurriculumObjective2
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// matriculated
        /// </summary>
        [EnumMember(Value = "matriculated")]
        Matriculated,

        /// <summary>
        /// outcome
        /// </summary>
        [EnumMember(Value = "outcome")]
        Outcome,

        /// <summary>
        /// recruited
        /// </summary>
        [EnumMember(Value = "recruited")]
        Recruited,

        /// <summary>
        /// applied
        /// </summary>
        [EnumMember(Value = "applied")]
        Applied,
    }
}