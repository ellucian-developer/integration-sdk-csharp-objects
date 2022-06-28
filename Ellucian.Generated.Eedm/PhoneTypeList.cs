// Copyright 2015-16 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible phone types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PhoneTypeList
    {
        /// <summary>
        /// Default value used for null checks
        /// </summary>
        NotSet = 0,
        /// <summary>
        /// A person's/organization's mobile phone.
        /// </summary>
        [EnumMember(Value = "mobile")]
        Mobile,
        /// <summary>
        /// A person's/organization's home phone..
        /// </summary>
        [EnumMember(Value = "home")]
        Home,
        /// <summary>
        /// A person's/organization's phone while in school.
        /// </summary>
        [EnumMember(Value = "school")]
        School,
        /// <summary>
        /// A person's/organization's phone while on vacation.
        /// </summary>
        [EnumMember(Value = "vacation")]
        Vacation,
        /// <summary>
        /// A person's/organization's work phone.
        /// </summary>
        [EnumMember(Value = "business")]
        Business,
        /// <summary>
        /// A person's/organization's personal fax machine.
        /// </summary>
        [EnumMember(Value = "fax")]
        Fax,
        /// <summary>
        /// A person's/organization's pager.
        /// </summary>
        [EnumMember(Value = "pager")]
        Pager,
        /// <summary>
        /// A person's/organization's TTY/TDD device.
        /// </summary>
        [EnumMember(Value = "tdd")]
        TDD,
        /// <summary>
        /// A person's/organization's family phone.
        /// </summary>
        [EnumMember(Value = "family")]
        Family,
        /// <summary>
        /// A person's/organization's parent phone.
        /// </summary>
        [EnumMember(Value = "parent")]
        Parent,
        /// <summary>
        /// A person's/organization's main office or headquarters phone.
        /// </summary>
        [EnumMember(Value = "main")]
        Main,
        /// <summary>
        /// A person's/organization's branch office phone.
        /// </summary>
        [EnumMember(Value = "branch")]
        Branch,
        /// <summary>
        /// A person's/organization's regional office phone.
        /// </summary>
        [EnumMember(Value = "region")]
        Region,
        /// <summary>
        /// A person's/organization's support or help phone.
        /// </summary>
        [EnumMember(Value = "support")]
        Support,
        /// <summary>
        /// A person's/organization's phone number for billing information
        /// </summary>
        [EnumMember(Value = "billing")]
        Billing,
        /// <summary>
        /// A person's/organization's phone number for matching information.
        /// </summary>
        [EnumMember(Value = "matchingGifts")]
        Matching,
        /// <summary>
        /// Uncategorized phone number
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}
