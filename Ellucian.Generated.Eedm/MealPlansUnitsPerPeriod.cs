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
    /// Meal plan units per period 
    /// </summary>
   [JsonObject(MemberSerialization.OptIn)]
    public class MealPlansUnitsPerPeriod 
    {        
       /// <summary>
       /// The number of units allowed
       /// </summary>  
       [JsonProperty("numberOfUnits", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public Decimal NumberOfUnits { get; set; }
     
       /// <summary>
       /// The time period for the restriction
       /// </summary>
       [JsonProperty("period", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public MealPlansTimePeriod TimePeriod { get; set; }
     
     }      
}  

