// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of phone numbers for a person
    /// </summary>
    [JsonConverter(typeof(PersonPhoneTypeCategoryEnumConverter))]
    public enum PersonPhoneTypeCategory
    {
        /// <summary>
        /// A person's mobile phone.
        /// </summary>
        [EnumMember(Value = "mobile")]
        Mobile,
        /// <summary>
        /// A person's home phone..
        /// </summary>
        [EnumMember(Value = "home")]
        Home,
        /// <summary>
        /// A person's phone while in school.
        /// </summary>
        [EnumMember(Value = "school")]
        School,
        /// <summary>
        /// A person's phone while on vacation.
        /// </summary>
        [EnumMember(Value = "vacation")]
        Vacation,
        /// <summary>
        /// A person's work phone.
        /// </summary>
        [EnumMember(Value = "business")]
        Business,
        /// <summary>
        /// A person's personal fax machine.
        /// </summary>
        [EnumMember(Value = "fax")]
        Fax,
        /// <summary>
        /// A person's pager.
        /// </summary>
        [EnumMember(Value = "pager")]
        Pager,
        /// <summary>
        /// A person's TTY/TDD device.
        /// </summary>
        [EnumMember(Value = "tdd")]
        TDD,
        /// <summary>
        /// A parent's phone.
        /// </summary>
        [EnumMember(Value = "parent")]
        Parent,
        /// <summary>
        /// A family phone.
        /// </summary>
        [EnumMember(Value = "family")]
        Family,
        /// <summary>
        /// A main phone, typically for business.
        /// </summary>
        [EnumMember(Value = "main")]
        Main,
        /// <summary>
        /// A branch phone, typically for business.
        /// </summary>
        [EnumMember(Value = "branch")]
        Branch,
        /// <summary>
        /// A region phone, typically for business.
        /// </summary>
        [EnumMember(Value = "region")]
        Region,
        /// <summary>
        /// A support phone, typically for business.
        /// </summary>
        [EnumMember(Value = "support")]
        Support,
        /// <summary>
        /// A billing phone, typically for business.
        /// </summary>
        [EnumMember(Value = "billing")]
        Billing,
        /// <summary>
        /// A matching phone, typically for business.
        /// </summary>
        [EnumMember(Value = "matchingGifts")]
        MatchingGifts,
        /// <summary>
        /// Uncategorized phone number
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}
