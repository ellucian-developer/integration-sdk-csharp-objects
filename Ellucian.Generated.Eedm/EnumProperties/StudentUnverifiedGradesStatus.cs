// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details of the student's last known attendance.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentUnverifiedGradesStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// neverAttended
        /// </summary>
        [EnumMember(Value = "neverAttended")]
        Neverattended,
    }
}
