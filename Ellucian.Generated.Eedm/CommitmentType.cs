// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of commitment (committed or uncommitted).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CommitmentType
    {
        /// <summary>
        /// committed
        /// </summary>
        [EnumMember(Value = "committed")]
        Committed,

        /// <summary>
        /// uncommitted
        /// </summary>
        [EnumMember(Value = "uncommitted")]
        Uncommitted
    }
}
