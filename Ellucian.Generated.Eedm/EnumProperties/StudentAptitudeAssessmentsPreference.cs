// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible preference of Student Aptitude Assessments 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentAptitudeAssessmentsPreference
    {
        /// <summary>
        ///Not set 
        /// </summary>
        NotSet = 0,
        /// <summary>
        ///primary
        /// </summary>
        [EnumMember(Value = "primary")]
        Primary      

    }
}