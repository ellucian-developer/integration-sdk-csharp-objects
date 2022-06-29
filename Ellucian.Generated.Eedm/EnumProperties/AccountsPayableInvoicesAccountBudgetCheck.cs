// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indication if budget checking should be enforced or overridden.
    /// </summary>
    [JsonConverter(typeof (StringEnumConverter))]
    public enum AccountsPayableInvoicesAccountBudgetCheck
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// enforced used in V8
        /// </summary>
        [EnumMember(Value = "enforced")] 
        Enforced,

        /// <summary>
        /// overridden used in V8
        /// </summary>
        [EnumMember(Value = "overridden")] 
        Overridden,

        /// <summary>
        /// notRequired used in V8
        /// </summary>
        [EnumMember(Value = "notRequired")] 
        NotRequired,

        /// <summary>
        /// override Option used in V11 only.
        /// </summary>
        [EnumMember(Value = "override")]
        Override
    }
}