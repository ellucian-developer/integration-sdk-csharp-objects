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
    /// Meal plan restrictions 
    /// </summary>
   [JsonObject(MemberSerialization.OptIn)]
    public class MealPlansRestrictions
    {
       /// <summary>
       /// Meal types the meal plan component is restricted to
       /// </summary>
       [JsonProperty("mealTypes", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public List<GuidObject2> MealTypes { get; set; }

       /// <summary>
       /// Dining facilities included in the plan
       /// </summary>
       [JsonProperty("diningFacilities", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public List<GuidObject2> DiningFacilities { get; set; }

       /// <summary>
       /// Buildings included in the plan
       /// </summary>
       [JsonProperty("buildings", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public List<GuidObject2> Buildings { get; set; }

       /// <summary>
       /// Sites included in the plan
       /// </summary>
       [JsonProperty("sites", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public List<GuidObject2> Sites { get; set; }

       /// <summary>
       /// The number of units included into the component of the meal plan
       /// </summary> 
       [JsonProperty("numberOfUnits", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public Decimal NumberOfUnits { get; set; }
     
       /// <summary>
       /// Days of week
       /// </summary>
       [JsonProperty("daysOfWeek", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public List<DaysOfWeek> DaysOfWeek { get; set; }

       /// <summary>
       /// Maximum number of units within a time period allowed for the meal plan component
       /// </summary>
       //[JsonProperty("unitsPerPeriod", DefaultValueHandling = DefaultValueHandling.Ignore)]
       //public MealPlansUnitsPerPeriod UnitsPerPeriod { get; set; }
      
     }      
}  

