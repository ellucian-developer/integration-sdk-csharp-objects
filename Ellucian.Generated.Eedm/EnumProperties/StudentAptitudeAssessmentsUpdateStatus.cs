// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an Student Aptitude Assessments Score
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentAptitudeAssessmentsUpdateStatus
    {

        /// <summary>
        ///Not set 
        /// </summary>
        NotSet = 0,
        /// <summary>
        ///original
        /// </summary>
        [EnumMember(Value = "original")]
        Original,

        /// <summary>
        /// revised
        /// </summary>
        [EnumMember(Value = "revised")]
        Revised,

         /// <summary>
        /// recentered
        /// </summary>
        [EnumMember(Value = "recentered")]
        Recentered

    }
}