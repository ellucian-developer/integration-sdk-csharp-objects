// Copyright 2019 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indicator as to whether the object is primary.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Priority
    {
        /// <summary>
        /// A Minor.
        /// </summary>
        NotSet,

        /// <summary>
        /// Primary.
        /// </summary>
        [EnumMember(Value = "primary")]
        Primary,
    }
}