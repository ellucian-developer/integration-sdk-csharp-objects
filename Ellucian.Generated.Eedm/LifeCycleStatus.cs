// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible Lifecycle Statuses
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LifeCycleStatus
    {
        /// <summary>
        /// Active
        /// </summary>    
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Inactive
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive
    }
}