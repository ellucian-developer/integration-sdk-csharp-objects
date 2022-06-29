// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Check if a section is searchable or hidden
    /// </summary>
    [JsonConverter(typeof (StringEnumConverter))]
    public enum SectionsSearchable
    {
        /// <summary>
        /// Not Set
        /// </summary>
        NotSet,
   
        /// <summary>
        /// yes
        /// </summary>
        [EnumMember(Value = "yes")] 
        Yes,

        /// <summary>
        /// no
        /// </summary>
        [EnumMember(Value = "no")] 
        No,

        /// <summary>
        /// hidden
        /// </summary>
        [EnumMember(Value = "hidden")]
        Hidden
    }
}