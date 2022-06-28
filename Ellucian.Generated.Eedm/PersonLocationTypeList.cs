// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of location types for a person
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonLocationTypeList
    {
        /// <summary>
        /// A location where a person lives while at school.
        /// </summary>
        [EnumMember(Value = "school")]
        School,
        /// <summary>
        /// A location where a person primarily lives, their permanent address.
        /// </summary>
        [EnumMember(Value = "home")]
        Home,
        /// <summary>
        /// A location where a person lives while on vacation.
        /// </summary>
        [EnumMember(Value = "vacation")]
        Vacation,
        /// <summary>
        /// A location where a person's bills would be sent.
        /// </summary>
        [EnumMember(Value = "billing")]
        Billing,
        /// <summary>
        /// A location where a person's deliveries would be sent.
        /// </summary>
        [EnumMember(Value = "shipping")]
        Shipping,
        /// <summary>
        /// A location where a person's mail would be sent.
        /// </summary>
       [EnumMember(Value = "mailing")]
        Mailing,
        /// <summary>
        /// A location where a person works
        /// </summary>
        [EnumMember(Value = "business")]
        Business,
        /// <summary>
        /// Uncategorized person location type.
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}
