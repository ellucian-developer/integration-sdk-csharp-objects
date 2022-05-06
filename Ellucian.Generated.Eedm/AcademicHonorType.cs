// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an Academic Honor Type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AcademicHonorType
    {
        /// <summary>
        /// Award granted in recognition of outstanding academic achievement.
        /// </summary>
        award,

        /// <summary>
        /// Distinction granted based upon graduation grade-point-average
        /// </summary>
        distinction,

    }
}