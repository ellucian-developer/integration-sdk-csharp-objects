// Copyright 2014-2018 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an address
    /// </summary>
    [JsonConverter(typeof(AddressTypeEnumConverter))]
    public enum AddressType
    {
        /// <summary>
        /// Home
        /// </summary>
        [EnumMember(Value = "home")]
        Home,

        /// <summary>
        /// School
        /// </summary>
        [EnumMember(Value = "school")]
        School,

        /// <summary>
        /// Vacation
        /// </summary>
        [EnumMember(Value = "vacation")]
        Vacation,

        /// <summary>
        /// Billing
        /// </summary>
        [EnumMember(Value = "billing")]
        Billing,

        /// <summary>
        /// Shipping
        /// </summary>
        [EnumMember(Value = "shipping")]
        Shipping,

        /// <summary>
        /// Mailing
        /// </summary>
        [EnumMember(Value = "mailing")]
        Mailing,

        /// <summary>
        /// Business
        /// </summary>
        [EnumMember(Value = "business")]
        Business,

        /// <summary>
        /// Parent
        /// </summary>
        [EnumMember(Value = "parent")]
        Parent,

        /// <summary>
        /// Family
        /// </summary>
        [EnumMember(Value = "family")]
        Family,

        /// <summary>
        /// Po Box
        /// </summary>
        [EnumMember(Value = "pobox")]
        Pobox,

        /// <summary>
        /// Main
        /// </summary>
        [EnumMember(Value = "main")]
        Main,

        /// <summary>
        /// Branch
        /// </summary>
        [EnumMember(Value = "branch")]
        Branch,

        /// <summary>
        /// Region
        /// </summary>
        [EnumMember(Value = "region")]
        Region,

        /// <summary>
        /// Support
        /// </summary>
        [EnumMember(Value = "support")]
        Support,

        /// <summary>
        /// Matching Gifts
        /// </summary>
        [EnumMember(Value = "matchingGifts")]
        MatchingGifts,

        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}