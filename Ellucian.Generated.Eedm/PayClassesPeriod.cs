// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// The default time period (e.g. day, week, month, etc.).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PayClassesPeriod
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
        /// year
        /// </summary>
        [EnumMember(Value = "year")]
        Year,

        /// <summary>
        /// payPeriod
        /// </summary>
        [EnumMember(Value = "payPeriod")]
        PayPeriod,
        }
} 


