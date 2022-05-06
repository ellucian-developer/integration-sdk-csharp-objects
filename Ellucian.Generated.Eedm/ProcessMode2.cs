// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration to specify process mode in a General Ledger Transaciton
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProcessMode2
    {
        /// <summary>
        /// Default value.
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// current
        /// </summary>
        [EnumMember(Value = "updateImmediate")]
        UpdateImmediate,

        /// <summary>
        /// expired
        /// </summary>
        [EnumMember(Value = "validate")]
        Validate,

        /// <summary>
        /// current
        /// </summary>
        [EnumMember(Value = "updateBatch")]
        UpdateBatch
    }
}
