// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Confidential level of the comment
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConfidentialCategory
    {
        /// <summary>
        /// private
        /// </summary>
        [EnumMember(Value = "private")]
        Private,

        /// <summary>
        /// public
        /// </summary>
        [EnumMember(Value = "public")]
        Public
    }
}
