// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A unit or standard of measurement for the credit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StudentCourseTransferMeasure
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// credit
        /// </summary>
        [EnumMember(Value = "credit")]
        Credit,

        /// <summary>
        /// ceu
        /// </summary>
        [EnumMember(Value = "ceu")]
        Ceu,

        /// <summary>
        /// hour
        /// </summary>
        [EnumMember(Value = "hour")]
        Hour,
    }
}
