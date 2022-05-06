// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indication if direct deposit should not be used for the invoice or if the vendor default for direct deposit should be used.
    /// </summary>
    [JsonConverter(typeof (StringEnumConverter))]
    public enum AccountsPayableInvoicesDirectDepositOverride
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// default
        /// </summary>
        [EnumMember(Value = "default")] Default,

        /// <summary>
        /// noDirectDeposit
        /// </summary>
        [EnumMember(Value = "noDirectDeposit")] NoDirectDeposit,
    }
}