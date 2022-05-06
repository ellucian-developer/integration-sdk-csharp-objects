// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indicator as to whether the transaction was posted to the General Ledger
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GlPosting
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Transaction has been posted
        /// </summary>
        [EnumMember(Value = "posted")]
        posted,

        /// <summary>
        /// Transaction has been not posted
        /// </summary>
        [EnumMember(Value = "notPosted")]
        notPosted
    }
}
