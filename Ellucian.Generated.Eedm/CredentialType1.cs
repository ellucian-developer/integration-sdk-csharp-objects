﻿// Copyright 2015 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible instructor name types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CredentialType1
    {
        /// <summary>
        /// Default for when the enumeration is not set
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// SSN
        /// </summary>
        [EnumMember(Value = "ssn")]
        Ssn,

        /// <summary>
        /// SSN
        /// </summary>
        [EnumMember(Value = "sin")]
        Sin,

        /// <summary>
        /// bannerId
        /// </summary>
        [EnumMember(Value = "bannerId")]
        BannerId,

        /// <summary>
        /// colleagePersonId
        /// </summary>
        [EnumMember(Value = "colleaguePersonId")]
        ColleaguePersonId,

        /// <summary>
        /// elevateID
        /// </summary>
        [EnumMember(Value = "elevateId")]
        ElevateID,

        /// <summary>
        /// bannerSourcedId
        /// </summary>
        [EnumMember(Value = "bannerSourcedId")]
        BannerSourcedId,

        /// <summary>
        /// bannerUserName
        /// </summary>
        [EnumMember(Value = "bannerUserName")]
        BannerUserName,

        /// <summary>
        /// bannerUdcId
        /// </summary>
        [EnumMember(Value = "bannerUdcId")]
        BannerUdcId
    }
}