// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about the location at which an instructional event occurs
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InstructionalLocationType 
    { 
        /// <summary>
        /// Site
        /// </summary>
        [EnumMember(Value = "site")]
        InstructionalSite, 
        /// <summary>
        /// Room
        /// </summary>
        [EnumMember(Value = "room")]
        InstructionalRoom, 
        /// <summary>
        /// Online
        /// </summary>
        [EnumMember(Value = "online")]
        InstructionalOnline, 
        /// <summary>
        /// Other location
        /// </summary>
        [EnumMember(Value = "other")]
        InstructionalOtherLocation 
    }
}
