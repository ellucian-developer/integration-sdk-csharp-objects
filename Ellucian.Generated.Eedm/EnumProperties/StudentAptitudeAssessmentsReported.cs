// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible nature of of an Student Aptitude Assessments 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentAptitudeAssessmentsReported
    {
        /// <summary>
        ///Not set 
        /// </summary>
        NotSet = 0,

        /// <summary>
        ///official
        /// </summary>
        [EnumMember(Value = "official")]
        Official,

        /// <summary>
        /// unofficial
        /// </summary>
        [EnumMember(Value = "unofficial")]
        Unofficial
    }
}