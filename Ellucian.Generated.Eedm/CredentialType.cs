// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible credential types associated to a person
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CredentialType
    {
        /// <summary>
        /// Social Security Number
        /// </summary>
        [EnumMember(Value = "Social Security Number")]
        SocialSecurityNumber,

        /// <summary>
        /// Social Insurance Number
        /// </summary>
        [EnumMember(Value = "Social Insurance Number")]
        SocialInsuranceNumber,

        /// <summary>
        /// A person's internal Colleague ID
        /// </summary>
        [EnumMember(Value = "Colleague Person ID")]
        ColleaguePersonId,

        /// <summary>
        /// A person's internal Elevate ID
        /// </summary>
        [EnumMember(Value = "Elevate ID")]
        ElevatePersonId,

        /// <summary>
        /// A person's internal Banner ID
        /// </summary>
        [EnumMember(Value = "Banner ID")]
        BannerPersonId
    }
}