// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An indicator specifying if the invoice is a standard or a refund invoice.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceTypes
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// invoice
        /// </summary>
        [EnumMember(Value = "invoice")]
        Invoice,

        /// <summary>
        /// refund
        /// </summary>
        [EnumMember(Value = "refund")]
        Refund,
    }
}