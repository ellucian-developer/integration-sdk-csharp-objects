// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indication of whether the commnet is printed or not
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CommentTypes
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// printed
        /// </summary>
        [EnumMember(Value = "printed")]
        Printed,

        /// <summary>
        /// not-printed
        /// </summary>
        [EnumMember(Value = "notPrinted")]
        NotPrinted
      
    }
}