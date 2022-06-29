// Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indicator as to whether the academic status is established for the 
    /// student overall or specific to a student's academic level.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentAcademicPeriodsBasis
    {
        /// <summary>
        /// A Minor.
        /// </summary>
        NotSet,

        /// <summary>
        /// By Level.
        /// </summary>
        [EnumMember(Value = "byLevel")]
        ByLevel,

        /// <summary>
        /// Overall
        /// </summary>
        [EnumMember(Value = "overall")]
        Overall,

    }
}