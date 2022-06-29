// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Status type of the supplementary item.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AdmissionApplicationSupportingItemsType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// incomplete
        /// </summary>
        [EnumMember(Value = "incomplete")]
        Incomplete,

        /// <summary>
        /// received
        /// </summary>
        [EnumMember(Value = "received")]
        Received,

        /// <summary>
        /// waived
        /// </summary>
        [EnumMember(Value = "waived")]
        Waived,

        /// <summary>
        /// notReceived
        /// </summary>
        [EnumMember(Value = "notReceived")]
        Notreceived,
    }
}


