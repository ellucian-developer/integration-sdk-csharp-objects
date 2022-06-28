// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The method by which the section grade was submitted.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubmissionMethodType
    {
        /// <summary>
        /// Auto
        /// </summary>
        [EnumMember(Value = "auto")]
        Auto,
        /// <summary>
        /// Manual
        /// </summary>
        [EnumMember(Value = "manual")]
        Manual
    }
}
