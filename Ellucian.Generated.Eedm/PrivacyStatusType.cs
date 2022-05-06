// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an Privacy Status Type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrivacyStatusType
    {
        /// <summary>
        /// Unrestricted
        /// </summary>
        [EnumMember(Value = "unrestricted")]
        Unrestricted,

        /// <summary>
        /// Restricted
        /// </summary>
        [EnumMember(Value = "restricted")]
        Restricted,
    }
}