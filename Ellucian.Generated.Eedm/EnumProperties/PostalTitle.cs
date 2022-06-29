// Copyright 2016-2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The name of the country when mail is being addressed from an international sender
    /// </summary>
     [JsonConverter(typeof(StringEnumConverter))]
    public enum PostalTitle
    {
        /// <summary>
        /// The country code for the AUSTRALIA
        /// </summary>
        [EnumMember(Value = "AUSTRALIA")]
        AUS,

        /// <summary>
        /// The country code for the BRAZIL
        /// </summary>
        [EnumMember(Value = "BRAZIL")]
        BRA,

        /// <summary>
        /// The country code for the CANADA
        /// </summary>
        [EnumMember(Value = "CANADA")]
        CAN,

        /// <summary>
        /// The country code for the MEXICO
        /// </summary>
        [EnumMember(Value = "MEXICO")]
        MEX,

        /// <summary>
        /// The country code for the NETHERLANDS
        /// </summary>
        [EnumMember(Value = "NETHERLANDS")]
        NLD,

         /// <summary>
        /// The country code for the USA
        /// </summary>
        [EnumMember(Value = "UNITED STATES OF AMERICA")]
        USA,

        /// <summary>
        /// The country code for the UK
        /// </summary>
        [EnumMember(Value = "UNITED KINGDOM OF GREAT BRITAIN AND NORTHERN IRELAND")]
        UK
    }
}
