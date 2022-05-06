  
  
 
 
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
    /// Meal plan components 
    /// </summary>
   [JsonObject(MemberSerialization.OptIn)]
    public class MealPlansComponents 
    {        


        /// <summary>
       /// The number of units included into the component of the meal plan
       /// </summary>
          
       [JsonProperty("numberOfUnits", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public Decimal? NumberOfUnits { get; set; }
     
        /// <summary>
       /// The type of the meal plan units
       /// </summary> 
       [JsonProperty("unitType", DefaultValueHandling = DefaultValueHandling.Ignore)] 
       //[JsonProperty("unitType")]  
       public MealPlansUnitType? UnitType { get; set; }
     
        /// <summary>
       /// The period of time the number of units is attached to
       /// </summary>  
       [JsonProperty("timePeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public MealPlansTimePeriod? TimePeriod { get; set; }
     
        /// <summary>
       /// Restrictions for the component of the meal plan
       /// </summary>
          
       [JsonProperty("restrictions", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public List<MealPlansRestrictions> Restrictions { get; set; }
      

     }      
}  

