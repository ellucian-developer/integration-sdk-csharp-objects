﻿// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible intervals
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IntervalTypes
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        /// 
        NotSet = 0,

        /// <summary>
        /// Day
        /// </summary>
        [EnumMember(Value = "day")]
        Day,

        /// <summary>
        /// Week
        /// </summary>
        [EnumMember(Value = "week")]
        Week,

        /// <summary>
        /// Month
        /// </summary>
        [EnumMember(Value = "month")]
        Month,

        /// <summary>
        /// Pay Period
        /// </summary>
        [EnumMember(Value = "term")]
        Term,
    }
}