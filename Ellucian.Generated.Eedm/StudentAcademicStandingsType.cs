// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of academic standing calculation used to determine the student academic standing (e.g. level, program, academicPeriod).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentAcademicStandingsType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// level
        /// </summary>
        [EnumMember(Value = "level")]
        Level,

        /// <summary>
        /// program
        /// </summary>
        [EnumMember(Value = "program")]
        Program,

        /// <summary>
        /// academicPeriod
        /// </summary>
        [EnumMember(Value = "academicPeriod")]
        Academicperiod,
    }
}


