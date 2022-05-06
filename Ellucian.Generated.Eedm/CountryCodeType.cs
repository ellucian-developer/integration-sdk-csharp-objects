// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Country Code
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CountryCodeType
    {
        /// <summary>
        /// The country code for the USA
        /// </summary>
        [EnumMember(Value = "USA")]
        USA
    }
}
