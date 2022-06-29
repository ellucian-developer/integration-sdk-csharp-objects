// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of the organization
    /// </summary>
    [JsonConverter(typeof(Converters.OrganizationRoleTypeEnumConverter))]
    public enum OrganizationRoleType
    {
        /// <summary>
        /// default value to use in the cases where the property is not set correctly or not specrified
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Partner
        /// </summary>
        [EnumMember(Value = "partner")]
        Partner,

        /// <summary>
        /// Affiliate
        /// </summary>
        [EnumMember(Value = "affiliate")]
        Affiliate,

        /// <summary>
        /// Constituent
        /// </summary>
        [EnumMember(Value = "constituent")]
        Constituent,

        /// <summary>
        /// Vendor
        /// </summary>
        [EnumMember(Value = "vendor")]
        Vendor
    }
}