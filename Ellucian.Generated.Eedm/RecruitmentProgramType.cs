// Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The recruitment program type for the academic program.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecruitmentProgramType
    {
        /// <summary>
        /// active
        /// </summary>
        [EnumMember(Value = "active")]
        Active
    }
}
