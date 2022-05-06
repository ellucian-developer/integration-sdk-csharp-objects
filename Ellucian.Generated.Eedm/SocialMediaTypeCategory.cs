// Copyright 2015-2018 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an social media type
    /// </summary>
    [JsonConverter(typeof(SocialMediaTypeCategoryEnumConverter))]
    public enum SocialMediaTypeCategory
    {
        /// <summary>
        /// Windows Live
        /// </summary>
        [EnumMember(Value = "windowsLive")]
        windowsLive,

        /// <summary>
        /// Yahoo
        /// </summary>
        [EnumMember(Value = "yahoo")]
        yahoo,

        /// <summary>
        /// Skype
        /// </summary>
        [EnumMember(Value = "skype")]
        skype,

        /// <summary>
        /// QQ
        /// </summary>
        [EnumMember(Value = "qq")]
        qq,

        /// <summary>
        /// Hangouts
        /// </summary>
        [EnumMember(Value = "hangouts")]
        hangouts,

        /// <summary>
        /// ICQ
        /// </summary>
        [EnumMember(Value = "icq")]
        icq,

        /// <summary>
        /// Jabber
        /// </summary>
        [EnumMember(Value = "jabber")]
        jabber,

        /// <summary>
        /// Facebook
        /// </summary>
        [EnumMember(Value = "facebook")]
        facebook,

        /// <summary>
        /// Twitter
        /// </summary>
        [EnumMember(Value = "twitter")]
        twitter,

        /// <summary>
        /// Instagram
        /// </summary>
        [EnumMember(Value = "instagram")]
        instagram,

        /// <summary>
        /// Tumblr
        /// </summary>
        [EnumMember(Value = "tumblr")]
        tumblr,

        /// <summary>
        /// Pinterest
        /// </summary>
        [EnumMember(Value = "pinterest")]
        pinterest,

        /// <summary>
        /// LinkedIn
        /// </summary>
        [EnumMember(Value = "linkedin")]
        linkedin,

        /// <summary>
        /// FourSquare
        /// </summary>
        [EnumMember(Value = "foursquare")]
        foursquare,

        /// <summary>
        /// Youtube
        /// </summary>
        [EnumMember(Value = "youtube")]
        youtube,

        /// <summary>
        /// Blog
        /// </summary>
        [EnumMember(Value = "blog")]
        blog,

        /// <summary>
        /// Website
        /// </summary>
        [EnumMember(Value = "website")]
        website,

        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "other")]
        other
    }
}