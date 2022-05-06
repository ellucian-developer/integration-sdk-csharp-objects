// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an financial aid year status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FinancialAidYearStatus
    {
        /// <summary>
        /// Active
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Inactive
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive,
    }
}