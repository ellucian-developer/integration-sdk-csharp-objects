// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible person identity document types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PersonIdentityDocumentCategory
    {
        /// <summary>
        /// Passport
        /// </summary>
        [EnumMember(Value = "passport")]
        Passport,
        /// <summary>
        /// Photo Id
        /// </summary>
        [EnumMember(Value = "photoId")]
        PhotoId,
        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}