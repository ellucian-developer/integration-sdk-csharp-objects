// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an Identity Document Type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdentityDocumentTypeCategory
    {
        /// <summary>
        /// Passport
        /// </summary>
        [EnumMember(Value = "passport")]
        Passport,

        /// <summary>
        /// Photo ID
        /// </summary>
        [EnumMember(Value = "photoId")]
        PhotoID,

        /// <summary>
        /// Birth Ceritificate
        /// </summary>
        [EnumMember(Value = "other")]
        Other,
    }
}