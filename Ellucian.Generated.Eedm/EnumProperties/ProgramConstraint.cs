// Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of the Program Constraint Type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProgramConstraint
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Federal.
        /// </summary>
        [EnumMember(Value = "requiredDiscipline")]
        RequiredDiscipline,
    }
}
