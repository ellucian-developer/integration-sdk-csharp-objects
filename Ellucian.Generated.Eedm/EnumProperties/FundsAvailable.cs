// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of the direct deposit status for the account payable source.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FundsAvailable
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// Available
        /// </summary>
        [EnumMember(Value = "available")]
        Available,
        
        /// <summary>
        /// NotAvailable
        /// </summary>
        [EnumMember(Value = "notAvailable")]
        NotAvailable,
        
        /// <summary>
        /// OverrideAvailable
        /// </summary>
        [EnumMember(Value = "overrideAvailable")]
        OverrideAvailable,
        
        /// <summary>
        /// InvalidAccountingString
        /// </summary>
        [EnumMember(Value = "invalidAccountingString")]
        InvalidAccountingString,
        
        /// <summary>
        /// NotApplicable
        /// </summary>
        [EnumMember(Value = "notApplicable")]
        NotApplicable,

        /// <summary>
        /// Warning
        /// </summary>
        [EnumMember(Value = "warning")]
        Warning,
    }
}