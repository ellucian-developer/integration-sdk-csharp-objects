//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The fee charge for room for a specified time interval. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class RoomRates_V10_0 : CodeItem2
    {    
       /// <summary>
       /// The first date the rate may be applied to a room.
       /// </summary>
       //[JsonConverter(typeof(DateOnlyConverter))]  
       [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime? StartOn { get; set; }
     
       /// <summary>
       /// The lastdate the rate may be applied to a room.
       /// </summary>
       //[JsonConverter(typeof(DateOnlyConverter))]  
       [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime? EndOn { get; set; }
     
        /// <summary>
       /// The interval for which rate is defined.
       /// </summary>
         
       [JsonProperty("period", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public RoomRatesPeriod Period { get; set; }
     
        /// <summary>
       /// The rate charged for the room for the period specified.
       /// </summary>
         
       [JsonProperty("rates", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public IEnumerable<RoomRatesRate> Rate { get; set; }
     
        /// <summary>
       /// The default accounting code to used when using the room rate.
       /// </summary>
         
       [JsonProperty("accountingCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 AccountingCode { get; set; }
     
        /// <summary>
       /// The default accounting code to used when a charge using the room rate is canceled.
       /// </summary>
         
       [JsonProperty("cancelAccountingCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 CancelAccountingCode { get; set; }
         
     }      
}          
