// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible benefits statuses of the employee (with or without benefits).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BenefitsStatus
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,

        /// <summary>
        /// With Benefits
        /// </summary>
        [EnumMember(Value = "withBenefits")]
        WithBenefits,

        /// <summary>
        /// Without Benefits
        /// </summary>
        [EnumMember(Value = "withoutBenefits")]
        WithoutBenefits
    }
}