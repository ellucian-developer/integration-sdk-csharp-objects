// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// The ISO 3166-1 alpha-3 country code for Australia.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShipToDestinationsCode
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
       
                           
         /// <summary>
        /// AUS
        /// </summary>
        [EnumMember(Value = "AUS")]
        AUS,
        }
} 


