// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Check if a section is searchable or hidden
    /// </summary>
    [JsonConverter(typeof (StringEnumConverter))]
    public enum RestrictedVisibility
    {
        /// <summary>
        /// Not Set
        /// </summary>
        NotSet,

        /// <summary>
        /// yes
        /// </summary>
        [EnumMember(Value = "yes")] 
        Yes
    }
}