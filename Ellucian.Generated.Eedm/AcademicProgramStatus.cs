// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible statuses of an Academic Program
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AcademicProgramStatus
    {
        /// <summary>
        /// Academic Program is active (no end date exists).
        /// </summary>
        active,

        /// <summary>
        /// Academic Program is inactive (end date exists).
        /// </summary>
        inactive,
    }
}