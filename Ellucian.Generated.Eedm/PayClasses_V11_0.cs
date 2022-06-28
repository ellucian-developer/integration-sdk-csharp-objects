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
    /// The standard method of paying employees. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PayClasses_V11_0 : CodeItem2
    {    
        /// <summary>
       /// The number of pays per year employees are scheduled to receive.
       /// </summary>
         
       [JsonProperty("paysPerYear", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public decimal? PaysPerYear { get; set; }
     
        /// <summary>
       /// An indicator if the pay class is supplemental to (used in addition to) another pay class.
       /// </summary>
         
       [JsonProperty("classType", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public PayClassesClassType? ClassType { get; set; }

       /// <summary>
       /// The cycle at which employees are paid when they are working.
       /// </summary>

       [JsonProperty("payCycle", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 PayCycle { get; set; }

        /// <summary>
       /// The frequency at which employees are paid when they are working.
       /// </summary>
         
       [JsonProperty("payFrequency", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 PayFrequency { get; set; }
     
        /// <summary>
       /// The default pay period work hours for positions associated with the pay class.
       /// </summary>
         
       [JsonProperty("hoursPerPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public PayClassHoursPerPeriodDtoProperty HoursPerPeriod { get; set; }

        /// <summary>
       /// The status of the pay class (e.g. active or inactive).
       /// </summary>
         
       [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public PayClassesStatus? Status { get; set; }
     
        /// <summary>
       /// The compensation type associated with the pay class (e.g. salary or wages).
       /// </summary>
         
       [JsonProperty("compensationType", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public PayClassesCompensationType? CompensationType { get; set; }
         
     }      
}          
