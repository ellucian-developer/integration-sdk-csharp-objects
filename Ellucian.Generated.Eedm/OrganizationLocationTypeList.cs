// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of a type of location information for an organization.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrganizationLocationTypeList
    {
        /// <summary>
        /// An organization's business location.
        /// </summary>
        [EnumMember(Value = "business")]
        Business,
        /// <summary>
        /// An organizations' post office box or other mail drop location.
        /// </summary>
        [EnumMember(Value = "pobox")]
        Pobox,
        /// <summary>
        /// An organization's main office or headquarters location.
        /// </summary>
        [EnumMember(Value = "main")]
        Main,
        /// <summary>
        /// An organization's branch office location.
        /// </summary>
        [EnumMember(Value = "branch")]
        Branch,
        /// <summary>
        /// An organization's regional office location.
        /// </summary>
        [EnumMember(Value = "region")]
        Region,
        /// <summary>
        /// An organization's support or help location.
        /// </summary>
        [EnumMember(Value = "support")]
        Support,
        /// <summary>
        /// Uncategorized organization location type
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}
