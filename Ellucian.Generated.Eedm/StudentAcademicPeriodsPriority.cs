// Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A type of StudentAcademicPeriodsPriority
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentAcademicPeriodsPriority
    {
        /// <summary>
        /// 
        /// </summary>
        NotSet,

        /// <summary>
        /// Primary.
        /// </summary>
        [EnumMember(Value = "primary")]
        Primary
    }
}