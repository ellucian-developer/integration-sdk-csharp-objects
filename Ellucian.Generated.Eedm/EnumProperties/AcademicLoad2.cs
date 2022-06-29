// Copyright 2020 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Academic Load
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AcademicLoad2
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
        [EnumMember(Value = "overload")]
        OverLoad,

        /// <summary>
        /// Full Time
        /// </summary>
        [EnumMember(Value = "fullTime")]
        FullTime,
    }
}
