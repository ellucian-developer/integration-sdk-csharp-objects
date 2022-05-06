// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A type of Academic Credential
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AcademicCredentialType
    {
        /// <summary>
        /// A degree awarded by an institution
        /// </summary>
        [EnumMember(Value = "degree")]
        Degree,

        /// <summary>
       /// A diploma awarded by an institution
        /// </summary>
        [EnumMember(Value = "diploma")]
        Diploma,

        /// <summary>
        /// An honorary degree awarded by an institution
        /// </summary>
        [EnumMember(Value = "honorary")]
        Honorary,

        /// <summary>
        /// "A certificate awarded by an institution
        /// </summary>
        [EnumMember(Value = "certificate")]
        Certificate
    }
}