// Copyright 2021 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of the Section Hide in Catalog field.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SectionCatalogDisplay
    {
        /// <summary>
        /// Visible
        /// </summary>
        [EnumMember(Value = "visible")]
        Visible,

        /// <summary>
        /// Hidden
        /// </summary>
        [EnumMember(Value = "hidden")]
        Hidden,
    }
}
