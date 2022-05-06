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
    /// The different types of academic credits.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GradeCmplCreditType
    {
        /// <summary>
        /// Full
        /// </summary>
        [EnumMember(Value = "full")]
        Full,
        /// <summary>
        /// None
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
}
