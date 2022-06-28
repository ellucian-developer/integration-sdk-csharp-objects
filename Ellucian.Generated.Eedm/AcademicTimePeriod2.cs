// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An Academic Time Period
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AcademicTimePeriod2
    {
        /// <summary>
        /// A time period of an academic year.
        /// </summary>
        [EnumMember(Value = "year")]
        Year,
        /// <summary>
        /// A time period of an academic term.
        /// </summary>
        [EnumMember(Value = "term")]
        Term,
        /// <summary>
        /// A time period of an academic sub-term.
        /// </summary>
        [EnumMember(Value = "subterm")]
        Subterm

    }
}