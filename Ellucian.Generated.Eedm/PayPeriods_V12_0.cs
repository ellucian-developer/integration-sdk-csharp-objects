//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The periods of time over which an employee's work time is recorded. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PayPeriods_V12_0 : BaseModel2
    {    
        /// <summary>
       /// The full name of the pay period.
       /// </summary>
         
       [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Title { get; set; }
     
        /// <summary>
       /// The description of the pay period.
       /// </summary>
         
       [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Description { get; set; }
     
        /// <summary>
       /// The start date of the pay period.
       /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("startOn", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTime? StartOn { get; set; }
     
        /// <summary>
       /// The end date of the pay period.
       /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("endOn", NullValueHandling = NullValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public DateTime? EndOn { get; set; }
     
        /// <summary>
       /// The scheduled check date.
       /// </summary>
         [JsonConverter(typeof(DateOnlyConverter))]  
       [JsonProperty("payDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime PayDate { get; set; }
     
        /// <summary>
       /// The pay cycle associated with the pay period.
       /// </summary> 
        [JsonProperty("payCycle", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 PayCycle { get; set; }
     
        /// <summary>
       /// The date and time when time entry is closed.
       /// </summary>
       [JsonProperty("timeEntryEndOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime? TimeEntryEndOn { get; set; }
         
     }      
}          
