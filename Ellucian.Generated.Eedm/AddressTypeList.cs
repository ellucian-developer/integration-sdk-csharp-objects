// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of address types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddressTypeList
    {
        /// <summary>
        /// A address where a person lives while at school.
        /// </summary>
        [EnumMember(Value = "school")]
        School,
        /// <summary>
        /// A address where a person primarily lives, their permanent address.
        /// </summary>
        [EnumMember(Value = "home")]
        Home,
        /// <summary>
        /// A address where a person lives while on vacation.
        /// </summary>
        [EnumMember(Value = "vacation")]
        Vacation,
        /// <summary>
        /// A address where a person's bills would be sent.
        /// </summary>
        [EnumMember(Value = "billing")]
        Billing,
        /// <summary>
        /// A address where a person's deliveries would be sent.
        /// </summary>
        [EnumMember(Value = "shipping")]
        Shipping,
        /// <summary>
        /// A address where a person's mail would be sent.
        /// </summary>
       [EnumMember(Value = "mailing")]
        Mailing,
        /// <summary>
        /// A address where a person works
        /// </summary>
        [EnumMember(Value = "business")]
        Business,
        /// <summary>
        /// Parent address.
        /// </summary>
        [EnumMember(Value = "parent")]
        Parent,
        /// <summary>
        /// Family address.
        /// </summary>
        [EnumMember(Value = "family")]
        Family,
        /// <summary>
        /// An organizations' post office box or other mail drop address.
        /// </summary>
        [EnumMember(Value = "pobox")]
        Pobox,
        /// <summary>
        /// An organization's main office or headquarters address.
        /// </summary>
        [EnumMember(Value = "main")]
        Main,
        /// <summary>
        /// An organization's branch office address.
        /// </summary>
        [EnumMember(Value = "branch")]
        Branch,
        /// <summary>
        /// An organization's regional office address.
        /// </summary>
        [EnumMember(Value = "region")]
        Region,
        /// <summary>
        /// An organization's support or help address.
        /// </summary>
        [EnumMember(Value = "support")]
        Support,
        /// <summary>
        /// Matching gifts address.
        /// </summary>
        [EnumMember(Value = "matchingGifts")]
        MatchingGifts,
        /// <summary>
        /// Uncategorized person address type.
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}
