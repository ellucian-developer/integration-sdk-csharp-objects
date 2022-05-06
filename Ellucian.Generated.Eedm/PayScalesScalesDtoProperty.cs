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
    /// The pay structure based on grades with step levels. 
    /// </summary>
   [JsonObject(MemberSerialization.OptIn)]
    public class PayScalesScalesDtoProperty
    {        


        /// <summary>
       /// The grouping of salary or wage steps within a pay structure.
       /// </summary>
          
       [JsonProperty("grade", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public string Grade { get; set; }
     
        /// <summary>
       /// The different level of compensation for a position within the salary grade.
       /// </summary>
          
       [JsonProperty("step", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public string Step { get; set; }
     
        /// <summary>
       /// The amount associated with the specific pay scale.
       /// </summary>
          
       [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public Amount2DtoProperty Amount { get; set; }
      

     }      
}  

