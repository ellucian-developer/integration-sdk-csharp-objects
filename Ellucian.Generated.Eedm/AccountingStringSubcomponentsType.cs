// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of subcomponent.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountingStringSubcomponentsType
    {
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,


        /// <summary>
        /// fund
        /// </summary>
        [EnumMember(Value = "fund")]
        Fund,

        /// <summary>
        /// function
        /// </summary>
        [EnumMember(Value = "function")]
        Function,

        /// <summary>
        /// object
        /// </summary>
        [EnumMember(Value = "object")]
        Object,

        /// <summary>
        /// unit
        /// </summary>
        [EnumMember(Value = "unit")]
        Unit,

        /// <summary>
        /// source
        /// </summary>
        [EnumMember(Value = "source")]
        Source,

        /// <summary>
        /// location
        /// </summary>
        [EnumMember(Value = "location")]
        Location,
    }
}
