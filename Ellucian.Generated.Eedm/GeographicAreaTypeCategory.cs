// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an Geographic Area Type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GeographicAreaTypeCategory
    {
        /// <summary>
        /// Governmental
        /// </summary>
        [EnumMember(Value = "governmental")]
        Governmental,

        /// <summary>
        /// Postal
        /// </summary>
        [EnumMember(Value = "postal")]
        Postal,

        /// <summary>
        /// Fundraising
        /// </summary>
        [EnumMember(Value = "fundraising")]
        Fundraising,

        /// <summary>
        /// Recruitment
        /// </summary>
        [EnumMember(Value = "recruitment")]
        Recruitment,
    }
}