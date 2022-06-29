// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The ISO 4217 currency code
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CurrencyCodes
    {
        /// <summary>
        /// Canadian Dollars
        /// </summary>
        CAD,
        /// <summary>
        /// US Dollars
        /// </summary>
        USD
    }
}