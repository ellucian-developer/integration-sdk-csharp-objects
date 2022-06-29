// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of amount value expressed as either a credit or a debit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreditOrDebit
    {
        /// <summary>
        /// Credit
        /// </summary>
        [EnumMember(Value = "credit")]
        Credit,

        /// <summary>
        /// Debit
        /// </summary>
        [EnumMember(Value = "debit")]
        Debit
    }
}