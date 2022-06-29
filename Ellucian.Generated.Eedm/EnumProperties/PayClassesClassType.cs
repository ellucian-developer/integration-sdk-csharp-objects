// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// An indicator if the pay class is supplemental to (used in addition to) another pay class.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PayClassesClassType
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
       
                           
         /// <summary>
        /// supplemental
        /// </summary>
        [EnumMember(Value = "supplemental")]
        Supplemental,
                     
         /// <summary>
        /// notSupplemental
        /// </summary>
        [EnumMember(Value = "notSupplemental")]
        Notsupplemental,
        }
} 


