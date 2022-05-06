// Copyright 2015-18 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;
namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of email address types
    /// </summary>
    [JsonConverter(typeof(EmailTypeEnumConverter))]
    public enum EmailTypeList
    {
        /// <summary>
        /// A person's/organization's personal email address.
        /// </summary>
        [EnumMember(Value = "personal")]
        Personal,
        /// <summary>
        /// A person's/organization's business email address.
        /// </summary>
        [EnumMember(Value = "business")]
        Business,
        /// <summary>
        /// A person's/organization's school email address.
        /// </summary>
        [EnumMember(Value = "school")]
        School,
        /// <summary>
        /// An person's/organization's parent email address.
        /// </summary>
        [EnumMember(Value = "parent")]
        Parent,
        /// <summary>
        /// An person's/organization's family email address.
        /// </summary>
        [EnumMember(Value = "family")]
        Family,
        /// <summary>
        /// An person's/organization's email address for sales inquiries.
        /// </summary>
        [EnumMember(Value = "sales")]
        Sales,
        /// <summary>
        /// A person's/organization's email address for support inquiries.
        /// </summary>
        [EnumMember(Value = "support")]
        Support,
        /// <summary>
        /// A person's/organization's email address for general inquiries.
        /// </summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>
        /// A person's/organization's email address for billing inquiries.
        /// </summary>
        [EnumMember(Value = "billing")]
        Billing,
        /// <summary>
        /// A person's/organization's email address for legal inquiries.
        /// </summary>
        [EnumMember(Value = "legal")]
        Legal,
        /// <summary>
        /// A person's/organization's email address for HR inquiries.
        /// </summary>
        [EnumMember(Value = "hr")]
        HR,
        /// <summary>
        /// A person's/organization's email address for media inquiries.
        /// </summary>
        [EnumMember(Value = "media")]
        Media,
        /// <summary>
        /// A person's/organization's email address for matching gifts inquiries.
        /// </summary>
        [EnumMember(Value = "matchingGifts")]
        MatchingGifts,
        /// <summary>
        /// Uncategorized email address.
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}
