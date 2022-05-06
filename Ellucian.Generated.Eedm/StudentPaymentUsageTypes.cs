// Copyright 2019 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Type of the charge the student incurred. 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentPaymentUsageTypes
    {
        /// <summary>
        /// No value set for this enumeration
        /// </summary>
        notset = 0,
        /// <summary>
        /// Tax Reporting Only
        /// </summary>
        [EnumMember(Value = "taxReportingOnly")]
        taxReportingOnly
    }
}