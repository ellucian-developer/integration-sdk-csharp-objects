// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The higher-level category of marital status.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MaritalStatusType
    {
        /// <summary>
        /// Hispanic/Latino
        /// </summary>
        Single,

        /// <summary>
        /// Married
        /// </summary>
        Married,

        /// <summary>
        /// Divorced
        /// </summary>
        Divorced,

        /// <summary>
        /// Widowed
        /// </summary>
        Widowed,

        /// <summary>
        /// Separated
        /// </summary>
        Separated
    }
}