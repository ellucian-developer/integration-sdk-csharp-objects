// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of tax application of an deduction type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeductionTypeTaxApplicationType
    {
        /// <summary>
        /// PostTax
        /// </summary>
        [EnumMember(Value = "postTax")]
        PostTax,

        /// <summary>
        /// PreTax
        /// </summary>
        [EnumMember(Value = "preTax")]
        PreTax

    }
}