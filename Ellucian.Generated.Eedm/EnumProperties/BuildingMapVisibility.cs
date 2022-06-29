// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of building map visibility
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BuildingMapVisibility
    {
        /// <summary>
        /// Default for when the enumeration is not set
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Visible
        /// </summary>
        [EnumMember(Value = "visible")]
        Visible,

        /// <summary>
        /// Not visible
        /// </summary>
        [EnumMember(Value = "notVisible")]
        NotVisible
    }
}