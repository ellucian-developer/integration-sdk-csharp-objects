// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A status indicating whether the asset has been disposed of or written off.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FixedAssetsStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// disposed
        /// </summary>
        [EnumMember(Value = "disposed")]
        Disposed,

        /// <summary>
        /// writtenOff
        /// </summary>
        [EnumMember(Value = "writtenOff")]
        Writtenoff,
    }
}