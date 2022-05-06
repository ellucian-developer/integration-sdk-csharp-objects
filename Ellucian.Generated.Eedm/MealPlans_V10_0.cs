using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Meal plans available on campus 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MealPlans_V10_0 : CodeItem2
    {    
       /// <summary>
       /// Residential categories of students the plan applies to
       /// </summary> 
       [JsonProperty("studentResidentialCategories", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public List<GuidObject2> StudentResidentialCategories { get; set; }
     
       /// <summary>
       /// Meal plan components
       /// </summary>
       [JsonProperty("components", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public List<MealPlansComponents> Components { get; set; }
     
       /// <summary>
       /// The start date of the meal plan
       /// </summary>
       //[JsonConverter(typeof(DateOnlyConverter))]  
       [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime? StartOn { get; set; }
     
       /// <summary>
       /// The end date of the meal plan
       /// </summary>
       //[JsonConverter(typeof(DateOnlyConverter))]  
       [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime? EndOn { get; set; }
         
     }      
}          
