// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// The interval for which rate is defined.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RoomRatesPeriod
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
       
                           
         /// <summary>
        /// day
        /// </summary>
        [EnumMember(Value = "day")]
        Day,
                     
         /// <summary>
        /// week
        /// </summary>
        [EnumMember(Value = "week")]
        Week,
                     
         /// <summary>
        /// month
        /// </summary>
        [EnumMember(Value = "month")]
        Month,
                     
         /// <summary>
        /// term
        /// </summary>
        [EnumMember(Value = "term")]
        Term,
                     
         /// <summary>
        /// year
        /// </summary>
        [EnumMember(Value = "year")]
        Year,
        }
} 


