// Copyright 2017 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Enumeration of possible types of an Employment Proficiency Licensing
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EmploymentProficiencyLicensing
    {
        /// <summary>
        /// Required
        /// </summary>
        [EnumMember(Value = "required")]
        Required,

        /// <summary>
        /// NotRequired
        /// </summary>
        [EnumMember(Value = "notRequired")]
        NotRequired,
    }
}