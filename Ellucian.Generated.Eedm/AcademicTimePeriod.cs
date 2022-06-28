// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An Academic Time Period
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AcademicTimePeriod
    {
        /// <summary>
        /// A time period of an academic year.
        /// </summary>
        Year,
        /// <summary>
        /// A time period of an academic term.
        /// </summary>
        Term,
        /// <summary>
        /// A time period of an academic sub-term.
        /// </summary>
        Subterm

    }
}