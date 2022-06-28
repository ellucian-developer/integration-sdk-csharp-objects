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
    /// Information on pay for employees at each level. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PayScales_V11_0 : BaseModel2
    {    
       /// <summary>
       /// The full name of the pay scale.
       /// </summary>
       [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Title { get; set; }
     
        /// <summary>
       /// The code used to identify the pay scale.
       /// </summary>
       [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Code { get; set; }
     
       /// <summary>
       /// The start date of the pay scale.
       /// </summary>
       [JsonConverter(typeof(DateOnlyConverter))]  
       [JsonProperty("startOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime StartOn { get; set; }
     
       /// <summary>
       /// The end date of the pay scale.
       /// </summary>
       [JsonConverter(typeof(DateOnlyConverter))]  
       [JsonProperty("endOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public DateTime EndOn { get; set; }
     
       /// <summary>
       /// The classification associated with the pay scale.
       /// </summary>
       [JsonProperty("classification", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public GuidObject2 Classification { get; set; }
     
       /// <summary>
       /// The pay structure based on grades with step levels.
       /// </summary>
       [JsonProperty("scales", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public List<PayScalesScalesDtoProperty> Scales { get; set; }
         
     }      
}          
