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
    /// The list of user defined statuses that may be applied to a section. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SectionStatuses_V11_0 : CodeItem2
    {    
       /// <summary>
       /// The category of the section status.
       /// </summary>  
       [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public SectionStatus2 Category { get; set; }
         
     }      
}          
