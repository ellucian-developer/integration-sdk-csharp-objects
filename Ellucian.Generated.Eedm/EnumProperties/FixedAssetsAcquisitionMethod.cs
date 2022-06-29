// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The acquisition method associated with the fixed asset.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FixedAssetsAcquisitionMethod
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// purchased
        /// </summary>
        [EnumMember(Value = "purchased")]
        Purchased,

        /// <summary>
        /// leased
        /// </summary>
        [EnumMember(Value = "leased")]
        Leased,

        /// <summary>
        /// donation
        /// </summary>
        [EnumMember(Value = "donation")]
        Donation,
    }
}