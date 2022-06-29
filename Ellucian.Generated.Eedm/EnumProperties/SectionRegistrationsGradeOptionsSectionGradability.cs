// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indicator whether the section is gradable.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SectionRegistrationsGradeOptionsSectionGradability
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// notGradable
        /// </summary>
        [EnumMember(Value = "notGradable")]
        Notgradable,

        /// <summary>
        /// gradable
        /// </summary>
        [EnumMember(Value = "gradable")]
        Gradable,
    }
}