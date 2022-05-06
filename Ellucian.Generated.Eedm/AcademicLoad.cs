// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Academic Load
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AcademicLoad
    {
        /// <summary>
        /// Default
        /// </summary>
        NotSet = 0,
        
        /// <summary>
        /// Part Time
        /// </summary>
        [EnumMember(Value = "partTime")]
        PartTime,

        /// <summary>
        /// Over Load
        /// </summary>
        [EnumMember(Value = "overLoad")]
        OverLoad,

        /// <summary>
        /// Full Time
        /// </summary>
        [EnumMember(Value = "fullTime")]
        FullTime,
    }
}
